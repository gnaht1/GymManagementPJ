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
    public partial class SearchMember : Form
    {
        public SearchMember()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

                    // Check if search term is numeric
                    if (!string.IsNullOrEmpty(searchTerm) && long.TryParse(searchTerm, out long numericValue))
                    {
                        // If 7 or more digits, treat as phone number
                        if (searchTerm.Length >= 7)
                        {
                            query = @"
                                SELECT MID, Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, Gymtime, Maddress, MemberShipTime 
                                FROM public.NewMember 
                                WHERE Mobile::text ILIKE @searchTerm";
                            command = new NpgsqlCommand(query, connection);
                            command.Parameters.AddWithValue("searchTerm", $"%{searchTerm}%");
                        }
                        // Otherwise, treat as MID
                        else
                        {
                            query = @"
                                SELECT MID, Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, Gymtime, Maddress, MemberShipTime 
                                FROM public.NewMember 
                                WHERE MID = @memberId";
                            command = new NpgsqlCommand(query, connection);
                            command.Parameters.AddWithValue("memberId", (int)numericValue);
                        }
                    }
                    else
                    {
                        // Empty or non-numeric search: show all members
                        query = @"
                            SELECT MID, Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, Gymtime, Maddress, MemberShipTime 
                            FROM public.NewMember";
                        command = new NpgsqlCommand(query, connection);
                    }

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("No matching members found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Error searching members: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewMembers_Click(object sender, EventArgs e)
        {
            try
            {

                string connectionString = "Host=localhost;Port=5432;Database=GymManagement;Username=postgres;Password=1234";

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        SELECT MID, Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, Gymtime, Maddress, MemberShipTime 
                        FROM public.NewMember";

                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            if (dataTable.Rows.Count == 0)
                            {
                                MessageBox.Show("No members found in the database.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            dataGridView1.DataSource = dataTable;

                            // Apply styling
                            dataGridView1.AutoGenerateColumns = true;
                            dataGridView1.ReadOnly = false;
                            dataGridView1.AllowUserToAddRows = false;
                            dataGridView1.AllowUserToDeleteRows = false;
                            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                            dataGridView1.MultiSelect = false;

                            // Visual styling
                            dataGridView1.EnableHeadersVisualStyles = true;
                            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                            dataGridView1.DefaultCellStyle.Padding = new Padding(5);
                            dataGridView1.GridColor = Color.DarkGray;
                            dataGridView1.BorderStyle = BorderStyle.FixedSingle;


                            // Column header styling
                            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
                            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                            dataGridView1.ColumnHeadersHeight = 20;

                            // Customize columns
                            dataGridView1.Columns["MID"].HeaderText = "Member ID";
                            dataGridView1.Columns["MID"].Width = 80;
                            dataGridView1.Columns["MID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                            dataGridView1.Columns["Fname"].HeaderText = "First Name";
                            dataGridView1.Columns["Fname"].Width = 120;

                            dataGridView1.Columns["Lname"].HeaderText = "Last Name";
                            dataGridView1.Columns["Lname"].Width = 120;

                            dataGridView1.Columns["Gender"].HeaderText = "Gender";
                            dataGridView1.Columns["Gender"].Width = 80;
                            dataGridView1.Columns["Gender"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                            dataGridView1.Columns["Dob"].HeaderText = "Date of Birth";
                            dataGridView1.Columns["Dob"].Width = 100;
                            dataGridView1.Columns["Dob"].DefaultCellStyle.Format = "dd/MM/yyyy";
                            dataGridView1.Columns["Dob"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                            dataGridView1.Columns["Mobile"].HeaderText = "Mobile";
                            dataGridView1.Columns["Mobile"].Width = 100;
                            dataGridView1.Columns["Mobile"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                            dataGridView1.Columns["Email"].HeaderText = "Email";
                            dataGridView1.Columns["Email"].Width = 100;

                            dataGridView1.Columns["JoinDate"].HeaderText = "Join Date";
                            dataGridView1.Columns["JoinDate"].Width = 100;
                            dataGridView1.Columns["JoinDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
                            dataGridView1.Columns["JoinDate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                            dataGridView1.Columns["Gymtime"].HeaderText = "Gym Time";
                            dataGridView1.Columns["Gymtime"].Width = 100;

                            dataGridView1.Columns["Maddress"].HeaderText = "Address";
                            dataGridView1.Columns["Maddress"].Width = 200;
                            dataGridView1.Columns["Maddress"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                            dataGridView1.Columns["MemberShipTime"].HeaderText = "Membership Duration";
                            dataGridView1.Columns["MemberShipTime"].Width = 120;

                            // Auto-size rows for wrapped text
                            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


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
                MessageBox.Show("Error viewing members: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = "Host=localhost;Port=5432;Database=GymManagement;Username=postgres;Password=1234";
            try
            {
                // Check if a row is selected
                if (dataGridView1.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Please select one member to edit.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Get selected row
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                // Validate inputs
                if (string.IsNullOrWhiteSpace(row.Cells["Fname"].Value?.ToString()) ||
                    string.IsNullOrWhiteSpace(row.Cells["Lname"].Value?.ToString()) ||
                    string.IsNullOrWhiteSpace(row.Cells["Gender"].Value?.ToString()) ||
                    string.IsNullOrWhiteSpace(row.Cells["Dob"].Value?.ToString()) ||
                    string.IsNullOrWhiteSpace(row.Cells["Mobile"].Value?.ToString()) ||
                    string.IsNullOrWhiteSpace(row.Cells["JoinDate"].Value?.ToString()) ||
                    string.IsNullOrWhiteSpace(row.Cells["Gymtime"].Value?.ToString()) ||
                    string.IsNullOrWhiteSpace(row.Cells["Maddress"].Value?.ToString()) ||
                    string.IsNullOrWhiteSpace(row.Cells["MemberShipTime"].Value?.ToString()))
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

                // Extract values
                int mid = Convert.ToInt32(row.Cells["MID"].Value);
                string fname = row.Cells["Fname"].Value.ToString();
                string lname = row.Cells["Lname"].Value.ToString();
                string gender = row.Cells["Gender"].Value.ToString();
                string email = row.Cells["Email"].Value?.ToString();
                string gymtime = row.Cells["Gymtime"].Value.ToString();
                string maddress = row.Cells["Maddress"].Value.ToString();
                string membershipTime = row.Cells["MemberShipTime"].Value.ToString();

                // Update database
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        UPDATE public.NewMember 
                        SET Fname = @fname, Lname = @lname, Gender = @gender, Dob = @dob, Mobile = @mobile, 
                            Email = @email, JoinDate = @joinDate, Gymtime = @gymtime, Maddress = @maddress, 
                            MemberShipTime = @membershipTime
                        WHERE MID = @mid";

                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("mid", mid);
                        command.Parameters.AddWithValue("fname", fname);
                        command.Parameters.AddWithValue("lname", lname);
                        command.Parameters.AddWithValue("gender", gender);
                        command.Parameters.AddWithValue("dob", dob);
                        command.Parameters.AddWithValue("mobile", mobile);
                        command.Parameters.AddWithValue("email", (object)email ?? DBNull.Value);
                        command.Parameters.AddWithValue("joinDate", joinDate);
                        command.Parameters.AddWithValue("gymtime", gymtime);
                        command.Parameters.AddWithValue("maddress", maddress);
                        command.Parameters.AddWithValue("membershipTime", membershipTime);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Member updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Error editing member: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectionString = "Host=localhost;Port=5432;Database=GymManagement;Username=postgres;Password=1234";
            try
            {
                // Check if a row is selected
                if (dataGridView1.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Please select one member to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Confirm deletion
                if (MessageBox.Show("Are you sure you want to delete this member?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }

                // Get selected row's MID
                int mid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["MID"].Value);

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM public.NewMember WHERE MID = @mid";
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("mid", mid);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Member deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Error deleting member: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        SELECT MID, Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, Gymtime, Maddress, MemberShipTime 
                        FROM public.NewMember";
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            if (dataTable.Rows.Count == 0)
                            {
                                MessageBox.Show("No members found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Error loading members: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyDataGridViewStyling()
        {
            // Apply styling
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            // Enable editing for specific columns
            dataGridView1.ReadOnly = false; // Allow editing by default
            if (dataGridView1.Columns["MID"] != null)
                dataGridView1.Columns["MID"].ReadOnly = true; // MID is read-only

            // Visual styling
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

            // Customize columns
            if (dataGridView1.Columns["MID"] != null)
            {
                dataGridView1.Columns["MID"].HeaderText = "Member ID";
                dataGridView1.Columns["MID"].Width = 80;
                dataGridView1.Columns["MID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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

            if (dataGridView1.Columns["Gymtime"] != null)
            {
                dataGridView1.Columns["Gymtime"].HeaderText = "Gym Time";
                dataGridView1.Columns["Gymtime"].Width = 100;
            }

            if (dataGridView1.Columns["Maddress"] != null)
            {
                dataGridView1.Columns["Maddress"].HeaderText = "Address";
                dataGridView1.Columns["Maddress"].Width = 200;
                dataGridView1.Columns["Maddress"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

            if (dataGridView1.Columns["MemberShipTime"] != null)
            {
                dataGridView1.Columns["MemberShipTime"].HeaderText = "Membership Duration";
                dataGridView1.Columns["MemberShipTime"].Width = 120;
            }

            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


        }

        
    }

}
