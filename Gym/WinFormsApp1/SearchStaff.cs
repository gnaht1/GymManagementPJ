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

namespace GymManagement
{
    public partial class SearchStaff : Form
    {
        public SearchStaff()
        {
            InitializeComponent();
        }

        private void btnViewStaffs_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Host=localhost;Port=5432;Database=GymManagement;Username=postgres;Password=1234";

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT SID, Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, State, City 
                        FROM public.NewStaff";

                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            if (dataTable.Rows.Count == 0)
                            {
                                MessageBox.Show("No staff found in the database.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            dataGridView1.DataSource = dataTable;
                            ApplyDataGridViewStyling();
                        }
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error viewing staff: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtSearch.Text.Trim();
                string connectionString = "Host=localhost;Port=5432;Database=GymManagement;Username=postgres;Password=1234";

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query;
                    NpgsqlCommand command;

                    if (!string.IsNullOrEmpty(searchTerm) && long.TryParse(searchTerm, out long numericValue))
                    {
                        if (searchTerm.Length >= 7)
                        {
                            query = @"
                                SELECT SID, Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, State, City 
                                FROM public.NewStaff 
                                WHERE Mobile::text ILIKE @searchTerm";
                            command = new NpgsqlCommand(query, connection);
                            command.Parameters.AddWithValue("searchTerm", $"%{searchTerm}%");
                        }
                        else
                        {
                            query = @"
                                SELECT SID, Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, State, City 
                                FROM public.NewStaff 
                                WHERE SID = @staffId";
                            command = new NpgsqlCommand(query, connection);
                            command.Parameters.AddWithValue("staffId", (int)numericValue);
                        }
                    }
                    else
                    {
                        query = @"
                            SELECT SID, Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, State, City 
                            FROM public.NewStaff";
                        command = new NpgsqlCommand(query, connection);
                    }

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("No matching staff found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        dataGridView1.DataSource = dataTable;
                        ApplyDataGridViewStyling();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching staff: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = "Host=localhost;Port=5432;Database=GymManagement;Username=postgres;Password=1234";
            try
            {
                if (dataGridView1.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Please select one staff member to edit.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DataGridViewRow row = dataGridView1.SelectedRows[0];

                if (string.IsNullOrWhiteSpace(row.Cells["Fname"].Value?.ToString()) ||
                    string.IsNullOrWhiteSpace(row.Cells["Lname"].Value?.ToString()) ||
                    string.IsNullOrWhiteSpace(row.Cells["Gender"].Value?.ToString()) ||
                    string.IsNullOrWhiteSpace(row.Cells["Dob"].Value?.ToString()) ||
                    string.IsNullOrWhiteSpace(row.Cells["Mobile"].Value?.ToString()) ||
                    string.IsNullOrWhiteSpace(row.Cells["JoinDate"].Value?.ToString()) ||
                    string.IsNullOrWhiteSpace(row.Cells["State"].Value?.ToString()) ||
                    string.IsNullOrWhiteSpace(row.Cells["City"].Value?.ToString()))
                {
                    MessageBox.Show("All fields except Email are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!DateTime.TryParse(row.Cells["Dob"].Value?.ToString(), out DateTime dob))
                {
                    MessageBox.Show("Invalid Date of Birth format. Use yyyy-MM-dd.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!long.TryParse(row.Cells["Mobile"].Value?.ToString(), out long mobile))
                {
                    MessageBox.Show("Mobile must be a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!DateTime.TryParse(row.Cells["JoinDate"].Value?.ToString(), out DateTime joinDate))
                {
                    MessageBox.Show("Invalid Join Date format. Use yyyy-MM-dd.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!new[] { "Male", "Female", "Other" }.Contains(row.Cells["Gender"].Value?.ToString()))
                {
                    MessageBox.Show("Gender must be Male, Female, or Other.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int sid = Convert.ToInt32(row.Cells["SID"].Value);
                string fname = row.Cells["Fname"].Value.ToString();
                string lname = row.Cells["Lname"].Value.ToString();
                string gender = row.Cells["Gender"].Value.ToString();
                string email = row.Cells["Email"].Value?.ToString();
                string state = row.Cells["State"].Value.ToString();
                string city = row.Cells["City"].Value.ToString();

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        UPDATE public.NewStaff 
                        SET Fname = @fname, Lname = @lname, Gender = @gender, Dob = @dob, Mobile = @mobile, 
                            Email = @email, JoinDate = @joinDate, State = @state, City = @city
                        WHERE SID = @sid";

                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("sid", sid);
                        command.Parameters.AddWithValue("fname", fname);
                        command.Parameters.AddWithValue("lname", lname);
                        command.Parameters.AddWithValue("gender", gender);
                        command.Parameters.AddWithValue("dob", dob);
                        command.Parameters.AddWithValue("mobile", mobile);
                        command.Parameters.AddWithValue("email", (object)email ?? DBNull.Value);
                        command.Parameters.AddWithValue("joinDate", joinDate);
                        command.Parameters.AddWithValue("state", state);
                        command.Parameters.AddWithValue("city", city);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Staff updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update staff.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error editing staff: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectionString = "Host=localhost;Port=5432;Database=GymManagement;Username=postgres;Password=1234";
            try
            {
                if (dataGridView1.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Please select one staff member to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to delete this staff member?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }

                int sid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["SID"].Value);

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM public.NewStaff WHERE SID = @sid";
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("sid", sid);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Staff deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete staff.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting staff: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshDataGridView()
        {
            string connectionString = "Host=localhost;Port=5432;Database=GymManagement;Username=postgres;Password=1234";
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT SID, Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, State, City 
                        FROM public.NewStaff";
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            if (dataTable.Rows.Count == 0)
                            {
                                MessageBox.Show("No staff found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            dataGridView1.DataSource = dataTable;
                            ApplyDataGridViewStyling();
                        }
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading staff: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyDataGridViewStyling()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            dataGridView1.ReadOnly = false;
            if (dataGridView1.Columns["SID"] != null)
                dataGridView1.Columns["SID"].ReadOnly = true;

            dataGridView1.EnableHeadersVisualStyles = true;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView1.DefaultCellStyle.Padding = new Padding(5);
            dataGridView1.GridColor = Color.DarkGray;
            dataGridView1.BorderStyle = BorderStyle.FixedSingle;

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersHeight = 20;

            if (dataGridView1.Columns["SID"] != null)
            {
                dataGridView1.Columns["SID"].HeaderText = "Staff ID";
                dataGridView1.Columns["SID"].Width = 80;
                dataGridView1.Columns["SID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dataGridView1.Columns["Fname"] != null)
            {
                dataGridView1.Columns["Fname"].HeaderText = "First Name";
                dataGridView1.Columns["Fname"].Width = 120;
            }

            if (dataGridView1.Columns["Lname"] != null)
            {
                dataGridView1.Columns["Lname"].HeaderText = "Last Name";
                dataGridView1.Columns["Lname"].Width = 120;
            }

            if (dataGridView1.Columns["Gender"] != null)
            {
                dataGridView1.Columns["Gender"].HeaderText = "Gender";
                dataGridView1.Columns["Gender"].Width = 80;
                dataGridView1.Columns["Gender"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dataGridView1.Columns["Dob"] != null)
            {
                dataGridView1.Columns["Dob"].HeaderText = "Date of Birth";
                dataGridView1.Columns["Dob"].Width = 100;
                dataGridView1.Columns["Dob"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView1.Columns["Dob"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dataGridView1.Columns["Mobile"] != null)
            {
                dataGridView1.Columns["Mobile"].HeaderText = "Mobile";
                dataGridView1.Columns["Mobile"].Width = 100;
                dataGridView1.Columns["Mobile"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (dataGridView1.Columns["Email"] != null)
            {
                dataGridView1.Columns["Email"].HeaderText = "Email";
                dataGridView1.Columns["Email"].Width = 150;
            }

            if (dataGridView1.Columns["JoinDate"] != null)
            {
                dataGridView1.Columns["JoinDate"].HeaderText = "Join Date";
                dataGridView1.Columns["JoinDate"].Width = 100;
                dataGridView1.Columns["JoinDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView1.Columns["JoinDate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dataGridView1.Columns["State"] != null)
            {
                dataGridView1.Columns["State"].HeaderText = "State";
                dataGridView1.Columns["State"].Width = 100;
            }

            if (dataGridView1.Columns["City"] != null)
            {
                dataGridView1.Columns["City"].HeaderText = "City";
                dataGridView1.Columns["City"].Width = 100;
            }

            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
    }

}
