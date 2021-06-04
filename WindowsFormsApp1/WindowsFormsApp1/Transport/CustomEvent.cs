using System;
using System.Net.Sockets;

namespace WindowsFormsApp1.Transport
{
    public delegate void ConnectingSuccessEventHandler(object sender, ConnectingSuccessEventArgs e);
    public delegate void ConnectingFailEventHandler(object sender, EventArgs e);
    public delegate void CommandReceivedEventHandler(object sender, CommandReceivedEventArgs e);
    public delegate void MessageSentEventHandler(object sender, MessageSentEventArgs e);
    public delegate void MessageSentFailEventHandler(object sender, MessageSentFailEventArgs e);
    public delegate void ServerDisconnectedEventHandler(object sender, ServerDisconnectedEventArgs e);
    public class ConnectingSuccessEventArgs : EventArgs
    {
        public string Message { get; set; }
        public ConnectingSuccessEventArgs() { }
        public ConnectingSuccessEventArgs(string message)
        {
            this.Message = message;
        }
    }
    public class CommandReceivedEventArgs : EventArgs
    {
        private Command command;
        public Command Command { get { return this.command; } }
        public CommandReceivedEventArgs(Command cmd)
        {
            this.command = cmd;
        }
        public CommandReceivedEventArgs() { }

    }
    public class MessageSentEventArgs : EventArgs
    {
        public string Message { get; set; }
        public MessageSentEventArgs() { }
        public MessageSentEventArgs(string message)
        {
            this.Message = message;
        }
    }
    public class MessageSentFailEventArgs : EventArgs
    {
        public string Message { get; set; }
        public MessageSentFailEventArgs() { }
        public MessageSentFailEventArgs(string message)
        {
            this.Message = message;
        }
    }
    public class ServerDisconnectedEventArgs : EventArgs
    {
        private Socket server;
        public Socket Socket
        {
            get
            {
                return this.server;
            }
        }
        public ServerDisconnectedEventArgs(Socket socketServer)
        {
            this.server = socketServer;
        }
    }
}
