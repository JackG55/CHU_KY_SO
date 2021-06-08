using System;
using System.Net;
using DevExpress.Xpo;

namespace LanServerApp
{

    public class UserLoginInfo
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public UserLoginInfo()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }
        public UserLoginInfo(string username,string password)
        {
            Username = username;
            Password = password;
        }
       
    }
    public class UserInfo
    {
        public IPEndPoint UserIP { get;set;}
        public UserLoginInfo LoginInfo { get; set; }
        public UserInfo(UserLoginInfo loginfo, IPEndPoint uep)
        {
            LoginInfo = loginfo;
            UserIP = uep;
        }
        public string ToString()
        {
            return this.LoginInfo.Username + ":" + this.UserIP.Address.ToString();
        }
    }
}