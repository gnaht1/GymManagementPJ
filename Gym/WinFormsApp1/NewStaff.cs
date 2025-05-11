using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class NewStaff : Form
    {
        private readonly string connectionString = "Host=localhost;Port=5432;Database=GymManagement;Username=postgres;Password=1234";
        public NewStaff()
        {
            InitializeComponent();
        }

        private void FirstName_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                String fname = txtFName.Text;
                String lname = txtLName.Text;

                String gender = "";

                bool isChecked = radioButton1.Checked;

                if (isChecked)
                {
                    gender = radioButton1.Text;
                }
                else
                {
                    gender = radioButton2.Text;
                }

                DateTime dob = dateTimePickerDOB.Value;

                Int64 mobile = Int64.Parse(txtMobile.Text);

                string email = txtEmail.Text;

                DateTime joindate = dateTimePickerJoinDate.Value;

                string state = txtState.Text;
                string city = txtCity.Text;

                // Check required data
                if (string.IsNullOrWhiteSpace(fname) || string.IsNullOrWhiteSpace(lname) ||
                    string.IsNullOrWhiteSpace(gender) || string.IsNullOrWhiteSpace(state) ||
                    string.IsNullOrWhiteSpace(city))
                {
                    MessageBox.Show("Please fill in all required fields!");
                    return;
                }

                // Connect to Postgre and save data
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        INSERT INTO NewStaff (Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, State, City)
                        VALUES (@Fname, @Lname, @Gender, @Dob, @Mobile, @Email, @JoinDate, @State, @City)";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("Fname", fname);
                        cmd.Parameters.AddWithValue("Lname", lname);
                        cmd.Parameters.AddWithValue("Gender", gender);
                        cmd.Parameters.AddWithValue("Dob", dob);
                        cmd.Parameters.AddWithValue("Mobile", mobile);
                        cmd.Parameters.AddWithValue("Email", email != "" ? email : (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("JoinDate", joindate);
                        cmd.Parameters.AddWithValue("State", state);
                        cmd.Parameters.AddWithValue("City", city);


                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Add staff successfully.");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Cannot add staff!");
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Errors: " + ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFName.Clear();
            txtLName.Clear();
            txtMobile.Clear();
            txtEmail.Clear();
            txtState.Clear();
            txtCity.Clear();

            radioButton1.Checked = false;
            radioButton2.Checked = false;

            dateTimePickerDOB.Value = DateTime.Today;
            dateTimePickerJoinDate.Value = DateTime.Today;
        }
    }
}
