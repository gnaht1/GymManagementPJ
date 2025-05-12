using GymManagement;
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
    public partial class Equipment : Form
    {
        public Equipment()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Equipment_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string eqName = txtEquipName.Text.Trim();
            string dsc = txtDsc.Text.Trim();
            string muscleUsed = txtMucleUsed.Text.Trim();
            DateTime deliveryDate = dateTimePickerDeliveryDate.Value;
            string costText = txtCost.Text.Trim();


            if (string.IsNullOrEmpty(eqName))
            {
                MessageBox.Show("Please enter the equipment name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEquipName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(dsc))
            {
                MessageBox.Show("Please enter the description.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDsc.Focus();
                return;
            }

            if (string.IsNullOrEmpty(muscleUsed))
            {
                MessageBox.Show("Please enter the muscle used.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMucleUsed.Focus();
                return;
            }

            if (!long.TryParse(costText, out long cost) || cost <= 0)
            {
                MessageBox.Show("Please enter a valid positive cost.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCost.Focus();
                return;
            }

            // Database connection 
            string connectionString = "Host=localhost;Port=5432;Database=GymManagement;Username=postgres;Password=1234";

            string query = "INSERT INTO Equipment (EName, EDescription, MUsed, DDate, Cost) " +
                           "VALUES (@EName, @EDescription, @MUsed, @DDate, @Cost)";

            try
            {

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@EName", eqName);
                        command.Parameters.AddWithValue("@EDescription", dsc);
                        command.Parameters.AddWithValue("@MUsed", muscleUsed);
                        command.Parameters.AddWithValue("@DDate", deliveryDate);
                        command.Parameters.AddWithValue("@Cost", cost);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Insert Equipment Successfully!");
                            //this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Cannot Insert Equipment!");
                        }
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEquipName.Clear();
            txtDsc.Clear();
            txtMucleUsed.Clear();
            txtCost.Clear();
            dateTimePickerDeliveryDate.Value = DateTime.Now;
        }

        private void btnViewEq_Click(object sender, EventArgs e)
        {
            ViewEquipment ve = new ViewEquipment();
            ve.Show();
        }
    }
}
