using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Transport
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public User(string un, string pw)
        {
            Username = un;
            Password = pw;
        }
    }
}
