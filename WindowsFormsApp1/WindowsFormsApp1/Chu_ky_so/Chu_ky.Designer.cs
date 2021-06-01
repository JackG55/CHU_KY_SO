namespace WindowsFormsApp1.Chu_ky_so
{
    partial class Chu_ky
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTao_moi = new System.Windows.Forms.Button();
            this.cbBoxTen_chu_ky = new System.Windows.Forms.ComboBox();
            this.lbQuan_ly_mau_chu_ky = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBt_thong_tin = new System.Windows.Forms.RadioButton();
            this.radioBt_anh = new System.Windows.Forms.RadioButton();
            this.radioBt_anh_va_thong_tin = new System.Windows.Forms.RadioButton();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbTen_mau = new DevExpress.XtraEditors.TextEdit();
            this.lb_Ten_mau = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_luu = new System.Windows.Forms.Button();
            this.bt_huy = new System.Windows.Forms.Button();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTen_mau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTao_moi);
            this.panel1.Controls.Add(this.cbBoxTen_chu_ky);
            this.panel1.Controls.Add(this.lbQuan_ly_mau_chu_ky);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.tbTen_mau);
            this.panel1.Controls.Add(this.lb_Ten_mau);
            this.panel1.Location = new System.Drawing.Point(37, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 554);
            this.panel1.TabIndex = 0;
            // 
            // btnTao_moi
            // 
            this.btnTao_moi.Location = new System.Drawing.Point(557, 27);
            this.btnTao_moi.Name = "btnTao_moi";
            this.btnTao_moi.Size = new System.Drawing.Size(75, 23);
            this.btnTao_moi.TabIndex = 7;
            this.btnTao_moi.Text = "Tạo mới";
            this.btnTao_moi.UseVisualStyleBackColor = true;
            this.btnTao_moi.Click += new System.EventHandler(this.btnTao_moi_Click);
            // 
            // cbBoxTen_chu_ky
            // 
            this.cbBoxTen_chu_ky.FormattingEnabled = true;
            this.cbBoxTen_chu_ky.Location = new System.Drawing.Point(170, 26);
            this.cbBoxTen_chu_ky.Name = "cbBoxTen_chu_ky";
            this.cbBoxTen_chu_ky.Size = new System.Drawing.Size(336, 24);
            this.cbBoxTen_chu_ky.TabIndex = 6;
            this.cbBoxTen_chu_ky.SelectedValueChanged += new System.EventHandler(this.cbBoxTen_chu_ky_SelectedValueChanged);
            // 
            // lbQuan_ly_mau_chu_ky
            // 
            this.lbQuan_ly_mau_chu_ky.Location = new System.Drawing.Point(13, 29);
            this.lbQuan_ly_mau_chu_ky.Name = "lbQuan_ly_mau_chu_ky";
            this.lbQuan_ly_mau_chu_ky.Size = new System.Drawing.Size(151, 25);
            this.lbQuan_ly_mau_chu_ky.TabIndex = 5;
            this.lbQuan_ly_mau_chu_ky.Text = "Quản lý mẫu chữ ký: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBt_thong_tin);
            this.groupBox1.Controls.Add(this.radioBt_anh);
            this.groupBox1.Controls.Add(this.radioBt_anh_va_thong_tin);
            this.groupBox1.Controls.Add(this.radioGroup1);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Location = new System.Drawing.Point(16, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(874, 286);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hiển thị chữ ký";
            // 
            // radioBt_thong_tin
            // 
            this.radioBt_thong_tin.AutoSize = true;
            this.radioBt_thong_tin.Location = new System.Drawing.Point(46, 141);
            this.radioBt_thong_tin.Name = "radioBt_thong_tin";
            this.radioBt_thong_tin.Size = new System.Drawing.Size(88, 21);
            this.radioBt_thong_tin.TabIndex = 4;
            this.radioBt_thong_tin.TabStop = true;
            this.radioBt_thong_tin.Text = "Thông tin";
            this.radioBt_thong_tin.UseVisualStyleBackColor = true;
            // 
            // radioBt_anh
            // 
            this.radioBt_anh.AutoSize = true;
            this.radioBt_anh.Location = new System.Drawing.Point(46, 93);
            this.radioBt_anh.Name = "radioBt_anh";
            this.radioBt_anh.Size = new System.Drawing.Size(83, 21);
            this.radioBt_anh.TabIndex = 3;
            this.radioBt_anh.TabStop = true;
            this.radioBt_anh.Text = "Hình ảnh";
            this.radioBt_anh.UseVisualStyleBackColor = true;
            // 
            // radioBt_anh_va_thong_tin
            // 
            this.radioBt_anh_va_thong_tin.AutoSize = true;
            this.radioBt_anh_va_thong_tin.Location = new System.Drawing.Point(46, 51);
            this.radioBt_anh_va_thong_tin.Name = "radioBt_anh_va_thong_tin";
            this.radioBt_anh_va_thong_tin.Size = new System.Drawing.Size(162, 21);
            this.radioBt_anh_va_thong_tin.TabIndex = 2;
            this.radioBt_anh_va_thong_tin.TabStop = true;
            this.radioBt_anh_va_thong_tin.Text = "Hình ảnh và thông tin";
            this.radioBt_anh_va_thong_tin.UseVisualStyleBackColor = true;
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(19, 35);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroup1.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroup1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroup1.Properties.Columns = 3;
            this.radioGroup1.Size = new System.Drawing.Size(488, 150);
            this.radioGroup1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureEdit1);
            this.panel2.Location = new System.Drawing.Point(541, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 214);
            this.panel2.TabIndex = 0;
            // 
            // tbTen_mau
            // 
            this.tbTen_mau.Location = new System.Drawing.Point(156, 117);
            this.tbTen_mau.Name = "tbTen_mau";
            this.tbTen_mau.Size = new System.Drawing.Size(350, 22);
            this.tbTen_mau.TabIndex = 3;
            // 
            // lb_Ten_mau
            // 
            this.lb_Ten_mau.Location = new System.Drawing.Point(13, 120);
            this.lb_Ten_mau.Name = "lb_Ten_mau";
            this.lb_Ten_mau.Size = new System.Drawing.Size(122, 25);
            this.lb_Ten_mau.TabIndex = 2;
            this.lb_Ten_mau.Text = "Tên mẫu chữ ký:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ MẪU CHỮ KÝ";
            // 
            // bt_luu
            // 
            this.bt_luu.Location = new System.Drawing.Point(694, 647);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(86, 29);
            this.bt_luu.TabIndex = 2;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // bt_huy
            // 
            this.bt_huy.Location = new System.Drawing.Point(863, 650);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(86, 29);
            this.bt_huy.TabIndex = 3;
            this.bt_huy.Text = "Huỷ";
            this.bt_huy.UseVisualStyleBackColor = true;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureEdit1.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(153, 212);
            this.pictureEdit1.TabIndex = 0;
            // 
            // Chu_ky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 700);
            this.Controls.Add(this.bt_huy);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Chu_ky";
            this.Text = "Chu_ky";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbTen_mau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit tbTen_mau;
        private System.Windows.Forms.Label lb_Ten_mau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioBt_thong_tin;
        private System.Windows.Forms.RadioButton radioBt_anh;
        private System.Windows.Forms.RadioButton radioBt_anh_va_thong_tin;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.Button bt_huy;
        private System.Windows.Forms.Label lbQuan_ly_mau_chu_ky;
        private System.Windows.Forms.ComboBox cbBoxTen_chu_ky;
        private System.Windows.Forms.Button btnTao_moi;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}