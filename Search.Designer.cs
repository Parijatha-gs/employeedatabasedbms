
namespace EmployeeManagementSystem
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.proj_btn = new System.Windows.Forms.Button();
            this.emp_btn = new System.Windows.Forms.Button();
            this.dept_btn = new System.Windows.Forms.Button();
            this.comp_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchgridview = new System.Windows.Forms.DataGridView();
            this.searchbutton = new System.Windows.Forms.Button();
            this.searchbar = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchgridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.proj_btn);
            this.panel1.Controls.Add(this.emp_btn);
            this.panel1.Controls.Add(this.dept_btn);
            this.panel1.Controls.Add(this.comp_btn);
            this.panel1.Controls.Add(this.search_btn);
            this.panel1.Location = new System.Drawing.Point(14, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 921);
            this.panel1.TabIndex = 3;
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(55, 840);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(159, 45);
            this.logout.TabIndex = 9;
            this.logout.Text = "logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 169);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // proj_btn
            // 
            this.proj_btn.Location = new System.Drawing.Point(3, 465);
            this.proj_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.proj_btn.Name = "proj_btn";
            this.proj_btn.Size = new System.Drawing.Size(272, 63);
            this.proj_btn.TabIndex = 5;
            this.proj_btn.Text = "Project Details";
            this.proj_btn.UseVisualStyleBackColor = true;
            this.proj_btn.Click += new System.EventHandler(this.proj_btn_Click);
            // 
            // emp_btn
            // 
            this.emp_btn.Location = new System.Drawing.Point(3, 395);
            this.emp_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emp_btn.Name = "emp_btn";
            this.emp_btn.Size = new System.Drawing.Size(272, 63);
            this.emp_btn.TabIndex = 4;
            this.emp_btn.Text = "Employee Details";
            this.emp_btn.UseVisualStyleBackColor = true;
            this.emp_btn.Click += new System.EventHandler(this.emp_btn_Click);
            // 
            // dept_btn
            // 
            this.dept_btn.Location = new System.Drawing.Point(3, 324);
            this.dept_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dept_btn.Name = "dept_btn";
            this.dept_btn.Size = new System.Drawing.Size(272, 63);
            this.dept_btn.TabIndex = 3;
            this.dept_btn.Text = "Department Details";
            this.dept_btn.UseVisualStyleBackColor = true;
            this.dept_btn.Click += new System.EventHandler(this.dept_btn_Click);
            // 
            // comp_btn
            // 
            this.comp_btn.Location = new System.Drawing.Point(3, 253);
            this.comp_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comp_btn.Name = "comp_btn";
            this.comp_btn.Size = new System.Drawing.Size(272, 63);
            this.comp_btn.TabIndex = 2;
            this.comp_btn.Text = "Company Details";
            this.comp_btn.UseVisualStyleBackColor = true;
            this.comp_btn.Click += new System.EventHandler(this.comp_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(3, 183);
            this.search_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(272, 63);
            this.search_btn.TabIndex = 1;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.searchgridview);
            this.panel2.Controls.Add(this.searchbutton);
            this.panel2.Controls.Add(this.searchbar);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(301, 145);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(981, 792);
            this.panel2.TabIndex = 5;
            // 
            // searchgridview
            // 
            this.searchgridview.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.searchgridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchgridview.GridColor = System.Drawing.Color.White;
            this.searchgridview.Location = new System.Drawing.Point(79, 145);
            this.searchgridview.Name = "searchgridview";
            this.searchgridview.RowHeadersWidth = 51;
            this.searchgridview.RowTemplate.Height = 29;
            this.searchgridview.Size = new System.Drawing.Size(762, 532);
            this.searchgridview.TabIndex = 9;
            this.searchgridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchgridview_CellContentClick);
            // 
            // searchbutton
            // 
            this.searchbutton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchbutton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.searchbutton.Location = new System.Drawing.Point(626, 68);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(81, 43);
            this.searchbutton.TabIndex = 8;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // searchbar
            // 
            this.searchbar.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchbar.ForeColor = System.Drawing.Color.Black;
            this.searchbar.Location = new System.Drawing.Point(143, 68);
            this.searchbar.Name = "searchbar";
            this.searchbar.PlaceholderText = "search for something...";
            this.searchbar.Size = new System.Drawing.Size(477, 43);
            this.searchbar.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(79, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 49);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(79, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search Employee Database";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.label14);
            this.panel3.Location = new System.Drawing.Point(302, 17);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(979, 120);
            this.panel3.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(3, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(212, 81);
            this.label14.TabIndex = 32;
            this.label14.Text = "Search";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1294, 953);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Database Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Search_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchgridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button emp_btn;
        private System.Windows.Forms.Button dept_btn;
        private System.Windows.Forms.Button comp_btn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button proj_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView searchgridview;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.TextBox searchbar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logout;
    }
}