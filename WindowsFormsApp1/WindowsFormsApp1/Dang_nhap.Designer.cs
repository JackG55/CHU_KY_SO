namespace WindowsFormsApp1
{
    partial class Dang_nhap
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.bt_dang_nhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(571, 75);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "simpleButton1";
            // 
            // bt_dang_nhap
            // 
            this.bt_dang_nhap.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dang_nhap.ForeColor = System.Drawing.Color.Black;
            this.bt_dang_nhap.Location = new System.Drawing.Point(294, 184);
            this.bt_dang_nhap.Name = "bt_dang_nhap";
            this.bt_dang_nhap.Size = new System.Drawing.Size(108, 54);
            this.bt_dang_nhap.TabIndex = 1;
            this.bt_dang_nhap.Text = "Đăng nhập";
            this.bt_dang_nhap.UseVisualStyleBackColor = true;
            // 
            // Dang_nhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 443);
            this.Controls.Add(this.bt_dang_nhap);
            this.Controls.Add(this.simpleButton1);
            this.Name = "Dang_nhap";
            this.Text = "Dang_nhap";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Button bt_dang_nhap;
    }
}