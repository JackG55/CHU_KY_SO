using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WindowsFormsApp1.SQL;

namespace WindowsFormsApp1.Chu_ky_so
{
    public partial class Chon_chu_ky : DevExpress.XtraEditors.XtraForm
    {

        CHU_KY_SQL CHU_KY_SQL = new CHU_KY_SQL();

        int ma_user = 1;

        public string rootfolder_anh = @"E:\Desktop\Thuc_tap_CNTT\Anh\1\Chu_ky\";
        public string file_not_found = @"E:\Code\Github\CHU_KY_SO\WindowsFormsApp1\WindowsFormsApp1\Resources\404.png";

        public Chon_chu_ky()
        {
            InitializeComponent();
            InitComboBox();
        }



        /// <summary>
        /// lấy ra các chữ ký của user
        /// </summary>
        private void InitComboBox()
        {
            cbBoxChu_ky.SelectedValueChanged -= cbBoxChu_ky_SelectedValueChanged;

            cbBoxChu_ky.DataSource = CHU_KY_SQL.Get_Chu_ky(ma_user).Tables[0];
            cbBoxChu_ky.DisplayMember = "Ten_chu_ky";
            cbBoxChu_ky.ValueMember = "Ma_chu_ky";
            int ma_chu_ky =Convert.ToInt32(cbBoxChu_ky.SelectedValue.ToString());
            string duong_dan_chu_ky = CHU_KY_SQL.Get_hinh_anh_dau_tien(ma_chu_ky);
            Bitmap image = new Bitmap(rootfolder_anh + duong_dan_chu_ky);
            piceditChu_ky.Image = image;
            Hien_thi_thong_tin(ma_chu_ky);

            cbBoxChu_ky.SelectedValueChanged += cbBoxChu_ky_SelectedValueChanged;
        }

        private void bt_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_ky_Click(object sender, EventArgs e)
        {
            //luu anh vao bien static
        }

        private void cbBoxChu_ky_SelectedValueChanged(object sender, EventArgs e)
        {

            //ma_chu_ky
            int ma_chu_ky =Convert.ToInt32(cbBoxChu_ky.SelectedValue.ToString());

            //hien thi hinh anh
            string duong_dan_chu_ky = CHU_KY_SQL.Get_duong_dan_chu_ky(ma_chu_ky);
            try
            {
                Bitmap image = new Bitmap(rootfolder_anh + duong_dan_chu_ky);
                piceditChu_ky.Image = image;
            }
            catch
            {
                Bitmap image = new Bitmap(file_not_found);
                piceditChu_ky.Image = image;
            }


            //hien thi thong tin
            Hien_thi_thong_tin(ma_chu_ky);
        }


        public void Hien_thi_thong_tin(int ma_chu_ky)
        {
            DataSet a = new DataSet();
            a = CHU_KY_SQL.GetThongTin(ma_user, ma_chu_ky);

            lb_ten_chu_so_huu.Text = a.Tables[0].Rows[0]["Ten_user"].ToString();
            lb_noi_cap.Text  = a.Tables[0].Rows[0]["Ten_co_quan"].ToString();
            lb_thoi_gian.Text = a.Tables[0].Rows[0]["Thoi_gian_cap"].ToString() + " đến " + a.Tables[0].Rows[0]["Thoi_gian_het_han"].ToString();
        }
    }
}