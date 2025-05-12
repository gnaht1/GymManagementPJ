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
    public partial class ViewEquipment : Form
    {
        public ViewEquipment()
        {
            InitializeComponent();
        }



        private void ViewEquipment_Load(object sender, EventArgs e)
        {
            try
            {
                
                string connectionString = "Host=localhost;Port=5432;Database=GymManagement;Username=postgres;Password=1234";


                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {

                    connection.Open();

                   
                    string query = "SELECT * FROM Equipment";

                    
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection))
                    {
                        
                        DataTable dataTable = new DataTable();

          
                        adapter.Fill(dataTable);

               
                        dataGridView1.DataSource = dataTable;

                        // General DataGridView settings
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
                // Handle other general errors
                MessageBox.Show("Error loading equipment data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
