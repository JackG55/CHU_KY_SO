namespace WindowsFormsApp1
{
    partial class Test
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
            this.connectbtn = new System.Windows.Forms.Button();
            this.hosttbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.porttbx = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.openfilebtn = new System.Windows.Forms.Button();
            this.filename = new System.Windows.Forms.TextBox();
            this.sendbtn = new System.Windows.Forms.Button();
            this.targetUserName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // connectbtn
            // 
            this.connectbtn.Location = new System.Drawing.Point(714, 32);
            this.connectbtn.Name = "connectbtn";
            this.connectbtn.Size = new System.Drawing.Size(80, 36);
            this.connectbtn.TabIndex = 2;
            this.connectbtn.Text = "Connect";
            this.connectbtn.UseVisualStyleBackColor = true;
            this.connectbtn.Click += new System.EventHandler(this.connectbtn_Click);
            // 
            // hosttbx
            // 
            this.hosttbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hosttbx.Location = new System.Drawing.Point(77, 12);
            this.hosttbx.Name = "hosttbx";
            this.hosttbx.Size = new System.Drawing.Size(208, 30);
            this.hosttbx.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "host";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(293, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "port";
            // 
            // porttbx
            // 
            this.porttbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.porttbx.Location = new System.Drawing.Point(363, 12);
            this.porttbx.Name = "porttbx";
            this.porttbx.Size = new System.Drawing.Size(208, 30);
            this.porttbx.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 175);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(173, 243);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(220, 175);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(574, 243);
            this.richTextBox2.TabIndex = 12;
            this.richTextBox2.Text = "";
            // 
            // openfilebtn
            // 
            this.openfilebtn.Location = new System.Drawing.Point(12, 123);
            this.openfilebtn.Name = "openfilebtn";
            this.openfilebtn.Size = new System.Drawing.Size(80, 36);
            this.openfilebtn.TabIndex = 14;
            this.openfilebtn.Text = "Open File";
            this.openfilebtn.UseVisualStyleBackColor = true;
            this.openfilebtn.Click += new System.EventHandler(this.openfilebtn_Click);
            // 
            // filename
            // 
            this.filename.Enabled = false;
            this.filename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filename.Location = new System.Drawing.Point(98, 129);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(595, 30);
            this.filename.TabIndex = 15;
            // 
            // sendbtn
            // 
            this.sendbtn.Location = new System.Drawing.Point(714, 129);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(80, 36);
            this.sendbtn.TabIndex = 16;
            this.sendbtn.Text = "Send";
            this.sendbtn.UseVisualStyleBackColor = true;
            this.sendbtn.Click += new System.EventHandler(this.sendbtn_Click);
            // 
            // targetUserName
            // 
            this.targetUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetUserName.Location = new System.Drawing.Point(12, 73);
            this.targetUserName.Name = "targetUserName";
            this.targetUserName.Size = new System.Drawing.Size(355, 37);
            this.targetUserName.TabIndex = 18;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 461);
            this.Controls.Add(this.targetUserName);
            this.Controls.Add(this.sendbtn);
            this.Controls.Add(this.filename);
            this.Controls.Add(this.openfilebtn);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.porttbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hosttbx);
            this.Controls.Add(this.connectbtn);
            this.Name = "Test";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button connectbtn;
        private System.Windows.Forms.TextBox hosttbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox porttbx;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button openfilebtn;
        private System.Windows.Forms.TextBox filename;
        private System.Windows.Forms.Button sendbtn;
        private System.Windows.Forms.ComboBox targetUserName;
    }
}