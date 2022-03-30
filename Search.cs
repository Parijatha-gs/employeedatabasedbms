using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;

namespace EmployeeManagementSystem
{
    public partial class Search : Form
    {
        public string constring = "Data Source=DESKTOP-VUE203J;Initial Catalog=employeedb;Integrated Security=True";
        public Search()
        {
            InitializeComponent();
        }

        private void emp_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee emp = new Employee();
            emp.Show();
        }

        private void dept_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Department dept = new Department();
            dept.Show();
        }

        private void comp_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Company c = new Company();
            c.Show();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search s = new Search();
            s.Show();
        }


        private void Search_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void proj_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Project d = new Project();
            d.Show();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            string sqlquery = "select *from [employeedb].[dbo].[employee] where [emp_id]='" + searchbar.Text + "' OR [dept_id]='" + searchbar.Text + "'OR [project_id]='" + searchbar.Text + "'OR [emp_name]='" + searchbar.Text + "'OR [emp_address]='" + searchbar.Text + "'OR [gender]='" + searchbar.Text + "';";
            con.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, con);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            searchgridview.DataSource = dt;
            con.Close();
        }

        private void searchgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            searchgridview.EnableHeadersVisualStyles = false;
            this.searchgridview.DefaultCellStyle.BackColor = Color.White;
            this.searchgridview.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lo = new Login();
            lo.Show();
        }
    }
}
