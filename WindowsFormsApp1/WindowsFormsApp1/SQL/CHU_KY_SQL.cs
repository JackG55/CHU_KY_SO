using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Connect;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.SQL
{
    class CHU_KY_SQL:connection
    {


        

        /// <summary>
        /// lấy ra danh sách chữ ký của user đó
        /// SELECT Ten_chu_ky FROM dbo.CHU_KY WHERE Ma_user = 'ma_user'
        /// </summary>
        /// <param name="ma_user"></param>
        /// <returns></returns>
        public DataSet Get_Chu_ky(string ma_user)
        {
            DataSet result = new DataSet();
            result = connection.FillDataSet("SELECT * FROM dbo.CHU_KY WHERE Ma_user = " + ma_user);
            return result;
        }


        public int Get_kieu_chu_ky (string ma_chu_ky)
        {
            int result;
            string sqlcmd = "SELECT Kieu_chu_ky FROM dbo.CHU_KY WHERE Ma_chu_ky = " + ma_chu_ky;
            result = Convert.ToInt32(connection.docGiaTri(sqlcmd));
            return result;
        }
    }
}
