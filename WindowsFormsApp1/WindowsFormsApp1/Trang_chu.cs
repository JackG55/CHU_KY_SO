using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using WindowsFormsApp1.Van_ban;
using WindowsFormsApp1.Chu_ky_so;

namespace WindowsFormsApp1
{
    public partial class Trang_chu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Trang_chu()
        {
            InitializeComponent();
        }

        private void bt_gui_ItemClick(object sender, ItemClickEventArgs e)
        {
            // hien panel Gui van ban
             Gui_VB m = new Gui_VB();
             m.TopLevel = false;

            //xoa cac control hien thoi
            panel_main.Controls.Clear();

            panel_main.Controls.Add(m);
            m.Dock = DockStyle.Fill;
            m.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            m.Show();
        }

        private void bt_tao_chu_ky_so_ItemClick(object sender, ItemClickEventArgs e)
        {
            Chu_ky m = new Chu_ky();
            m.ShowDialog();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}