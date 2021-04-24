//using Syncfusion.Pdf.Parsing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.SignD;

namespace WindowsFormsApp1
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var path = "../../Data/Baitap.pdf";
            byte[] file;
            FileStream fs = File.Open(path, FileMode.Open);
            file = new byte[fs.Length];
            UTF8Encoding temp = new UTF8Encoding(true);

            while (fs.Read(file, 0, file.Length) > 0) ;
            X509Certificate2 cert = classX509Cert.GetCertificateFromStore("testDigitalSignature");
            if(cert == null)
            {
                MessageBox.Show("Non-Certificate");
                return;
            }
            byte[] sfile = classX509Cert.Sign(file, cert);
            Stream streamPdfFile = new MemoryStream(sfile);
            pdfViewer2.LoadDocument(streamPdfFile);
        }
    }
}
