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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.radioBt_anh_va_thong_tin = new System.Windows.Forms.RadioButton();
            this.radioBt_anh = new System.Windows.Forms.RadioButton();
            this.radioBt_thong_tin = new System.Windows.Forms.RadioButton();
            this.bt_luu = new System.Windows.Forms.Button();
            this.bt_huy = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.textEdit1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(37, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 554);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ MẪU CHỮ KÝ";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên mẫu chữ ký:";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(158, 28);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(350, 22);
            this.textEdit1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBt_thong_tin);
            this.groupBox1.Controls.Add(this.radioBt_anh);
            this.groupBox1.Controls.Add(this.radioBt_anh_va_thong_tin);
            this.groupBox1.Controls.Add(this.radioGroup1);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Location = new System.Drawing.Point(16, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(874, 286);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hiển thị chữ ký";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(541, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 214);
            this.panel2.TabIndex = 0;
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
            // bt_luu
            // 
            this.bt_luu.Location = new System.Drawing.Point(694, 647);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(86, 29);
            this.bt_luu.TabIndex = 2;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
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
            // Chu_ky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 700);
            this.Controls.Add(this.bt_huy);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Chu_ky";
            this.Text = "Chu_ky";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioBt_thong_tin;
        private System.Windows.Forms.RadioButton radioBt_anh;
        private System.Windows.Forms.RadioButton radioBt_anh_va_thong_tin;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.Button bt_huy;
    }
}