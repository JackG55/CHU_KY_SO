﻿namespace WindowsFormsApp1.Van_ban
{
    partial class Gui_VB
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ten = new DevExpress.XtraEditors.TextEdit();
            this.tb_tieu_de = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_dinh_kem = new DevExpress.XtraEditors.TextEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bt_gui = new System.Windows.Forms.Button();
            this.bt_luu = new System.Windows.Forms.Button();
            this.bt_ktra_ten = new System.Windows.Forms.Button();
            this.bt_dong = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_tieu_de.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_dinh_kem.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_dong);
            this.panel1.Controls.Add(this.bt_ktra_ten);
            this.panel1.Controls.Add(this.bt_luu);
            this.panel1.Controls.Add(this.bt_gui);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 78);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tb_dinh_kem);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tb_tieu_de);
            this.panel3.Controls.Add(this.tb_ten);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(993, 155);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tiêu đề";
            // 
            // tb_ten
            // 
            this.tb_ten.Location = new System.Drawing.Point(103, 16);
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Size = new System.Drawing.Size(764, 22);
            this.tb_ten.TabIndex = 2;
            // 
            // tb_tieu_de
            // 
            this.tb_tieu_de.Location = new System.Drawing.Point(103, 67);
            this.tb_tieu_de.Name = "tb_tieu_de";
            this.tb_tieu_de.Size = new System.Drawing.Size(764, 22);
            this.tb_tieu_de.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đính kèm";
            // 
            // tb_dinh_kem
            // 
            this.tb_dinh_kem.Location = new System.Drawing.Point(103, 116);
            this.tb_dinh_kem.Name = "tb_dinh_kem";
            this.tb_dinh_kem.Size = new System.Drawing.Size(764, 22);
            this.tb_dinh_kem.TabIndex = 5;
            this.tb_dinh_kem.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(993, 622);
            this.panel2.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.richTextBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 155);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(993, 467);
            this.panel4.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(993, 467);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // bt_gui
            // 
            this.bt_gui.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_gui.Location = new System.Drawing.Point(0, 0);
            this.bt_gui.Name = "bt_gui";
            this.bt_gui.Size = new System.Drawing.Size(105, 78);
            this.bt_gui.TabIndex = 0;
            this.bt_gui.Text = "GỬI";
            this.bt_gui.UseVisualStyleBackColor = true;
            // 
            // bt_luu
            // 
            this.bt_luu.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_luu.Location = new System.Drawing.Point(105, 0);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(105, 78);
            this.bt_luu.TabIndex = 1;
            this.bt_luu.Text = "LƯU";
            this.bt_luu.UseVisualStyleBackColor = true;
            // 
            // bt_ktra_ten
            // 
            this.bt_ktra_ten.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_ktra_ten.Location = new System.Drawing.Point(210, 0);
            this.bt_ktra_ten.Name = "bt_ktra_ten";
            this.bt_ktra_ten.Size = new System.Drawing.Size(105, 78);
            this.bt_ktra_ten.TabIndex = 2;
            this.bt_ktra_ten.Text = "KIỂM TRA TÊN";
            this.bt_ktra_ten.UseVisualStyleBackColor = true;
            // 
            // bt_dong
            // 
            this.bt_dong.Dock = System.Windows.Forms.DockStyle.Right;
            this.bt_dong.Location = new System.Drawing.Point(888, 0);
            this.bt_dong.Name = "bt_dong";
            this.bt_dong.Size = new System.Drawing.Size(105, 78);
            this.bt_dong.TabIndex = 3;
            this.bt_dong.Text = "ĐÓNG";
            this.bt_dong.UseVisualStyleBackColor = true;
            // 
            // Gui_VB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Gui_VB";
            this.Text = "Gui_VB";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_tieu_de.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_dinh_kem.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.TextEdit tb_dinh_kem;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit tb_tieu_de;
        private DevExpress.XtraEditors.TextEdit tb_ten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button bt_dong;
        private System.Windows.Forms.Button bt_ktra_ten;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.Button bt_gui;
    }
}