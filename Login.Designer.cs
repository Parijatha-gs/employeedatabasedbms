
namespace EmployeeManagementSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailidtextbox = new System.Windows.Forms.TextBox();
            this.passwordtextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linklogin = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.loginbutton = new System.Windows.Forms.Button();
            this.lnkfrgtpsswd = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(347, 55);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(249, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Email ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(249, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password :";
            // 
            // emailidtextbox
            // 
            this.emailidtextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailidtextbox.Location = new System.Drawing.Point(347, 293);
            this.emailidtextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailidtextbox.Name = "emailidtextbox";
            this.emailidtextbox.Size = new System.Drawing.Size(260, 34);
            this.emailidtextbox.TabIndex = 11;
            // 
            // passwordtextbox
            // 
            this.passwordtextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordtextbox.Location = new System.Drawing.Point(347, 353);
            this.passwordtextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordtextbox.Name = "passwordtextbox";
            this.passwordtextbox.PasswordChar = '*';
            this.passwordtextbox.Size = new System.Drawing.Size(260, 34);
            this.passwordtextbox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 546);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "New to EDBMS? Click ";
            // 
            // linklogin
            // 
            this.linklogin.AutoSize = true;
            this.linklogin.Location = new System.Drawing.Point(461, 546);
            this.linklogin.Name = "linklogin";
            this.linklogin.Size = new System.Drawing.Size(38, 20);
            this.linklogin.TabIndex = 14;
            this.linklogin.TabStop = true;
            this.linklogin.Text = "here";
            this.linklogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(495, 546);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "to register.";
            // 
            // loginbutton
            // 
            this.loginbutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginbutton.Location = new System.Drawing.Point(374, 429);
            this.loginbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(86, 45);
            this.loginbutton.TabIndex = 16;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // lnkfrgtpsswd
            // 
            this.lnkfrgtpsswd.AutoSize = true;
            this.lnkfrgtpsswd.Location = new System.Drawing.Point(356, 478);
            this.lnkfrgtpsswd.Name = "lnkfrgtpsswd";
            this.lnkfrgtpsswd.Size = new System.Drawing.Size(125, 20);
            this.lnkfrgtpsswd.TabIndex = 17;
            this.lnkfrgtpsswd.TabStop = true;
            this.lnkfrgtpsswd.Text = "forgot password?";
            this.lnkfrgtpsswd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkfrgtpsswd_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(896, 615);
            this.Controls.Add(this.lnkfrgtpsswd);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linklogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordtextbox);
            this.Controls.Add(this.emailidtextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Database Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailidtextbox;
        private System.Windows.Forms.TextBox passwordtextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linklogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.LinkLabel lnkfrgtpsswd;
    }
}