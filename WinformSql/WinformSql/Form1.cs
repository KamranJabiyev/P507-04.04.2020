using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformSql
{
    public partial class Form1 : Form
    {
        private readonly string connectStr;
        public Form1()
        {
            InitializeComponent();
            connectStr = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            using(SqlConnection con = new SqlConnection(connectStr))
            {
                con.Open();

                string command = "Select Name from Students where Id=1";
                using(SqlCommand com = new SqlCommand(command, con))
                {
                    object result=await com.ExecuteScalarAsync();
                    if (result != null)
                    {
                        lblStuName.Text = result.ToString();
                    }
                    else
                    {
                        lblStuName.Text = "No such as data";
                    }
                    
                }
            }
            
        }

        private async void btnShowAllStu_Click(object sender, EventArgs e)
        {
            await GetAllStudent();
        }

        private async void btnCreateStu_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string surname = txtSurname.Text.Trim();

            if (name == "" || surname == "")
            {
                MessageBox.Show("Please fill all input", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(connectStr))
            {
                con.Open();

                string command = $"Insert into Students values('{name}','{surname}')";
                using (SqlCommand com = new SqlCommand(command, con))
                {
                    int result = await com.ExecuteNonQueryAsync();
                    if (result != 0)
                    {
                        MessageBox.Show("Succesfully added", "Success",
                                        MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }

                }
            }

            txtName.Text = "";
            txtSurname.Text = "";

            await GetAllStudent();
        }

        public async Task GetAllStudent()
        {
            cmbAllStu.Items.Clear();
            using (SqlConnection con = new SqlConnection(connectStr))
            {
                con.Open();

                string command = "Select Name from Students";
                using (SqlCommand com = new SqlCommand(command, con))
                {
                    SqlDataReader result = await com.ExecuteReaderAsync();
                    if (result.HasRows)
                    {
                        while (result.Read())
                        {
                            cmbAllStu.Items.Add(result.GetValue(0));
                        }
                    }
                }
            }
            btnShowAllStu.Enabled = false;
        }
    }
}
