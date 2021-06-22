namespace WindowsFormsApp1.Chu_ky_so
{
    partial class Chon_chu_ky
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbBoxChu_ky = new System.Windows.Forms.ComboBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.piceditChu_ky = new DevExpress.XtraEditors.PictureEdit();
            this.lb_status = new System.Windows.Forms.Label();
            this.lb_thoi_gian = new System.Windows.Forms.Label();
            this.lb_noi_cap = new System.Windows.Forms.Label();
            this.lb_ten_chu_so_huu = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.bt_ky = new System.Windows.Forms.Button();
            this.bt_dong = new System.Windows.Forms.Button();
            this.txtNoi_luu = new DevExpress.XtraEditors.TextEdit();
            this.btn_chon_duong_dan = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piceditChu_ky.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoi_luu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 91);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "KÝ SỐ";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_chon_duong_dan);
            this.groupControl1.Controls.Add(this.txtNoi_luu);
            this.groupControl1.Controls.Add(this.cbBoxChu_ky);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Controls.Add(this.pictureEdit1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 91);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1126, 492);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Chọn chữ ký";
            // 
            // cbBoxChu_ky
            // 
            this.cbBoxChu_ky.FormattingEnabled = true;
            this.cbBoxChu_ky.Location = new System.Drawing.Point(91, 40);
            this.cbBoxChu_ky.Name = "cbBoxChu_ky";
            this.cbBoxChu_ky.Size = new System.Drawing.Size(837, 24);
            this.cbBoxChu_ky.TabIndex = 3;
            this.cbBoxChu_ky.SelectedValueChanged += new System.EventHandler(this.cbBoxChu_ky_SelectedValueChanged);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.panel2);
            this.groupControl2.Controls.Add(this.lb_status);
            this.groupControl2.Controls.Add(this.lb_thoi_gian);
            this.groupControl2.Controls.Add(this.lb_noi_cap);
            this.groupControl2.Controls.Add(this.lb_ten_chu_so_huu);
            this.groupControl2.Controls.Add(this.label5);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Location = new System.Drawing.Point(12, 87);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1045, 286);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Thông tin chứng thư số";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.piceditChu_ky);
            this.panel2.Location = new System.Drawing.Point(692, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 214);
            this.panel2.TabIndex = 8;
            // 
            // piceditChu_ky
            // 
            this.piceditChu_ky.Dock = System.Windows.Forms.DockStyle.Fill;
            this.piceditChu_ky.Location = new System.Drawing.Point(0, 0);
            this.piceditChu_ky.Name = "piceditChu_ky";
            this.piceditChu_ky.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.piceditChu_ky.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.piceditChu_ky.Size = new System.Drawing.Size(314, 214);
            this.piceditChu_ky.TabIndex = 0;
            // 
            // lb_status
            // 
            this.lb_status.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_status.Location = new System.Drawing.Point(158, 226);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(393, 26);
            this.lb_status.TabIndex = 7;
            this.lb_status.Text = "Thông tin chứng thư số hợp lệ";
            // 
            // lb_thoi_gian
            // 
            this.lb_thoi_gian.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thoi_gian.Location = new System.Drawing.Point(159, 158);
            this.lb_thoi_gian.Name = "lb_thoi_gian";
            this.lb_thoi_gian.Size = new System.Drawing.Size(394, 26);
            this.lb_thoi_gian.TabIndex = 6;
            this.lb_thoi_gian.Text = "15/8/2020 đến 15/9/2021";
            // 
            // lb_noi_cap
            // 
            this.lb_noi_cap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_noi_cap.Location = new System.Drawing.Point(209, 85);
            this.lb_noi_cap.Name = "lb_noi_cap";
            this.lb_noi_cap.Size = new System.Drawing.Size(343, 26);
            this.lb_noi_cap.TabIndex = 5;
            this.lb_noi_cap.Text = "Phòng hậu cần";
            // 
            // lb_ten_chu_so_huu
            // 
            this.lb_ten_chu_so_huu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ten_chu_so_huu.Location = new System.Drawing.Point(159, 38);
            this.lb_ten_chu_so_huu.Name = "lb_ten_chu_so_huu";
            this.lb_ten_chu_so_huu.Size = new System.Drawing.Size(392, 26);
            this.lb_ten_chu_so_huu.TabIndex = 4;
            this.lb_ten_chu_so_huu.Text = "Phạm Công Thảo ";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tình trạng :";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Thời hạn :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cơ quan cấp phát :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chủ sở hữu :";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(982, 35);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(36, 29);
            this.pictureEdit1.TabIndex = 1;
            // 
            // bt_ky
            // 
            this.bt_ky.Location = new System.Drawing.Point(91, 611);
            this.bt_ky.Name = "bt_ky";
            this.bt_ky.Size = new System.Drawing.Size(124, 55);
            this.bt_ky.TabIndex = 2;
            this.bt_ky.Text = "Ký số";
            this.bt_ky.UseVisualStyleBackColor = true;
            this.bt_ky.Click += new System.EventHandler(this.bt_ky_Click);
            // 
            // bt_dong
            // 
            this.bt_dong.Location = new System.Drawing.Point(819, 611);
            this.bt_dong.Name = "bt_dong";
            this.bt_dong.Size = new System.Drawing.Size(124, 55);
            this.bt_dong.TabIndex = 3;
            this.bt_dong.Text = "Đóng";
            this.bt_dong.UseVisualStyleBackColor = true;
            this.bt_dong.Click += new System.EventHandler(this.bt_dong_Click);
            // 
            // txtNoi_luu
            // 
            this.txtNoi_luu.Location = new System.Drawing.Point(91, 416);
            this.txtNoi_luu.Name = "txtNoi_luu";
            this.txtNoi_luu.Size = new System.Drawing.Size(837, 22);
            this.txtNoi_luu.TabIndex = 4;
            // 
            // btn_chon_duong_dan
            // 
            this.btn_chon_duong_dan.Location = new System.Drawing.Point(956, 415);
            this.btn_chon_duong_dan.Name = "btn_chon_duong_dan";
            this.btn_chon_duong_dan.Size = new System.Drawing.Size(75, 24);
            this.btn_chon_duong_dan.TabIndex = 4;
            this.btn_chon_duong_dan.Text = "...";
            this.btn_chon_duong_dan.UseVisualStyleBackColor = true;
            this.btn_chon_duong_dan.Click += new System.EventHandler(this.btn_chon_duong_dan_Click);
            // 
            // Chon_chu_ky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 704);
            this.Controls.Add(this.bt_dong);
            this.Controls.Add(this.bt_ky);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Chon_chu_ky";
            this.Text = "Chon_chu_ky";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.piceditChu_ky.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoi_luu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.Label lb_thoi_gian;
        private System.Windows.Forms.Label lb_noi_cap;
        private System.Windows.Forms.Label lb_ten_chu_so_huu;
        private System.Windows.Forms.Button bt_ky;
        private System.Windows.Forms.Button bt_dong;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.PictureEdit piceditChu_ky;
        private System.Windows.Forms.ComboBox cbBoxChu_ky;
        private System.Windows.Forms.Button btn_chon_duong_dan;
        private DevExpress.XtraEditors.TextEdit txtNoi_luu;
    }
}