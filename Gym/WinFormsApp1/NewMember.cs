using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{

    public partial class NewMember : Form
    {
        private readonly string connectionString = "Host=localhost;Port=5432;Database=GymManagement;Username=postgres;Password=1234";
        public NewMember()
        {

            InitializeComponent();


        }

        private void NewMember_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                String fname = txtFirstName.Text;
                String lname = txtLastName.Text;
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

                String gymTime = comboBoxGymTime.Text;

                string address = txtAddress.Text;

                string membershipTime = comboBoxMembershipTime.Text;

                //Check required data
                if (string.IsNullOrWhiteSpace(fname) || string.IsNullOrWhiteSpace(lname) ||
                        string.IsNullOrWhiteSpace(gender) || string.IsNullOrWhiteSpace(address) ||
                        string.IsNullOrWhiteSpace(membershipTime))
                {
                    MessageBox.Show("Please fill in all required fields!");
                    return;
                }

                // Connect to Postgre and save data
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();


                    string query = @"
                        INSERT INTO NewMember (fname, lname, gender, dob, mobile, email, joindate, gymtime, maddress, membershiptime)
                        VALUES (@Fname, @Lname, @Gender, @Dob, @Mobile, @Email, @JoinDate, @Gymtime, @Maddress, @MemberShipTime)";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("Fname", fname);
                        cmd.Parameters.AddWithValue("Lname", lname);
                        cmd.Parameters.AddWithValue("Gender", gender);
                        cmd.Parameters.AddWithValue("Dob", dob);
                        cmd.Parameters.AddWithValue("Mobile", mobile);
                        cmd.Parameters.AddWithValue("Email", email != "" ? email : (object)DBNull.Value); // Email có thể null
                        cmd.Parameters.AddWithValue("JoinDate", joindate);
                        cmd.Parameters.AddWithValue("Gymtime", gymTime);
                        cmd.Parameters.AddWithValue("Maddress", address);
                        cmd.Parameters.AddWithValue("MemberShipTime", membershipTime);

                        // execute
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Insert Member Successfully!");
                            //this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Cannot Insert Member!");
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
            txtFirstName.Clear();

            txtLastName.Clear();

            radioButton1.Checked = false;
            radioButton2.Checked = false;

            txtMobile.Clear();

            txtEmail.Clear();

            comboBoxGymTime.ResetText();

            comboBoxMembershipTime.ResetText();

            txtAddress.Clear();

            dateTimePickerDOB.Value = DateTime.Now;

            dateTimePickerJoinDate.Value = DateTime.Now;


        }
    }
}
