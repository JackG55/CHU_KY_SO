using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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


        /// <summary>
        /// lấy ra kiểu chữ ký
        /// </summary>
        /// <param name="ma_chu_ky"></param>
        /// <returns></returns>
        public int Get_kieu_chu_ky (string ma_chu_ky)
        {
            int result;
            string sqlcmd = "SELECT Kieu_chu_ky FROM dbo.CHU_KY WHERE Ma_chu_ky = " + ma_chu_ky;
            result = Convert.ToInt32(connection.docGiaTri(sqlcmd));
            return result;
        }


        /// <summary>
        /// lấy đường dẫn hình ảnh của chữ ký
        /// </summary>
        /// <param name="ma_chu_ky"></param>
        /// <returns></returns>
        public string Get_duong_dan_chu_ky(string ma_chu_ky)
        {
            string result="";
            string sqlcmd = "SELECT Duong_dan_chu_ky FROM dbo.CHU_KY WHERE Ma_chu_ky = " + ma_chu_ky;
            result = connection.docGiaTri(sqlcmd).ToString();
            return result;
            
        }


        /// <summary>
        /// lấy ra thông tin người dùng dưới dạng chuỗi
        /// </summary>
        /// <param name="ma_user"></param>
        /// <returns></returns>
        public string Thong_tin(string ma_user)
        {
            string result="";
            string sqlcmd = "SELECT Ten_chuc_vu FROM dbo.NGUOI_DUNG JOIN dbo.CHUC_VU ON CHUC_VU.Ma_chuc_vu = NGUOI_DUNG.Ma_chuc_vu WHERE Ma_user =  " + ma_user;
            string ten_chuc_vu = connection.docGiaTri(sqlcmd).ToString();

            sqlcmd = "SELECT Ten_co_quan FROM dbo.NGUOI_DUNG JOIN dbo.CO_QUAN ON CO_QUAN.Ma_co_quan = NGUOI_DUNG.Ma_co_quan WHERE Ma_user = " + ma_user;
            string ten_co_quan = connection.docGiaTri(sqlcmd).ToString();

            sqlcmd = "SELECT Ten_user FROM dbo.NGUOI_DUNG WHERE Ma_chuc_vu = " + ma_user;
            string ten_nguoi = connection.docGiaTri(sqlcmd).ToString();

            result += ten_nguoi;
            result += "\n";

            result += ten_co_quan;
            result += "\n";

            result += ten_chuc_vu;
            result += "\n"; 

            return result;
        }


        



        public bool Them_Chu_ky(CHU_KY chu_ky)
        {
            string query = "THEM_CHU_KY";
            string[] para;
            para = new string[8];
            para[0] = "@ma_chu_ky";
            para[1] = "@ma_user";
            para[2] = "@thoi_gian_cap";
            para[3] = "@thoi_gian_het_han";
            para[4] = "@duong_dan_chu_ky";
            para[5] = "@ten_chu_ky";
            para[6] = "@duong_dan_anh";
            para[7] = "@kieu_chu_ky";
            object[] values;
            values = new object[8];
            values[0] = chu_ky.Ma_chu_ky;
            values[1] = chu_ky.Ma_user;
            values[2] = chu_ky.Thoi_gian_cap1;
            values[3] = chu_ky.Thoi_gin_het_han1;
            values[4] = chu_ky.Duong_dan_chu_ky1;
            values[5] = chu_ky.Ten_chu_ky;
            values[6] = chu_ky.Duong_dan_anh1;
            values[7] = chu_ky.Kieu_chu_ky1;
            try
            {
                int a = connection.Excute_Sql(query, CommandType.StoredProcedure, para, values);
                if (a != 0)
                    return true;
                return false;
            }
            catch (SqlException ex)
            {
                //DialogResult d;
                //d = MessageBox.Show("Thông tin thêm không hợp lệ!");
                return false;
            }
            finally
            {
                connection.close();
            }
        }


        public bool Xoa_Chu_ky(string ma_chu_ky)
        {
            string query = "XOA_CHU_KY";
            string[] para;
            para = new string[1];
            para[0] = "@ma_chu_ky";
            object[] values;
            values = new object[1];
            values[0] = ma_chu_ky;
            
            try
            {
                int a = connection.Excute_Sql(query, CommandType.StoredProcedure, para, values);
                if (a != 0)
                    return true;
                return false;
            }
            catch (SqlException ex)
            {
                //DialogResult d;
                //d = MessageBox.Show("Thông tin thêm không hợp lệ!");
                return false;
            }
            finally
            {
                connection.close();
            }
        }


        public bool Sua_Chu_ky(string ma_chu_ky, string ten_chu_ky)
        {
            string query = "SUA_CHU_KY";
            string[] para;
            para = new string[2];
            para[0] = "@ma_chu_ky";
            para[1] = "@ten_chu_ky";
            object[] values;
            values = new object[1];
            values[0] = ma_chu_ky;
            values[1] = ten_chu_ky;

            try
            {
                int a = connection.Excute_Sql(query, CommandType.StoredProcedure, para, values);
                if (a != 0)
                    return true;
                return false;
            }
            catch (SqlException ex)
            {
                //DialogResult d;
                //d = MessageBox.Show("Thông tin thêm không hợp lệ!");
                return false;
            }
            finally
            {
                connection.close();
            }
        }
    }
}
