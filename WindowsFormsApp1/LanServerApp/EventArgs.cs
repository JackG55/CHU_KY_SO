using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanServerApp
{
    /// <summary>
    /// Occurs when a client socket connect successfully to server.
    /// </summary>
    /// <param name="sender">Sender.</param>
    /// <param name="e">The received command object.</param>
    public delegate void AcceptConnectSuccessEventHandler(object sender, ConnectSuccessEventArgs ea);
    public delegate void RequireAuthorizeSuccessEventHandler(object sender, RequireAuthorizeSuccessEventArgs ea);
    public delegate void RequireAuthorizeFailEventHandler(object sender, RequireAuthorizeFailEventArgs ea);
    public delegate void AuthorizationSuccessEventHandler(object sender, AuthorizationSuccessEventArgs ea);
    public delegate void AuthorizationFailEventHandler(object sender, AuthorizationFailEventArgs ea);
    public delegate void CommandReceivedEventHandler(object sender, CommandReceivedEventArgs ea);
    public delegate void CommandSentEventHandler(object sender, CommandSentEventArgs ea);
    public delegate void CommandFailEventHandler(object sender, EventArgs ea);
    public delegate void DisconnectedEventHandler(object sender, DisconnectedEventArgs ea);
    
    public class ConnectSuccessEventArgs : EventArgs
    {
        public IPAddress IP {
            get {
                return ((IPEndPoint)(this.client.clientSocket.RemoteEndPoint)).Address;
            }
        }
        public int Port {
            get {
                return ((IPEndPoint)(this.client.clientSocket.RemoteEndPoint)).Port;
            }
        }
        private ClientManager client;
        public ClientManager clientManager
        {
            get
            {
                return this.client;
            }
        }
        public ConnectSuccessEventArgs(ClientManager clientManager)
        {
            this.client = clientManager;
        }
    }
    public class RequireAuthorizeSuccessEventArgs:EventArgs
    {

    }
    public class RequireAuthorizeFailEventArgs : EventArgs
    {

    }
    public class AuthorizationSuccessEventArgs: EventArgs {
        public AuthorizationSuccessEventArgs()
        {

        }
    }
    public class AuthorizationFailEventArgs : EventArgs
    {
        public AuthorizationFailEventArgs() { }
    }
    public class CommandReceivedEventArgs : EventArgs
    {
        private Command command;
        private ClientManager clientManager;
        /// <summary>
        /// The received command.
        /// </summary>
        public Command Command
        {
            get { return command; }
        }
        public ClientManager Client
        {
            get { return this.clientManager; }
        }
        /// <summary>
        /// Creates an instance of CommandEventArgs class.
        /// </summary>
        /// <param name="cmd">The received command.</param>
        public CommandReceivedEventArgs(ClientManager clientManager,Command cmd)
        {
            this.command = cmd;
            this.clientManager = clientManager;
        }
    }
    public class CommandSentEventArgs:EventArgs
    {
        private ClientManager client;
        public Command Command
        {
            get;set;
        }
        public ClientManager Client
        {
            get
            {
                if (this.client != null)
                    return this.client;
                else return null;
            }
        }
        public CommandSentEventArgs(ClientManager clientManager)
        {
            this.client = clientManager;
        }
    }
    public class CommandSentFailEventArgs:EventArgs
    {

    }
    public class DisconnectedEventArgs : EventArgs
    {
        public ClientManager client { get; set; }
        public UserInfo ClientInfo { 
            get {
                return this.client.ClientInfo;
            } 
            set {
                this.ClientInfo = value;
            } 
        }
        public DisconnectedEventArgs(ClientManager client)
        {
            this.client = client;
        }
    }
}
