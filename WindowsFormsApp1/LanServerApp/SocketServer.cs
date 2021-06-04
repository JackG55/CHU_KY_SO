using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LanServerApp
{
    public class StateObject
    {
        // Size of receive buffer.  
        public const int BufferSize = 1024;

        // Receive buffer.  
        public byte[] buffer = new byte[BufferSize];

        // Received data string.
        public StringBuilder sb = new StringBuilder();

        // Client socket.
        public Socket workSocket = null;
    }

    public class AsyncSocketListener
    {
        // Thread signal.  
        public static ManualResetEvent allDone = new ManualResetEvent(false);
        public System.Collections.Generic.List<ClientManager> clients;
        public BackgroundWorker bwListener;
        public Socket listenerSocket;
        public IPAddress serverIP;
        public int serverPort;
        public ClientManager currentClient;
        public AsyncSocketListener()
        {
            this.clients = new List<ClientManager>();
            this.bwListener = new BackgroundWorker();
            this.serverIP = IPAddress.Any;
            this.serverPort = 11000;
        }
        #region Public
        #endregion
        #region Private
        #endregion

        #region Events
        #endregion
    }
}
