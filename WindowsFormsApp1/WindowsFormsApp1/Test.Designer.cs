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
            this.components = new System.ComponentModel.Container();
            this.pdfViewer2 = new DevExpress.XtraPdfViewer.PdfViewer();
            this.testbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pdfViewer2
            // 
            this.pdfViewer2.Location = new System.Drawing.Point(3, 3);
            this.pdfViewer2.Name = "pdfViewer2";
            this.pdfViewer2.Size = new System.Drawing.Size(1166, 704);
            this.pdfViewer2.TabIndex = 1;
            // 
            // testbtn
            // 
            this.testbtn.Location = new System.Drawing.Point(531, 713);
            this.testbtn.Name = "testbtn";
            this.testbtn.Size = new System.Drawing.Size(80, 36);
            this.testbtn.TabIndex = 2;
            this.testbtn.Text = "Test";
            this.testbtn.UseVisualStyleBackColor = true;
            this.testbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 751);
            this.Controls.Add(this.testbtn);
            this.Controls.Add(this.pdfViewer2);
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraPdfViewer.PdfViewer pdfViewer2;
        private System.Windows.Forms.Button testbtn;
    }
}