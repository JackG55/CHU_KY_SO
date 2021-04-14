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

namespace WindowsFormsApp1.Chu_ky_so
{
    public partial class Kiem_tra_chu_ky : DevExpress.XtraEditors.XtraForm
    {
        public Kiem_tra_chu_ky()
        {
            InitializeComponent();
        }

        private void bt_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}