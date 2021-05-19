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
        public Chuyen_doi(string filename)
        {
            InitializeComponent();
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
    }
}