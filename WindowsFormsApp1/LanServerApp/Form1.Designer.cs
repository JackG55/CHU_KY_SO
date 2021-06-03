namespace LanServerApp
{
    partial class Form1
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
            this.startbtn = new System.Windows.Forms.Button();
            this.listUser = new System.Windows.Forms.RichTextBox();
            this.messagebox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // startbtn
            // 
            this.startbtn.Location = new System.Drawing.Point(326, 12);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(115, 37);
            this.startbtn.TabIndex = 0;
            this.startbtn.Text = "Start";
            this.startbtn.UseVisualStyleBackColor = true;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // listUser
            // 
            this.listUser.Location = new System.Drawing.Point(12, 96);
            this.listUser.Name = "listUser";
            this.listUser.Size = new System.Drawing.Size(174, 321);
            this.listUser.TabIndex = 1;
            this.listUser.Text = "";
            // 
            // messagebox
            // 
            this.messagebox.Location = new System.Drawing.Point(236, 96);
            this.messagebox.Multiline = true;
            this.messagebox.Name = "messagebox";
            this.messagebox.Size = new System.Drawing.Size(529, 321);
            this.messagebox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 429);
            this.Controls.Add(this.messagebox);
            this.Controls.Add(this.listUser);
            this.Controls.Add(this.startbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.RichTextBox listUser;
        private System.Windows.Forms.TextBox messagebox;
    }
}

