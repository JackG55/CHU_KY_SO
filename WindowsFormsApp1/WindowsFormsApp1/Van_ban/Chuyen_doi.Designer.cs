namespace WindowsFormsApp1.Van_ban
{
    partial class Chuyen_doi
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnChon_end = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnChuyendoi = new DevExpress.XtraEditors.SimpleButton();
            this.txtFile_end = new System.Windows.Forms.TextBox();
            this.txtFile_start = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.splitContainer1.Panel1.Controls.Add(this.pictureEdit2);
            this.splitContainer1.Panel1.Controls.Add(this.pictureEdit1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.splitContainer1.Panel2.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel2.Controls.Add(this.labelControl1);
            this.splitContainer1.Panel2.Controls.Add(this.btnChon_end);
            this.splitContainer1.Panel2.Controls.Add(this.simpleButton2);
            this.splitContainer1.Panel2.Controls.Add(this.btnChuyendoi);
            this.splitContainer1.Panel2.Controls.Add(this.txtFile_end);
            this.splitContainer1.Panel2.Controls.Add(this.txtFile_start);
            this.splitContainer1.Size = new System.Drawing.Size(889, 431);
            this.splitContainer1.SplitterDistance = 130;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureEdit2.EditValue = global::WindowsFormsApp1.Properties.Resources.tải_xuống;
            this.pictureEdit2.Location = new System.Drawing.Point(716, 0);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(173, 130);
            this.pictureEdit2.TabIndex = 1;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureEdit1.EditValue = global::WindowsFormsApp1.Properties.Resources._1_wvkn;
            this.pictureEdit1.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.StretchHorizontal;
            this.pictureEdit1.Size = new System.Drawing.Size(460, 130);
            this.pictureEdit1.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(29, 131);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(160, 17);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Nơi lưu sau khi chuyển đổi";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(29, 55);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(168, 17);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Đường dẫn cần chuyển đổi";
            // 
            // btnChon_end
            // 
            this.btnChon_end.Location = new System.Drawing.Point(625, 154);
            this.btnChon_end.Name = "btnChon_end";
            this.btnChon_end.Size = new System.Drawing.Size(101, 23);
            this.btnChon_end.TabIndex = 4;
            this.btnChon_end.Text = "Chọn";
            this.btnChon_end.Click += new System.EventHandler(this.btnChon_end_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(645, 220);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(115, 48);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "Đóng";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnChuyendoi
            // 
            this.btnChuyendoi.Location = new System.Drawing.Point(415, 220);
            this.btnChuyendoi.Name = "btnChuyendoi";
            this.btnChuyendoi.Size = new System.Drawing.Size(115, 48);
            this.btnChuyendoi.TabIndex = 2;
            this.btnChuyendoi.Text = "Chuyển đổi";
            this.btnChuyendoi.Click += new System.EventHandler(this.btnChuyendoi_Click);
            // 
            // txtFile_end
            // 
            this.txtFile_end.Location = new System.Drawing.Point(29, 154);
            this.txtFile_end.Name = "txtFile_end";
            this.txtFile_end.Size = new System.Drawing.Size(554, 23);
            this.txtFile_end.TabIndex = 1;
            // 
            // txtFile_start
            // 
            this.txtFile_start.Location = new System.Drawing.Point(29, 78);
            this.txtFile_start.Name = "txtFile_start";
            this.txtFile_start.ReadOnly = true;
            this.txtFile_start.Size = new System.Drawing.Size(554, 23);
            this.txtFile_start.TabIndex = 0;
            // 
            // Chuyen_doi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 431);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Chuyen_doi";
            this.Text = "Chuyen_doi";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnChon_end;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnChuyendoi;
        private System.Windows.Forms.TextBox txtFile_end;
        private System.Windows.Forms.TextBox txtFile_start;
    }
}