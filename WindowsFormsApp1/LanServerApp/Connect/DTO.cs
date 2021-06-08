using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanServerApp.Connect
{
    public static class DTO
    {
        public static bool checkLogin(string username,string password)
        {
            string result = "";
            var reader = Connection.DataReader("CheckPassword", System.Data.CommandType.StoredProcedure, new string[] { "@username", "@password" }, new object[] { username, password });
            while(reader.Read())
            {
                result = reader[0].ToString();
            }
            return result == "true" ? true : false;
        }
        public static void SaveToDB(string filename,string senderName, string targetName,string title,int status)
        {
            Connection.Excute_non_return_Querry("AddCommand", System.Data.CommandType.StoredProcedure,
                new string[] { "@sender", "@receiver", "@path", "@tgian", "@title", "@status" },
                new object[] { senderName, targetName, filename, DateTime.Now, title, status });
        }
    }
}
