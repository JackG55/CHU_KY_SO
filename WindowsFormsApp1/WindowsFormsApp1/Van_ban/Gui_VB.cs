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
using System.IO;
using DevExpress.Pdf;
using WindowsFormsApp1.Chu_ky_so;
using iTextSharp.text.pdf;
using iTextSharp.text;


namespace WindowsFormsApp1.Van_ban
{
    public partial class Gui_VB : DevExpress.XtraEditors.XtraForm
    {
        public Gui_VB()
        {
            InitializeComponent();
            
        }

        bool mouseButtonPressed = false;
        PdfDocumentPosition startPosition;
        PdfDocumentPosition endPosition;

        void pdfViewer1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startPosition = pdfViewer1.GetDocumentPosition(e.Location);
                endPosition = null;
                mouseButtonPressed = true;
                pdfViewer1.Invalidate();
            }
        }

        void pdfViewer1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseButtonPressed)
            {
                endPosition = pdfViewer1.GetDocumentPosition(e.Location);
                pdfViewer1.Invalidate();
            }
        }

        void pdfViewer1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseButtonPressed = false;

            //goi event load ra chu ky
            Chon_chu_ky m = new Chon_chu_ky();
            m.ShowDialog();

        }

        void pdfViewer1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            

            if (startPosition != null && endPosition != null)
            {
                PointF startPoint = pdfViewer1.GetClientPoint(startPosition);
                PointF endPoint = pdfViewer1.GetClientPoint(endPosition);

                using (SolidBrush blueBrush = new SolidBrush(Color.FromArgb(128, Color.Aqua)))
                {
                    g.FillRectangle(blueBrush,
                    RectangleF.FromLTRB(Math.Min(startPoint.X, endPoint.X), Math.Min(startPoint.Y, endPoint.Y),
                    Math.Max(startPoint.X, endPoint.X), Math.Max(startPoint.Y, endPoint.Y)));
                }
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void bt_chon_file_Click(object sender, EventArgs e)
        {

            string fileName = null;
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                

                fileName = dlg.FileName;
            }

            //load file 
            if(fileName != null)
            {
                //load pdf
                pdfViewer1.LoadDocument(fileName);
                pdfViewer1.MouseDown += pdfViewer1_MouseDown;
                pdfViewer1.MouseMove += pdfViewer1_MouseMove;
                pdfViewer1.MouseUp += pdfViewer1_MouseUp;
                pdfViewer1.Paint += pdfViewer1_Paint;

                //hien thanh ribbon
                ribbon_pdf.Visible = true;

                //hien ten file dinh kem
                tb_dinh_kem.Visible = true;
                tb_dinh_kem.Text = fileName;
            }




        }



        //ký mặc định -> lấy dữ liệu từ chữ ký 
        private void bt_ky_so_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Stream inputPdfStream = new FileStream(@"E:\Desktop\Assembly language for x86 processors  Kip R. Irvine. 6th ed.pdf", FileMode.Open, FileAccess.Read, FileShare.Read))
            using (Stream inputImageStream = new FileStream(@"E:\Code\Github\CHU_KY_SO\WindowsFormsApp1\WindowsFormsApp1\Resources\hoc-vien-ki-thuat-quan-su-he-quan-su.jpg", FileMode.Open, FileAccess.Read, FileShare.Read))
            using (Stream outputPdfStream = new FileStream(@"E:\Desktop\Thuc_tap_CNTT\result.pdf", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                var reader = new PdfReader(inputPdfStream);
                var stamper = new PdfStamper(reader, outputPdfStream);
                var pdfContentByte = stamper.GetOverContent(1);

                iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(inputImageStream);
                image.SetAbsolutePosition(100, 100);
                pdfContentByte.AddImage(image);
                stamper.Close();
            }
        }
    }
}