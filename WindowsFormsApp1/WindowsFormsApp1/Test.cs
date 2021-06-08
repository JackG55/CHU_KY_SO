using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Connect;
using WindowsFormsApp1.Connect.DTA;
using WindowsFormsApp1.SignD;
using WindowsFormsApp1.Transport;

namespace WindowsFormsApp1
{
    public partial class Test : Form
    {
        private ClientSocket clientSocket;
        public Test()
        {
            InitializeComponent();
        }

        private void connectbtn_Click(object sender, EventArgs e)
        {
            this.clientSocket = new ClientSocket();
            this.clientSocket.ConnectingSuccess += new ConnectingSuccessEventHandler(ConnectingSuccess);
            this.clientSocket.ConnectingFail += new ConnectingFailEventHandler(ConnectingFail);
            this.clientSocket.CommandReceived += new CommandReceivedEventHandler(CommandReceived);
            this.clientSocket.MessageSent += new MessageSentEventHandler(MessageSent);

            this.clientSocket.ConnectToServer("127.0.0.1", 11000 , "kaan");
        }
        private void ConnectingSuccess(object sender,ConnectingSuccessEventArgs ea)
        {
        }
        private void ConnectingFail(object sender,EventArgs ea)
        {

        }
        private void CommandReceived(object sender,CommandReceivedEventArgs ea)
        {
            Command cmd = (Command)ea.Command;
            switch (cmd.CommandType)
            {
                case Transport.CommandType.RequireUserAuthorize:
                    this.clientSocket.LoginToServer(new User("kiennguyen@gmail.com", "12345"));
                    break;
                //case CommandType.SendClientList:
                //    this.UpdateListUser(cmd.MetaData);
                //    break;
                //case CommandType.UserLoginFail:
                default:
                    break;
            }
        }
        private void MessageSent(object sender,MessageSentEventArgs ea)
        {

        }

        private void openfilebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfl = new OpenFileDialog();
            if(opfl.ShowDialog()  == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    this.filename.Text = opfl.FileName;
                }
                catch
                {
                    MessageBox.Show("Error!");
                }
            }
        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            if (this.filename.Text == "")
                MessageBox.Show("Please open the file!");
            else
            {
                byte[] filedata = File.ReadAllBytes(this.filename.Text);
                this.clientSocket.SendFile(filedata, this.targetUserName.Text, Path.GetFileName(this.filename.Text));
            }
        }

        private void Test_Load(object sender, EventArgs e)
        {
            var emails = new List<string>();
            DTO.GetEmails().ForEach(ue =>
           {
               this.targetUserName.Items.Add(ue.Email);
           });
            this.targetUserName.SelectedIndex = 0;
        }
    }
}
