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
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Chu_ky_so
{
    public partial class Chu_ky : DevExpress.XtraEditors.XtraForm
    {

        CHU_KY_SQL CHU_KY_SQL = new CHU_KY_SQL();
        int status = 0;     //1 là sửa          //2 là tạo mới
        string ma_user = "1";


        //fullimage size: width : 314   height: 214
        //image1 siez:

        public Chu_ky()
        {
            InitializeComponent();
            InitCbBox();
        }

        

        /// <summary>
        /// khởi tạo comboBox chữ ký
        /// </summary>
        public void InitCbBox()
        {
            cbBoxTen_chu_ky.SelectedValueChanged -= cbBoxTen_chu_ky_SelectedValueChanged;

            cbBoxTen_chu_ky.DataSource = CHU_KY_SQL.Get_Chu_ky(ma_user).Tables[0];
            cbBoxTen_chu_ky.DisplayMember = "Ten_chu_ky";
            cbBoxTen_chu_ky.ValueMember = "Ma_chu_ky";


            lb_Ten_mau.Visible = false;
            tbTen_mau.Visible = false;

            
            cbBoxTen_chu_ky.SelectedValueChanged += cbBoxTen_chu_ky_SelectedValueChanged;
            

        }



        private void bt_luu_Click(object sender, EventArgs e)
        {
            //them moi
            if(status == 2)
            {

            }
            else //chinh sua
            {

            }
        }

        private void btnTao_moi_Click(object sender, EventArgs e)
        {
            //hien thi ten chu ky de nhap
            lb_Ten_mau.Visible = true;
            tbTen_mau.Visible = true;
            tbTen_mau.Text = "";

            //chuyen status
            status = 2;
        }

        private void cbBoxTen_chu_ky_SelectedValueChanged(object sender, EventArgs e)
        {
            //hien thi ten chu ky
            lb_Ten_mau.Visible = true;
            tbTen_mau.Visible = true;
            tbTen_mau.Text = cbBoxTen_chu_ky.Text;


            //hien thi check box
            int kieu_chu_ky = CHU_KY_SQL.Get_kieu_chu_ky(cbBoxTen_chu_ky.SelectedValue.ToString());
            Check(kieu_chu_ky);


            //hien thi hinh anh
            



        }


        public void Check(int kieu_chu_ky)
        {
            radioBt_anh_va_thong_tin.Checked = false;
            radioBt_anh.Checked = false;
            radioBt_thong_tin.Checked = false;
            if(kieu_chu_ky==1)
            {
                radioBt_anh_va_thong_tin.Checked = true;
            }    
            else if(kieu_chu_ky == 2)
            {
                radioBt_thong_tin.Checked = true;
            }    
            else if(kieu_chu_ky == 3)
            {
                radioBt_anh.Checked = true;
            }    
        }
    }
}