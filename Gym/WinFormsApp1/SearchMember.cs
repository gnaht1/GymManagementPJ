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

                    // Check if search term is numeric (for MID)
                    if (!string.IsNullOrEmpty(searchTerm) && int.TryParse(searchTerm, out int memberId))
                    {
                        // Search by MID
                        query = @"
                    SELECT MID, Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, Gymtime, Maddress, MemberShipTime 
                    FROM public.NewMember 
                    WHERE MID = @memberId";
                        command = new NpgsqlCommand(query, connection);
                        command.Parameters.AddWithValue("memberId", memberId);
                    }
                    // Check if search term contains a space (for first and last name)
                    else if (!string.IsNullOrEmpty(searchTerm) && searchTerm.Contains(" "))
                    {
                        // Split into first and last name
                        string[] names = searchTerm.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        if (names.Length >= 2)
                        {
                            string firstName = names[0];
                            string lastName = names[1];

                            // Search by first and last name
                            query = @"
                        SELECT MID, Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, Gymtime, Maddress, MemberShipTime 
                        FROM public.NewMember 
                        WHERE Fname ILIKE @firstName AND Lname ILIKE @lastName";
                            command = new NpgsqlCommand(query, connection);
                            command.Parameters.AddWithValue("firstName", $"%{firstName}%");
                            command.Parameters.AddWithValue("lastName", $"%{lastName}%");
                        }
                        else
                        {
                            // Treat as single term for Fname or Lname
                            query = @"
                        SELECT MID, Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, Gymtime, Maddress, MemberShipTime 
                        FROM public.NewMember 
                        WHERE Fname ILIKE @searchTerm OR Lname ILIKE @searchTerm";
                            command = new NpgsqlCommand(query, connection);
                            command.Parameters.AddWithValue("searchTerm", $"%{searchTerm}%");
                        }
                    }
                    else
                    {
                        // General search or empty search
                        query = @"
                    SELECT MID, Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, Gymtime, Maddress, MemberShipTime 
                    FROM public.NewMember";
                        if (!string.IsNullOrEmpty(searchTerm))
                        {
                            query += " WHERE Fname ILIKE @searchTerm OR Lname ILIKE @searchTerm";
                        }
                        command = new NpgsqlCommand(query, connection);
                        if (!string.IsNullOrEmpty(searchTerm))
                        {
                            command.Parameters.AddWithValue("searchTerm", $"%{searchTerm}%");
                        }
                    }

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Check if results were found
                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("No matching members found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        // Bind data to DataGridView
                        dataGridView1.DataSource = dataTable;

                        // Apply styling
                        dataGridView1.AutoGenerateColumns = true;
                        dataGridView1.ReadOnly = true;
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
                        dataGridView1.ColumnHeadersHeight = 40;

                        // Auto-size rows for wrapped text (e.g., Maddress)
                        dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

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
    }
}
