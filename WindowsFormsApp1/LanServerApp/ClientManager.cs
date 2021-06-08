using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanServerApp
{
    public class ClientManager
    {
        public IPAddress IP
        {
            get
            {
                if (this.socket != null)
                    return ((IPEndPoint)this.socket.RemoteEndPoint).Address;
                else
                    return IPAddress.None;
            }
        }
        /// <summary>
        /// Gets the port number of connected remote client.This is -1 if the client is not connected.
        /// </summary>
        public int Port
        {
            get
            {
                if (this.socket != null)
                    return ((IPEndPoint)this.socket.RemoteEndPoint).Port;
                else
                    return -1;
            }
        }
        /// <summary>
        /// [Gets] The value that specifies the remote client is connected to this server or not.
        /// </summary>
        public bool Connected
        {
            get
            {
                if (this.socket != null)
                    return this.socket.Connected;
                else
                    return false;
            }
        }

        private Socket socket;
        public Socket clientSocket { 
            get {
                if (this.socket != null && this.socket.Connected)
                    return this.socket;
                else return null;
            } 
        }
        private UserInfo clientInfo;
        /// <summary>
        /// The name of remote client.
        /// </summary>
        public UserInfo ClientInfo
        {
            get { return this.clientInfo; }
            set { this.clientInfo = value; }
        }
        NetworkStream networkStream;
        private BackgroundWorker bwReceiver;

        public Form1 parrentForm;
        #region Constructor
        /// <summary>
        /// Creates an instance of ClientManager class to comunicate with remote clients.
        /// </summary>
        /// <param name="clientSocket">The socket of ClientManager.</param>
        public ClientManager(Socket clientSocket)
        {
            this.socket = clientSocket;
            this.networkStream = new NetworkStream(this.socket);
            this.bwReceiver = new BackgroundWorker();
            this.bwReceiver.DoWork += new DoWorkEventHandler(StartReceive);
            this.bwReceiver.RunWorkerAsync();
        }
        #endregion
        #region Public Methods
        public void SendCommand(Command cmd)
        {
            if (this.socket != null && this.socket.Connected)
            {
                BackgroundWorker bwSender = new BackgroundWorker();
                bwSender.WorkerSupportsCancellation = true;
                bwSender.DoWork += new DoWorkEventHandler(bwSenderDoWork);
                bwSender.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bwSenderRunWorkerCompleted);
                bwSender.RunWorkerAsync(cmd);
            }
            else
                this.OnCommandFail(new CommandSentFailEventArgs());
        }

        public void Authorize()
        {
            Command cmd = new Command(CommandType.RequireUserAuthorize,this.IP.ToString(),"test","");
            this.SendCommand(cmd);
        }
        public void Accepted()
        {
            this.OnAcceptConnectSuccess(new ConnectSuccessEventArgs(this));
            
        }
        #endregion

        #region Private Methods


        private void bwSenderDoWork(object sender,DoWorkEventArgs e)
        {
            Command cmd = (Command)e.Argument;
            e.Result = this.SendCommandToClient(cmd);
        }
        System.Threading.Semaphore semaphor = new System.Threading.Semaphore(1, 1); // dung de tranh deadlock do su dung nhieu luong 
        private bool SendCommandToClient(Command cmd)
        {
            try
            {
                semaphor.WaitOne();
                if (cmd.MetaData == null || (string)cmd.MetaData == "")
                    this.SetMetaDataIfIsNull(cmd);
                //CommandType
                byte[] buffer = new byte[4];
                buffer = BitConverter.GetBytes((int)cmd.CommandType);
                this.networkStream.Write(buffer, 0, 4);
                this.networkStream.Flush();

                //Command sender
                byte[] senderNameBuffer = Encoding.ASCII.GetBytes(cmd.SenderName);
                buffer = new byte[4];
                buffer = BitConverter.GetBytes(senderNameBuffer.Length);
                // write length
                this.networkStream.Write(buffer, 0, 4);
                this.networkStream.Flush();
                ////Write the command's sender Email.
                this.networkStream.Write(senderNameBuffer, 0, senderNameBuffer.Length);
                this.networkStream.Flush();

                //command target
                byte[] ipBuffer = Encoding.ASCII.GetBytes(cmd.TargetName.ToString());
                buffer = new byte[4];
                buffer = BitConverter.GetBytes(ipBuffer.Length);
                this.networkStream.Write(buffer, 0, 4);
                this.networkStream.Flush();
                this.networkStream.Write(ipBuffer, 0, ipBuffer.Length);
                this.networkStream.Flush();
                //Command MetaData
                byte[] metaBuffer = Encoding.Unicode.GetBytes((string)cmd.MetaData);
                buffer = new byte[4];
                buffer = BitConverter.GetBytes(metaBuffer.Length);
                this.networkStream.Write(buffer, 0, 4);
                this.networkStream.Flush();
                this.networkStream.Write(metaBuffer, 0, metaBuffer.Length);
                this.networkStream.Flush();
                semaphor.Release();
                return true;
            }
            catch
            {
                semaphor.Release();
                return false;
            }
        }
        private void SetMetaDataIfIsNull(Command cmd)
        {
            switch (cmd.CommandType)
            {
                case (CommandType.RequireUserAuthorize):
                    cmd.MetaData = "\n";
                    break;
                default:
                    cmd.MetaData = "\n";
                    break;
            }
        }
        private void bwSenderRunWorkerCompleted(object sender,RunWorkerCompletedEventArgs e)
        {
            if(!e.Cancelled && e.Error == null && ((bool)e.Result))
            {
                // do something 
                this.OnCommadSent(new CommandSentEventArgs(this));
                // ...
            }
            else
            {
                // do something
                this.OnCommandFail(new CommandSentFailEventArgs());
                //...
            }
            ((BackgroundWorker)sender).Dispose();
            GC.Collect();
        }
        private void StartReceive(object sender, DoWorkEventArgs e)
        {
            while (this.socket.Connected)
            {
                //Read the command's Type.
                byte[] buffer = new byte[4];
                int readBytes = this.networkStream.Read(buffer, 0, 4);
                if (readBytes == 0)
                    break;
                CommandType cmdType = (CommandType)(BitConverter.ToInt32(buffer, 0));

                //Read the command's sender name size.

                buffer = new byte[4];
                readBytes = this.networkStream.Read(buffer, 0, 4);
                if (readBytes == 0)
                    break;
                int senderNameSize = BitConverter.ToInt32(buffer, 0);

                ////Read the command's sender name.
                buffer = new byte[senderNameSize];
                readBytes = this.networkStream.Read(buffer, 0, senderNameSize);
                if (readBytes == 0)
                    break;
                string senderName = System.Text.Encoding.ASCII.GetString(buffer);

                //Read the command's target size.
                string targetName = "";
                buffer = new byte[4];
                readBytes = this.networkStream.Read(buffer, 0, 4);
                if (readBytes == 0)
                    break;
                int targetNameSize = BitConverter.ToInt32(buffer, 0);

                //Read the command's target email
                buffer = new byte[targetNameSize];
                readBytes = this.networkStream.Read(buffer, 0, targetNameSize);
                if (readBytes == 0)
                    break;
                targetName = Encoding.ASCII.GetString(buffer);
                // if sendfile
                string fileName = "";
                if (cmdType == CommandType.SendFile)
                {
                    
                    buffer = new byte[4];
                    readBytes = this.networkStream.Read(buffer, 0, 4);
                    if (readBytes == 0)
                        break;
                    int fileNameSize = BitConverter.ToInt32(buffer, 0);

                    //Read the command's target email
                    buffer = new byte[fileNameSize];
                    readBytes = this.networkStream.Read(buffer, 0, fileNameSize);
                    if (readBytes == 0)
                        break;
                    fileName = Encoding.ASCII.GetString(buffer);
                }
                //Read the command's MetaData size.
                buffer = new byte[4];
                readBytes = this.networkStream.Read(buffer, 0, 4);
                if (readBytes == 0)
                    break;
                int metaDataSize = BitConverter.ToInt32(buffer, 0);

                //Read the command's Meta data.
                buffer = new byte[metaDataSize];
                readBytes = this.networkStream.Read(buffer, 0, metaDataSize);
                if (readBytes == 0)
                    break;
                Command cmd = new Command(cmdType, senderName, targetName, buffer);
                if (cmd.CommandType == CommandType.SendFile)
                    cmd.Filename = fileName;
                this.OnCommandReceived(new CommandReceivedEventArgs(this,cmd));
            }
            this.OnDisconnected(new DisconnectedEventArgs(this));
            this.Disconnect();
        }
        private bool Disconnect()
        {
            if (this.socket != null && this.socket.Connected)
            {
                try
                {
                    this.socket.Shutdown(SocketShutdown.Both);
                    this.socket.Close();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
                return true;
        }
        #endregion
        #region Events
        /// <summary>
        /// Occur when a socket is accepted in server.
        /// </summary>

        public event AcceptConnectSuccessEventHandler AcceptConnectSuccess;
        public virtual void OnAcceptConnectSuccess(ConnectSuccessEventArgs e)
        {
            if (AcceptConnectSuccess != null)
                AcceptConnectSuccess(this, e);
        }
        public event AuthorizationSuccessEventHandler AuthorizationSuccess;
        public virtual void OnAuthorizationSuccess(AuthorizationSuccessEventArgs e)
        {
            if(this.AuthorizationSuccess != null)
            {
                AuthorizationSuccess(this, e);
            }
        }
        public event AuthorizationFailEventHandler AuthorizationFail;
        public virtual void OnAuthorizationFail(AuthorizationFailEventArgs e)
        {
            if (this.AuthorizationFail != null)
                AuthorizationFail(this, e);
        }
        public event CommandReceivedEventHandler CommandReceived;
        public virtual void OnCommandReceived(CommandReceivedEventArgs e)
        {
            if (this.CommandReceived != null)
                CommandReceived(this,e);
        }
        public event CommandSentEventHandler CommandSent;
        public virtual void OnCommadSent(CommandSentEventArgs e)
        {
            if (this.CommandSent != null)
                CommandSent(this, e);
        }
        public event CommandFailEventHandler CommandFail;
        public virtual void OnCommandFail(CommandSentFailEventArgs e)
        {
            if(this.CommandFail != null)
            {
                CommandFail(this, e);
            }
        }
        public event DisconnectedEventHandler Disconnected;
        public virtual void OnDisconnected(DisconnectedEventArgs e)
        {
            if (this.Disconnected != null)
                Disconnected(this, e);
        }
        public event RequireAuthorizeSuccessEventHandler RequiredAuthorize;
        public virtual void OnRequireAuthorizeSuccess(RequireAuthorizeSuccessEventArgs e)
        {
            if (this.RequiredAuthorize != null)
                RequiredAuthorize(this, e);
        }
        #endregion
    }
}
