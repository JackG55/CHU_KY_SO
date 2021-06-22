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

namespace WindowsFormsApp1.Van_ban
{
    public partial class Chuyen_doi : DevExpress.XtraEditors.XtraForm
    {


        public static string File_Moi = "";

        public Chuyen_doi(string filename)
        {
            InitializeComponent();
            File_Moi = "";

            FileInfo fileInfo = new FileInfo(filename);
            txtFile_start.Text = filename;
            var result = Path.ChangeExtension(filename, ".pdf");
            txtFile_end.Text = result.ToString();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChon_start_Click(object sender, EventArgs e)
        {
          
        }

        private void btnChon_end_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Pdf files|*.pdf*";
            if(save.ShowDialog() == DialogResult.OK)
            {
                txtFile_end.Text = save.FileName + ".pdf";

            }    
        }

        private void btnChuyendoi_Click(object sender, EventArgs e)
        {
            //check xem file đưa vào là gì?
            var filename = txtFile_start.Text;
            if (Path.GetExtension(filename) == ".docx")
            {
                var wordApp = new Microsoft.Office.Interop.Word.Application();
                var wordDocument = wordApp.Documents.Open(filename);
                wordDocument.ExportAsFixedFormat(txtFile_end.Text, Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF);

                wordDocument.Close(Microsoft.Office.Interop.Word.WdSaveOptions.wdDoNotSaveChanges, Microsoft.Office.Interop.Word.WdOriginalFormat.wdOriginalDocumentFormat, false);
                wordApp.Quit();

                File_Moi = txtFile_end.Text;

                this.Close();
                
            }   
            else if(Path.GetExtension(filename) == ".xlsx")
            {
                var excelApp = new Microsoft.Office.Interop.Excel.Application();
                var excelDocument = excelApp.Workbooks.Open(filename);
                excelDocument.ExportAsFixedFormat(Microsoft.Office.Interop.Excel.XlFixedFormatType.xlTypePDF, txtFile_end.Text);
                excelDocument.Close(false, "", false);
                excelApp.Quit();
            }   
            else if(Path.GetExtension(filename) == ".pptx")
            {
                var powerpointApp = new Microsoft.Office.Interop.PowerPoint.Application();
                var powerpointDocument = powerpointApp.Presentations.Open(filename,
                 Microsoft.Office.Core.MsoTriState.msoTrue, //ReadOnly
                 Microsoft.Office.Core.MsoTriState.msoFalse, //Untitled
                 Microsoft.Office.Core.MsoTriState.msoFalse); //Window not visible during converting
                powerpointDocument.ExportAsFixedFormat(txtFile_end.Text,
                Microsoft.Office.Interop.PowerPoint.PpFixedFormatType.ppFixedFormatTypePDF);

                powerpointDocument.Close(); //Close document
                powerpointApp.Quit(); //Important: When you forget this PowerPoint keeps running in the background
            }    
        }
    }
}