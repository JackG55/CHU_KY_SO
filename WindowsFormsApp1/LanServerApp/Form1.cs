using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanServerApp
{
    public partial class Form1 : Form
    {
        private AsyncSocketListener socketServer;
        private BackgroundWorker bwForm;
        private List<UserInfo> activeUsers;
        private List<UserLoginInfo> users = new List<UserLoginInfo>();
        public Form1()
        {
            InitializeComponent();
            activeUsers = new List<UserInfo>();
            socketServer = new AsyncSocketListener();
            socketServer.bwListener.WorkerSupportsCancellation = true;
            socketServer.bwListener.DoWork += new DoWorkEventHandler(StartToListen);
            socketServer.bwListener.RunWorkerAsync();
            
        }
        private void StartToListen(object sender, DoWorkEventArgs e)
        {
            Action<string> DelegateTeste_ModifyText = THREAD_MOD;
            this.messagebox.Invoke(DelegateTeste_ModifyText, "Waiting for connections....");
            this.socketServer.listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            this.socketServer.listenerSocket.Bind(new IPEndPoint(this.socketServer.serverIP, this.socketServer.serverPort));
            this.socketServer.listenerSocket.Listen(200);
            while (true)
                this.CreateNewClientManager(this.socketServer.listenerSocket.Accept());
        }
        private void CreateNewClientManager(Socket socket)
        {
            ClientManager newClientManager = new ClientManager(socket);
            newClientManager.AcceptConnectSuccess += new AcceptConnectSuccessEventHandler(AcceptConnectSuccess);
            newClientManager.AuthorizationSuccess += new AuthorizationSuccessEventHandler(AuthorizationSuccess);
            newClientManager.CommandReceived += new CommandReceivedEventHandler(CommandReceived);
            newClientManager.CommandSent += new CommandSentEventHandler(CommandSent);
            newClientManager.Disconnected += new DisconnectedEventHandler(ClientDisconnected);
            this.CheckAccept(newClientManager);
            this.CheckForAbnormalDC(newClientManager);
            this.socketServer.clients.Add(newClientManager);
        }
        private void CheckAccept(ClientManager clm)
        {
            clm.Accepted();
        }
        private void AuthorizationSuccess(object sender,AuthorizationSuccessEventArgs e)
        {
            
        }
        private void CheckForAbnormalDC(ClientManager client)
        {
            if(this.RemoveClientManager(client))
            {
                Action<string> AddToMessageBox = THREAD_MOD;
                this.messagebox.Invoke(AddToMessageBox, client.IP.ToString() + " Disconnected.");
            }
        }
        private bool RemoveClientManager(ClientManager client)
        {
            lock(this)
            {
                int index = this.IndexOfClient(client.IP,client.Port);
                if (index != -1)
                {
                    //string name = this.socketServer.clients[index].ClientName;
                    this.socketServer.clients.RemoveAt(index);

                    //Inform all clients that a client had been disconnected.
                    //Command cmd = new Command(CommandType.ClientLogOffInform, IPAddress.Broadcast);
                    //cmd.SenderName = name;
                    //cmd.SenderIP = ip;
                    //this.BroadCastCommand(cmd);
                    return true;
                }
                return false;
            }
        }
        private int IndexOfClient(IPAddress ip,int port)
        {
            int index = -1;
            foreach (ClientManager cMngr in this.socketServer.clients)
            {
                index++;
                if (cMngr.IP.Equals(ip) && cMngr.Port.Equals(port))
                    return index;
            }
            return -1;
        }
        private void THREAD_MOD(string message)
        {
            messagebox.Text += Environment.NewLine + message;
        }
        private void THREAD_MOD_LISTUSER(string message)
        {
            listUser.Text += message + Environment.NewLine;
        }
        private void AcceptConnectSuccess(object sender,ConnectSuccessEventArgs e)
        {
            Action<string> DelegateTeste_ModifyText = THREAD_MOD;
            this.messagebox.Invoke(DelegateTeste_ModifyText, e.IP.ToString() + " has connected");
            ClientManager clm = e.clientManager;
            clm.Authorize();
        }
        private void CommandReceived(object sender,CommandReceivedEventArgs e)
        {
            Action<string> DelegateTeste_ModifyText = THREAD_MOD;
            this.messagebox.Invoke(DelegateTeste_ModifyText, e.Command.Target.ToString() + " sent a login response info");
            Command cmd = e.Command;
            switch(cmd.CommandType)
            {
                case CommandType.UserLogin:
                    this.CheckUserLogin(e.Client,JsonConvert.DeserializeObject<UserLoginInfo>((string)cmd.MetaData));
                    break;
                case CommandType.SendClientList:
                    this.SendListUser(e.Client, users);
                    break;
                case CommandType.SendFile:
                    this.SaveFile((byte[])cmd.MetaData);
                    break;
                default:
                    break;
            }
        }
        private void SaveFile(byte[] fileData)
        {
            try
            {
                using (var fs = new FileStream("../../test.pdf", FileMode.Create, FileAccess.Write))
                {
                    fs.Write(fileData, 0, fileData.Length);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in process: {0}", ex);
            }
        }
        private void SendListUser(ClientManager client,List<UserLoginInfo> users)
        {
            Command cmd = new Command(CommandType.SendClientList, client.IP, JsonConvert.SerializeObject(users));
            client.SendCommand(cmd);
        }
        private void CheckUserLogin(ClientManager client,UserLoginInfo user)
        {
            // check user simple
            if (user.Username != "" && user.Password != "")
            {
                //login success
                UserInfo usrif = new UserInfo(user, (IPEndPoint)client.clientSocket.RemoteEndPoint);
                
                client.ClientInfo = usrif;

                Action<string> UserLoginSuccess = THREAD_MOD;
                Action<string> ListUserUpdate = THREAD_MOD_LISTUSER;
                this.messagebox.Invoke(UserLoginSuccess, usrif.ToString() + " login successfully");
                this.listUser.Invoke(ListUserUpdate, usrif.ToString());
                List<UserInfo> users = new List<UserInfo>();
                this.users.Add(user);
                this.socketServer.clients.ForEach((clt) =>
               {
                   this.SendListUser(clt, this.users);
               });
                //foreach (UserInfo u in activeUsers)
                //{
                //    if (u.UserName != user.Username)
                //        users.Add(u);
                //    this.activeUsers.Add(usrif);
                //    client.SendCommand(new Command(CommandType.SendClientList, client.IP, JsonConvert.SerializeObject(users)));
                //    // command to all active clients


                //}
                //Command cmd = new Command(CommandType.ClientLoginInform, this.socketServer.serverIP, JsonConvert.SerializeObject(usrif));
                //this.socketServer.clients.ForEach(clt =>
                //{
                //    if (clt.IP != client.IP)
                //        clt.SendCommand(cmd);
                //});
            }
            else
            {
                Action<string> UserLoginInfoIncorrect = THREAD_MOD;
                this.messagebox.Invoke(UserLoginInfoIncorrect, "Thong tin dang nhap khong chinh xac");
            }
        }
        private void CommandSent(object sender,CommandSentEventArgs e)
        {
            Action<string> AddToMessageBox = THREAD_MOD;
            this.messagebox.Invoke(AddToMessageBox, e.Client.IP.ToString() + " sent a command");
        }
        private void ClientDisconnected(object sender,DisconnectedEventArgs e)
        {
            if (this.RemoveClientManager(e.client))
            {
                Action<string> AddToMessageBox = THREAD_MOD;
                this.messagebox.Invoke(AddToMessageBox, e.ClientInfo.LoginInfo.Username + ":" + e.client.IP.ToString() + " Disconnected");
            }
        }
        private void startbtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
