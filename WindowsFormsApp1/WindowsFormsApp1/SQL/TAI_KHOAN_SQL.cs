using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Connect;

namespace WindowsFormsApp1.SQL
{
    class TAI_KHOAN_SQL:connection
    {
        public DataSet Get_Tai_khoan(int ma_user)
        {
            DataSet result = new DataSet();
            result = connection.FillDataSet("SELECT * FROM dbo.TAI_KHOAN EXCEPT SELECT * FROM dbo.TAI_KHOAN WHERE Ma_user =  '" + ma_user + "'");
            return result;
        }
    }
}
