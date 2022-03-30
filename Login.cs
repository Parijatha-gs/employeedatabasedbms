using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace EmployeeManagementSystem
{
    public partial class Login : Form
    {
        public string constring = "Data Source=DESKTOP-VUE203J;Initial Catalog=employeedb;Integrated Security=True";
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register r = new Register();
            r.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            string sqlquery = "select *from [employeedb].[dbo].[registration] where emailid=@emailid and password=@password";
            con.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, con);
            sqlcomm.Parameters.AddWithValue("@emailid", emailidtextbox.Text);
            sqlcomm.Parameters.AddWithValue("@password", passwordtextbox.Text);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sqlcomm.ExecuteNonQuery();
            if (dt.Rows.Count > 0)
            {

                this.Hide();
                Search s = new Search();
                s.Show();
            }
            else
            {
                MessageBox.Show("inavlid email or password");
            }
            emailidtextbox.Text = "";
            passwordtextbox.Text = "";
            con.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lnkfrgtpsswd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            resetpsswd resetpsswd = new resetpsswd();
            resetpsswd.Show();
        }
    }
}
