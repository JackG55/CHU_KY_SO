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
using DevExpress.XtraEditors.Controls;
using WindowsFormsApp1.SignD;

namespace WindowsFormsApp1.Chu_ky_so
{
    public partial class Chu_ky : DevExpress.XtraEditors.XtraForm
    {

        CHU_KY_SQL CHU_KY_SQL = new CHU_KY_SQL();
        int status = 0;     //1 là sửa          //2 là tạo mới
        string ma_user = "1";


        //fullimage size: width : 314   height: 214
        //image_anh size:   width: 153  height: 212
        //image_thong_tin size: width: 158 height: 212

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
            btnLoadAnh.Visible = false;

            
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

            //xoa panel
            panel2.Controls.Clear();


            //xoa checked
            radioBt_anh_va_thong_tin.Checked = false;
            radioBt_anh.Checked = false;
            radioBt_thong_tin.Checked = false;


        }

        private void cbBoxTen_chu_ky_SelectedValueChanged(object sender, EventArgs e)
        {
            //hien thi ten chu ky
            lb_Ten_mau.Visible = true;
            tbTen_mau.Visible = true;
            tbTen_mau.Text = cbBoxTen_chu_ky.Text;

            //chuyen status
            status = 0;

            //ma_chu_ky
            string ma_chu_ky = cbBoxTen_chu_ky.SelectedValue.ToString();

            //hien thi check box
            int kieu_chu_ky = CHU_KY_SQL.Get_kieu_chu_ky(ma_chu_ky);
            Check(kieu_chu_ky);


            //hien thi hinh anh
            string duong_dan_chu_ky = CHU_KY_SQL.Get_duong_dan_chu_ky(ma_chu_ky);
            try
            {
                Bitmap image = new Bitmap(@"E:\Desktop\Thuc_tap_CNTT\Anh\1\Chu_ky\" + duong_dan_chu_ky);
                Set_Full_Image(image);
            }
            catch
            {
                Bitmap image = new Bitmap(@"E:\Code\Github\CHU_KY_SO\WindowsFormsApp1\WindowsFormsApp1\Resources\404.png");
                Set_Full_Image(image);
            }
            
            



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

        bool isFull = false;

        private void radioBt_anh_va_thong_tin_CheckedChanged(object sender, EventArgs e)
        {
            if(status==2)
            {
                panel2.Controls.Clear();
                
                //hien nut load anh
                btnLoadAnh.Visible = true;

                //đổi isFull thành false
                isFull = false;

                //hien thi mac dinh
                string txt = CHU_KY_SQL.Thong_tin(ma_user);
                Bitmap image_thong_tin = Images.Convert(txt, panel2.Width, panel2.Height);
                Bitmap image_anh = new Bitmap(@"E:\Code\Github\CHU_KY_SO\WindowsFormsApp1\WindowsFormsApp1\Resources\hoc-vien-ki-thuat-quan-su-he-quan-su.jpg");

                Set_Two_Image(image_anh, image_thong_tin);


            }    
           
            
        }

        private void radioBt_anh_CheckedChanged(object sender, EventArgs e)
        {
            if(status==2)
            {
                panel2.Controls.Clear();

                //hien nut load anh
                btnLoadAnh.Visible = true;

                //đổi isfull thành true
                isFull = true;

                //hien thi mac dinh
                Bitmap image_anh = new Bitmap(@"E:\Code\Github\CHU_KY_SO\WindowsFormsApp1\WindowsFormsApp1\Resources\hoc-vien-ki-thuat-quan-su-he-quan-su.jpg");

                Set_Full_Image(image_anh);

            }

        }

        private void radioBt_thong_tin_CheckedChanged(object sender, EventArgs e)
        {
            if(status==2)
            {
                panel2.Controls.Clear();
                btnLoadAnh.Visible = false;

                string txt = CHU_KY_SQL.Thong_tin(ma_user);
                Bitmap a = Images.Convert(txt, panel2.Width, panel2.Height);
                Set_Full_Image(a);

            }    
          
        }



        public void Set_Full_Image (Bitmap image)
        {
            panel2.Controls.Clear();
            PictureEdit a = new PictureEdit
            {
                Dock = DockStyle.Fill,
                Image = image,
               
            };
            a.Properties.SizeMode = PictureSizeMode.Stretch;
            
            panel2.Controls.Add(a);
        }


        public void Set_Two_Image(Bitmap image_anh, Bitmap image_thong_tin)
        {
            panel2.Controls.Clear();
            PictureEdit a = new PictureEdit
            {
                Dock = DockStyle.Left,
                Width = 143,
                Height = 212, 
                Image = image_anh
            };
            a.Properties.SizeMode = PictureSizeMode.Stretch;
            panel2.Controls.Add(a);
            PictureEdit b = new PictureEdit
            {
                Dock = DockStyle.Right,
                Width = panel2.Width - a.Width,
                Height = 212, 
                Image = image_thong_tin
            };
            b.Properties.SizeMode = PictureSizeMode.Stretch;
            panel2.Controls.Add(b);
        }

       
    }
}