using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Connect.DTA;

namespace WindowsFormsApp1.Connect
{
    public static class DTO
    {
        public static List<UserEmail> GetEmails()
        {
            var sql = "select Email from TAI_KHOAN";
            DataTable dt = WindowsFormsApp1.Connect.connection.FillDataSet(sql).Tables[0];
            List<UserEmail> listEmails = new List<UserEmail>();
            listEmails = WindowsFormsApp1.Connect.connection.ConvertDataTable<UserEmail>(dt);
            return listEmails;
        }
    }
}
