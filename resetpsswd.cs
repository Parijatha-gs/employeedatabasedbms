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
    public partial class resetpsswd : Form
    {
        public string ConnectionString = "Data Source=DESKTOP-VUE203J;Initial Catalog=employeedb;Integrated Security=True";
        public resetpsswd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (emailtextBox.Text == "" || passwordtextBox.Text == "")
                {
                    throw new Exception("Invalid input");
                }
                SqlConnection sqlCon = new SqlConnection(ConnectionString);
                sqlCon.Open();
                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update [employeedb].[dbo].[registration] set password='" + passwordtextBox.Text + "' where emailid='" + emailtextBox.Text + "';";
                cmd.ExecuteNonQuery();
                SqlCommand cmd1 = sqlCon.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select * from [employeedb].[dbo].[registration] where password='" + passwordtextBox.Text + "' and emailid='" + emailtextBox.Text + "';";
                SqlDataAdapter sda = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cmd1.ExecuteNonQuery();
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Reset successful!");
                    this.Hide();
                    Login l = new Login();
                    l.Show();
                }
                else
                {
                    MessageBox.Show("inavlid email or password");
                }
                sqlCon.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("inavlid email or password");
            }
        }

        private void cancel_comp_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login c = new Login();
            c.Show();
        }
    }
    }

