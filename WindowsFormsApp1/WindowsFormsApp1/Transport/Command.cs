using System.Net;

namespace WindowsFormsApp1.Transport
{
    public class Command
    {
        private CommandType cmdType;
        /// <summary>
        /// The type of command to send.If you wanna use the Message command type,create a Message class instead of command.
        /// </summary>
        public CommandType CommandType
        {
            get { return cmdType; }
            set { cmdType = value; }
        }

        private string senderName;
        /// <summary>
        /// [Gets/Sets] The name of command sender.
        /// </summary>
        public string SenderName
        {
            get { return senderName; }
            set { senderName = value; }
        }

        private string targetName;
        /// <summary>
        /// [Gets/Sets] the name of target
        /// </summary>
        public string TargetName
        {
            get { return targetName; }
            set { targetName = value; }
        }
        private object commandBody;
        /// <summary>
        /// The body of the command.This string is different in various commands.
        /// <para>Message : The text of the message.</para>
        /// <para>ClientLoginInform,SendClientList : "RemoteClientIP:RemoteClientName".</para>
        /// <para>***WithTimer : The interval of timer in miliseconds..The default value is 60000 equal to 1 min.</para>
        /// <para>IsNameExists : 'True' or 'False'</para>
        /// <para>Otherwise pass the "" or null.</para>
        /// </summary>
        public object MetaData
        {
            get { return commandBody; }
            set { commandBody = value; }
        }
        private string filename;
        public string Filename { 
            get { return filename; }
            set { filename = value; } 
        }
        /// <summary>
        /// constructor Command
        /// </summary>
        /// <param name="type"></param>
        /// <param name="senderMachine"></param>
        /// <param name="targetMachine"></param>
        /// <param name="metaData"></param>
        public Command(CommandType type,string senderMachine, string targetMachine, object metaData)
        {
            this.cmdType = type;
            this.senderName = senderMachine;
            this.targetName = targetMachine;
            this.commandBody = metaData;
        }
        public Command(CommandType type,string senderMachine,string targetMachine,string filename,object metaData)
        {
            this.cmdType = type;
            this.senderName = senderMachine;
            this.targetName = targetMachine;
            this.filename = filename;
            this.commandBody = metaData;
        }
    }
}
