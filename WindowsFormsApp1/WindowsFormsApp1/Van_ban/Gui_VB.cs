﻿using System;
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
using DevExpress.Pdf.Drawing;
using DevExpress.Pdf.Drawing.Extensions;
using System.Net;

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
        string fileName = null;

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
            if(startPosition != null && endPosition !=null)
            {
                PointF startPoint = pdfViewer1.GetClientPoint(startPosition);
                PointF endPoint = pdfViewer1.GetClientPoint(endPosition);

                //MessageBox.Show("điểm bắt đầu X: " + startPoint.X + "Y: " + startPoint.Y + "\nđiểm kết thúc X: " + endPoint.X + " Y: " + endPoint.Y);

                //goi event load ra chu ky
                Chon_chu_ky m = new Chon_chu_ky();
                m.ShowDialog();
            }


           

        }

        void pdfViewer1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            

            if (startPosition != null && endPosition != null)
            {
                PointF startPoint = pdfViewer1.GetClientPoint(startPosition);
                PointF endPoint = pdfViewer1.GetClientPoint(endPosition);

                using (Pen redpen = new Pen(Color.Red))
                {
                    g.DrawRectangle(redpen,
                    RectangleF.FromLTRB(Math.Min(startPoint.X, endPoint.X), Math.Min(startPoint.Y, endPoint.Y),
                    Math.Max(startPoint.X, endPoint.X), Math.Max(startPoint.Y, endPoint.Y)));
                }

            }


        }
        async void LoadPDFFile(string pdf_url)
        {
            using (WebClient client = new WebClient())
            {
                var data = await client.DownloadDataTaskAsync(new Uri(pdf_url));
                pdfViewer1.DetachStreamAfterLoadComplete = true;
                using (MemoryStream ms = new MemoryStream(data))
                {
                    pdfViewer1.LoadDocument(ms);
                    fileName = pdf_url;
                }
            }
        }


        public void DrawImage(DevExpress.Pdf.PdfPage page, Bitmap image)
        {
            using (PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor())
            {
                documentProcessor.LoadDocument(fileName);
               
                using (PdfGraphics graphics = documentProcessor.CreateGraphics())
                {
                    
                    float width = (float)Math.Abs(startPosition.Point.X - endPosition.Point.X);
                    float height = (float)Math.Abs(startPosition.Point.Y - endPosition.Point.Y);

                    PdfRectangle cropbox = page.CropBox;
                    MessageBox.Show(cropbox.Height.ToString());
                    float Y = (float)(cropbox.Height - startPosition.Point.Y);

                    RectangleF rec = new RectangleF((float)startPosition.Point.X, Y, width, height);
                    //  RectangleF test = new RectangleF(10, 30, width, height);

                    graphics.DrawImage(image, rec);
                    graphics.AddToPageForeground(page, 72, 72);
                }


                documentProcessor.SaveDocument(@"E:\Desktop\Thuc_tap_CNTT\result.pdf");
                //LoadPDFFile(resultFileName);
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void bt_chon_file_Click(object sender, EventArgs e)
        {

            //fileName = null;
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
            
        }

        private void bt_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}