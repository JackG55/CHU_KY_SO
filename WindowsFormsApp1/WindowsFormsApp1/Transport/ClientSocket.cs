using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Transport
{
    public class ClientSocket
    {
        private Socket clientSocket;
        private NetworkStream networkStream;
        private BackgroundWorker bwReceiver;
        private IPEndPoint serverEP;
        private string networkName = "";
        public IPAddress IP
        {
            get
            {
                if (this.clientSocket != null && this.clientSocket.Connected)
                    return (this.serverEP).Address;
                else return null;
            }
        }
        public string NetworkName
        {
            get
            {
                if (this.clientSocket != null && this.clientSocket.Connected)
                    return this.networkName;
                else return null;
            }
        }
        public int Port
        {
            get
            {
                if (this.clientSocket != null && this.clientSocket.Connected)
                    return this.serverEP.Port;
                else return -1;
            }
        }
        public ClientSocket(IPEndPoint ipe)
        {
            this.serverEP = ipe;
        }
        public ClientSocket()
        {
        }

        #region Public
        public void ConnectToServer(string host, int port, string networkName)
        {
            this.networkName = networkName;
            this.serverEP = new IPEndPoint(IPAddress.Parse(host), port);
            var bwConnector = new BackgroundWorker();
            bwConnector.DoWork += new DoWorkEventHandler(bwConnectorDoWork);
            bwConnector.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bwConnectorRunWorkerCompleted);
            bwConnector.RunWorkerAsync();
        }
        public void SendCommand(Command cmd)
        {
            if (this.clientSocket != null && this.clientSocket.Connected)
            {
                BackgroundWorker bwSender = new BackgroundWorker();
                bwSender.WorkerSupportsCancellation = true;
                bwSender.DoWork += new DoWorkEventHandler(bwSenderDoWork);
                bwSender.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bwSenderRunWorkerCompleted);
                bwSender.RunWorkerAsync(cmd);
            }
        }

        #endregion
        #region Private
        private void bwConnectorDoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                this.clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                if (this.serverEP != null)
                {
                    this.clientSocket.Connect(this.serverEP);
                    this.networkStream = new NetworkStream(this.clientSocket);
                }
                e.Result = true;
                this.bwReceiver = new BackgroundWorker();
                this.bwReceiver.WorkerSupportsCancellation = true;
                this.bwReceiver.DoWork += new DoWorkEventHandler(StartReceived);
                this.bwReceiver.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bwReceiverRunWorkerCompleted);
                this.bwReceiver.RunWorkerAsync();
            }
            catch
            {
                e.Result = false;
            }
        }
        private void bwSenderDoWork(object sender, DoWorkEventArgs e)
        {
            Command cmd = (Command)e.Argument;
            e.Result = this.SendCommandToServer(cmd);
        }
        System.Threading.Semaphore semaphor = new System.Threading.Semaphore(1, 1);
        private bool SendCommandToServer(Command cmd)
        {
            try
            {
                semaphor.WaitOne();
                if (cmd.MetaData == null || cmd.MetaData == "")
                    this.SetMetaDataIfIsNull(cmd);


                //CommandType
                byte[] buffer = new byte[4];
                buffer = BitConverter.GetBytes((int)cmd.CommandType);
                this.networkStream.Write(buffer, 0, 4);
                this.networkStream.Flush();


                //command sender name
                byte[] senderBuffer = Encoding.ASCII.GetBytes(cmd.SenderName);

                buffer = new byte[4];
                buffer = BitConverter.GetBytes(senderBuffer.Length);

                this.networkStream.Write(buffer, 0, 4);
                this.networkStream.Flush();

                this.networkStream.Write(senderBuffer, 0, senderBuffer.Length);
                this.networkStream.Flush();


                //Command Target
                byte[] targetBuffer = Encoding.ASCII.GetBytes(cmd.TargetName);
                buffer = new byte[4];
                buffer = BitConverter.GetBytes(targetBuffer.Length);

                this.networkStream.Write(buffer, 0, 4);
                this.networkStream.Flush();

                this.networkStream.Write(targetBuffer, 0, targetBuffer.Length);
                this.networkStream.Flush();

                // if sendfile
                if (cmd.CommandType == CommandType.SendFile)
                {
                    byte[] fnBuffer = Encoding.ASCII.GetBytes(cmd.Filename);
                    buffer = new byte[4];
                    buffer = BitConverter.GetBytes(fnBuffer.Length);

                    this.networkStream.Write(buffer, 0, 4);
                    this.networkStream.Flush();

                    this.networkStream.Write(fnBuffer, 0, fnBuffer.Length);
                    this.networkStream.Flush();
                }
                //Command MetaData
                byte[] metaBuffer;
                if (cmd.CommandType == CommandType.SendFile)
                    metaBuffer = (byte[])cmd.MetaData;
                else metaBuffer = Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(cmd.MetaData));

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
                case (CommandType.ClientLoginInform):
                    cmd.MetaData = this.IP.ToString() + ":" + this.networkName;
                    break;
                case (CommandType.PCLockWithTimer):
                case (CommandType.PCLogOFFWithTimer):
                case (CommandType.PCRestartWithTimer):
                case (CommandType.PCShutDownWithTimer):
                case (CommandType.UserExitWithTimer):
                    cmd.MetaData = "60000";
                    break;
                default:
                    cmd.MetaData = "\n";
                    break;
            }
        }
        private void bwSenderRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled && e.Error == null && ((bool)e.Result))
            {
                this.OnMessageSent(new MessageSentEventArgs("Message sent."));
            }
            else
            {
                this.OnMessageSentFail(new MessageSentFailEventArgs("Message sent fail."));
            }
            ((BackgroundWorker)sender).Dispose();
            GC.Collect();
        }
        private void bwReceiverRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!(e.Cancelled) && e.Error == null && (bool)e.Result)
            {
                //do something in work completed
            }
            else
            {
                //do something in work not completed
            }
            ((BackgroundWorker)sender).Dispose();
            GC.Collect();
        }
        private void StartReceived(object sender, DoWorkEventArgs e)
        {
            while (this.clientSocket.Connected)
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

                //Read the command's sender name.
                buffer = new byte[senderNameSize];
                readBytes = this.networkStream.Read(buffer, 0, senderNameSize);
                if (readBytes == 0)
                    break;
                string senderName = System.Text.Encoding.ASCII.GetString(buffer);

                //Read the command's target name  size.
                string targetName = "";
                buffer = new byte[4];
                readBytes = this.networkStream.Read(buffer, 0, 4);
                if (readBytes == 0)
                    break;
                int targetSize = BitConverter.ToInt32(buffer, 0);

                //Read the command's target.
                buffer = new byte[targetSize];
                readBytes = this.networkStream.Read(buffer, 0, targetSize);
                if (readBytes == 0)
                    break;
                targetName = Encoding.ASCII.GetString(buffer);

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

                Command cmd = new Command(cmdType,senderName, targetName, buffer);
                //cmd.SenderIP = senderIP;
                //cmd.SenderName = senderName;
                this.OnCommandReceived(new CommandReceivedEventArgs(cmd));
            }
            this.OnServerDisconnected(new ServerDisconnectedEventArgs(this.clientSocket));
            this.Disconnect();
        }
        public bool DisconnectToServer(User user)
        {
            if (this.clientSocket != null && this.clientSocket.Connected)
            {
                try
                {
                    this.SendCommand(new Command(CommandType.UserExit, this.networkName , this.serverEP.Address.ToString(), user));
                    this.clientSocket.Shutdown(SocketShutdown.Both);
                    this.clientSocket.Close();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else return false;
        }

        private void bwConnectorRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!((bool)e.Result))
                this.OnConnectingFail(new EventArgs());
            else
                this.OnConnectingSuccess(new ConnectingSuccessEventArgs("Connected Successfully"));

            ((BackgroundWorker)sender).Dispose();
        }

        private bool Disconnect()
        {
            if (this.clientSocket != null && this.clientSocket.Connected)
            {
                try
                {
                    this.clientSocket.Shutdown(SocketShutdown.Both);
                    this.clientSocket.Close();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else return false;
        }
        #endregion


        #region with server


        public void LoginToServer(User user)
        {
            Command cmd = new Command(CommandType.UserLogin,"test" ,this.serverEP.Address.ToString(), user);
            this.SendCommand(cmd);
        }

        public void GetListUserInfo()
        {
            Command cmd = new Command(CommandType.SendClientList,"test" ,this.serverEP.Address.ToString(),"");
            this.SendCommand(cmd);
        }
        public void SendFile(byte[] fileData, string targetUser,string filename)
        {
            Command cmd = new Command(CommandType.SendFile,this.NetworkName, targetUser, filename,fileData);
            //cmd.SenderIP = this.IP;
            //cmd.SenderName = this.networkName;
            //cmd.Target = 
            this.SendCommand(cmd);
        }




        #endregion




        #region Events

        public event ConnectingSuccessEventHandler ConnectingSuccess;
        public virtual void OnConnectingSuccess(ConnectingSuccessEventArgs e)
        {
            if (this.ConnectingSuccess != null)
                this.ConnectingSuccess(this, e);
        }
        public event ConnectingFailEventHandler ConnectingFail;
        public virtual void OnConnectingFail(EventArgs e)
        {
            if (this.ConnectingFail != null)
                ConnectingFail(this, e);
        }
        public event CommandReceivedEventHandler CommandReceived;
        public virtual void OnCommandReceived(CommandReceivedEventArgs mrea)
        {
            if (this.CommandReceived != null)
                CommandReceived(this, mrea);
        }
        public event MessageSentEventHandler MessageSent;
        public virtual void OnMessageSent(MessageSentEventArgs msea)
        {
            if (this.MessageSent != null)
                MessageSent(this, msea);
        }
        public event MessageSentFailEventHandler MessageSentFail;
        public virtual void OnMessageSentFail(MessageSentFailEventArgs e)
        {
            if (this.MessageSentFail != null)
                MessageSentFail(this, e);
        }
        public event ServerDisconnectedEventHandler ServerDisconnected;
        public virtual void OnServerDisconnected(ServerDisconnectedEventArgs e)
        {
            if (this.ServerDisconnected != null)
                ServerDisconnected(this, e);
        }
        #endregion
    }
}
