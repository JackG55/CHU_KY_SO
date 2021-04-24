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
using WindowsFormsApp1.SignD;
using DevExpress.XtraEditors.Controls;

namespace WindowsFormsApp1.Chu_ky_so
{
    public partial class Chu_ky : DevExpress.XtraEditors.XtraForm
    {
        public Chu_ky()
        {
            InitializeComponent();
        }

        private PictureEdit pic_thong_tin = new PictureEdit();
        private PictureEdit pic_chu_ky = new PictureEdit();

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }


        //pic chu ky (height = 212 , width = 169)
        //pic thong tin (height = 212, width = 154)

        public Bitmap ResizeBitmap(Bitmap bmp, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(bmp, 0, 0, width, height);
            }

            return result;
        }


        private void radioBt_anh_va_thong_tin_CheckedChanged(object sender, EventArgs e)
        {
            if(radioBt_anh_va_thong_tin.Checked == true)
            {
                pic_thong_tin.Height = 212;
                pic_thong_tin.Width = 152;
                pic_chu_ky.Width = 169;
                pic_chu_ky.Height = 212;

                //convert chu thanh anh
                //anh thong tin
                Bitmap anh_thong_tin;
                anh_thong_tin = Images.Convert("Đinh Viết Đức\njacksparrow551999@gmail.com\nQuan lý nhân sự", pic_thong_tin.Width, pic_thong_tin.Height);
                pic_thong_tin.Image = anh_thong_tin;
                pic_thong_tin.Properties.SizeMode = PictureSizeMode.Stretch;


                //anh chu ky
                Bitmap anh_chu_ky = new Bitmap(@"E:\Code\Github\CHU_KY_SO\WindowsFormsApp1\WindowsFormsApp1\Resources\hoc-vien-ki-thuat-quan-su-he-quan-su.jpg");
                Bitmap resized = ResizeBitmap(anh_chu_ky, pic_chu_ky.Width, pic_chu_ky.Height);
                pic_chu_ky.Image = (Image) resized;
                pic_chu_ky.Properties.SizeMode = PictureSizeMode.Stretch;

                //ghep 2 anh
                pic_tong_hop.Image = Images.Combine(pic_chu_ky.Image, pic_thong_tin.Image);
                pic_tong_hop.Properties.SizeMode = PictureSizeMode.Stretch;
              
                
            }    
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}