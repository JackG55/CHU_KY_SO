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
using System.Security.Cryptography.X509Certificates;
using WindowsFormsApp1.Connect;
using System.IO;

namespace WindowsFormsApp1.Chu_ky_so
{
    public partial class Chu_ky : DevExpress.XtraEditors.XtraForm
    {

        CHU_KY_SQL CHU_KY_SQL = new CHU_KY_SQL();
        int status = 0;     //1 là sửa          //2 là tạo mới
        int ma_user = 1;


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

            panel2.Controls.Clear();

            radioButton_enable(false);

            btnXoa.Visible = true;
            
        }


        /// <summary>
        /// kiểm tra các trường xem đã điền đủ chưa
        /// </summary>
        /// <returns></returns>
        private bool Kiem_tra_cac_truong()
        {
            if(tbTen_mau.Text == "" )
            {
                return false;
            }
            else if(radioBt_thong_tin.Checked == false && fileName==mac_dinh )
            {
                return false;
            }    
            else
            {
                return true;
            }
           
        }

        /// <summary>
        /// xác định kiểu chữ ký
        /// </summary>
        /// <returns></returns>
        private int Kieu_chu_ky()
        {
            if(radioBt_anh_va_thong_tin.Checked == true)
            {
                return 1;
            }    
            else if(radioBt_anh.Checked == true)
            {
                return 2;
            }    
            else if(radioBt_thong_tin.Checked == true)
            {
                return 3;
            }
            else
            {
                return 0;
            }
        }

        private void radioButton_enable(bool gia_tri)
        {
            radioBt_anh_va_thong_tin.Enabled = gia_tri;
            radioBt_anh.Enabled = gia_tri;
            radioBt_thong_tin.Enabled = gia_tri;
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            //them moi
            if(status == 2)
            {
                if(Kiem_tra_cac_truong() == true)
                {
                    CHU_KY temp = new CHU_KY();
                    temp.Ma_user = ma_user;

                    string sqlcmd = "SELECT MAX(Ma_chu_ky) FROM dbo.CHU_KY";
                    int ma_chu_ky = Convert.ToInt32(connection.docGiaTri(sqlcmd)) + 1;
                    temp.Ma_chu_ky = ma_chu_ky;

                    temp.Ten_chu_ky = tbTen_mau.Text;

                    temp.Kieu_chu_ky1 = Kieu_chu_ky();

                    temp.Thoi_gian_cap1 = System.DateTime.Now;

                    temp.Thoi_gin_het_han1 = System.DateTime.Now.AddYears(1);

                    if(temp.Kieu_chu_ky1 == 3)
                    {
                        temp.Duong_dan_anh1 = "";
                    }    
                    else
                    {
                        temp.Duong_dan_anh1 = Path.GetFileName(fileName);
                    }    
                    

                    string fname = tbTen_mau.Text + ".jpg";
                    string folder = @"E:\Desktop\Thuc_tap_CNTT\Anh\" + ma_user + @"\Chu_ky" ;
                    string pathstring = Path.Combine(folder, fname);
                    temp.Duong_dan_chu_ky1 = fname;

                    //luu chu ky vao file
                    image_chu_ky.Save(pathstring);


                    bool add = CHU_KY_SQL.Them_Chu_ky(temp);
                    if(add == true)
                    {
                        MessageBox.Show("Thêm thành công");
                        InitCbBox();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi hệ thống");
                    }
                }
                else
                {
                    MessageBox.Show("Ban phai dien day du cac truong");
                }
            }
            else //chinh sua
            {
                int ma_chu_ky = Convert.ToInt32(cbBoxTen_chu_ky.SelectedValue.ToString());
                bool update = CHU_KY_SQL.Sua_Chu_ky(ma_chu_ky, tbTen_mau.Text);
                if(update == true)
                {
                    MessageBox.Show("Sửa thành công");
                    InitCbBox();
                }
                else
                {
                    MessageBox.Show("Không được phép sửa");
                }
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

            //enable
            radioButton_enable(true);

            //xoa panel
            panel2.Controls.Clear();

            //xoa filename
            fileName = "";


            //xoa checked
            radioBt_anh_va_thong_tin.Checked = false;
            radioBt_anh.Checked = false;
            radioBt_thong_tin.Checked = false;

            //button xoa
            btnXoa.Visible = false;


        }

        private void cbBoxTen_chu_ky_SelectedValueChanged(object sender, EventArgs e)
        {
            //hien thi ten chu ky
            lb_Ten_mau.Visible = true;
            tbTen_mau.Visible = true;
            tbTen_mau.Text = cbBoxTen_chu_ky.Text;

            //chuyen status
            status = 0;

            //btn xoa
            btnXoa.Visible = true;

            //an nut load anh
            btnLoadAnh.Visible = false;

            //ma_chu_ky
            int ma_chu_ky = Convert.ToInt32(cbBoxTen_chu_ky.SelectedValue.ToString());

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

        /// <summary>
        /// kiểm tra xem tick vào ô nào để suy ra kiểu chữ ký
        /// </summary>
        /// <param name="kieu_chu_ky"></param>
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

        Bitmap image_chu_ky = new Bitmap(312,212);
        bool isFull = false;
        string mac_dinh = @"E:\Code\Github\CHU_KY_SO\WindowsFormsApp1\WindowsFormsApp1\Resources\hoc-vien-ki-thuat-quan-su-he-quan-su.jpg";
        string fileName = "";

        private void radioBt_anh_va_thong_tin_CheckedChanged(object sender, EventArgs e)
        {
            if(status==2)
            {
                panel2.Controls.Clear();
                if(fileName == "")
                {
                    fileName = mac_dinh;
                }    
                
                //hien nut load anh
                btnLoadAnh.Visible = true;

                //đổi isFull thành false
                isFull = false;

                //hien thi mac dinh
                string txt = CHU_KY_SQL.Thong_tin(ma_user);
                Bitmap image_thong_tin = Images.Convert(txt, panel2.Width, panel2.Height);
                Bitmap image_anh = new Bitmap(fileName);


                Set_Two_Image(image_anh, image_thong_tin);


            }    
           
            
        }

        private void radioBt_anh_CheckedChanged(object sender, EventArgs e)
        {
            if(status==2)
            {
                panel2.Controls.Clear();
                if (fileName == "")
                {
                    fileName = mac_dinh;
                }

                //hien nut load anh
                btnLoadAnh.Visible = true;

                //đổi isfull thành true
                isFull = true;

                //hien thi mac dinh
                Bitmap image_anh = new Bitmap(fileName);

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



        private void btnLoadAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files | *.jpg; *.jpeg; *.png;";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                fileName = dlg.FileName;
                Bitmap a = new Bitmap(fileName);
                //load ảnh vào
                if (isFull == true)
                {
                    Set_Full_Image(a);
                }    
                else if(isFull==false)
                {
                    string txt = CHU_KY_SQL.Thong_tin(ma_user);
                    Bitmap b = Images.Convert(txt, panel2.Width, panel2.Height);
                    Set_Two_Image(a, b);
                }    
            }    
        }

        public void Set_Full_Image(Bitmap image)
        {
            panel2.Controls.Clear();
            PictureEdit a = new PictureEdit
            {
                Dock = DockStyle.Fill,
                Image = image,

            };
            a.Properties.SizeMode = PictureSizeMode.Stretch;

            panel2.Controls.Add(a);

            image_chu_ky = image;
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

            image_chu_ky = Images.Combine(a.Image, b.Image);
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int ma_chu_ky = Convert.ToInt32(cbBoxTen_chu_ky.SelectedValue.ToString());
            bool xoa = CHU_KY_SQL.Xoa_Chu_ky(ma_chu_ky);
            if(xoa==true)
            {
                MessageBox.Show("Xoa thanh cong");
                InitCbBox();
            }
            else
            {
                MessageBox.Show("Không được phép xoá");
            }
        }
    }
}