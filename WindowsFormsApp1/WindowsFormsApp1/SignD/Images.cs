using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.SignD
{
    public class Images
    {
        public static Bitmap Combine(Image i1, Image i2)
        {
            Bitmap bitmap = new Bitmap(i1.Width + i2.Width, Math.Max(i1.Height, i2.Height));
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.DrawImage(i1, 0, 0);
                g.DrawImage(i2, i2.Width, 0);
            }
            return bitmap;
        }
        public static Bitmap Convert(string obj,int width,int height)
        {
            string txt = obj;
            Bitmap bmp = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(bmp))
            {
                
                Font font = new Font("Bookman Old Style", 10);
                graphics.FillRectangle(new SolidBrush(Color.WhiteSmoke), 0, 0, bmp.Width, bmp.Height);
                graphics.DrawString(txt, font, new SolidBrush(Color.Black), 10, 20);
                graphics.Flush();
                font.Dispose();
                graphics.Dispose();
            }
            return bmp;
        }
    }
}
