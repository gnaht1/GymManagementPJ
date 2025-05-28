using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Npgsql;
using ScottPlot;
using ScottPlot.WinForms;
using ScottPlot.TickGenerators;
using System.Globalization;
using ScottPlot.Plottables; // Thêm using cho Alignment

namespace GymManagement
{
    public partial class OverviewDashboardForm : Form
    {

        //private Panel panel1; // Đảm bảo bạn có Panel này trong Designer

        private string connectionString = "Host=localhost;Port=5432;Database=GymManagement;Username=postgres;Password=1234";

        public OverviewDashboardForm()
        {
            InitializeComponent();
            // Khởi tạo các Label và Panel (nếu bạn không làm trong Designer)

            LoadDashboard();
        }



        private void LoadDashboard()
        {
            // Tạo FormsPlot cho biểu đồ
            var formsPlot = new FormsPlot
            {
                // Bỏ Location và Size, thay bằng Dock
                // Location = new System.Drawing.Point(50, 200),
                // Size = new System.Drawing.Size(600, 300)
                Dock = DockStyle.Fill // <<< THAY ĐỔI: Để lấp đầy Panel
            };

            // ... (Khởi tạo dữ liệu values, positions, labels như cũ) ...
            double[] values = new double[12];
            double[] positions = new double[12];
            string[] labels = new string[12];
            DateTimeFormatInfo dtfi = new CultureInfo("en-US", false).DateTimeFormat;
            for (int i = 0; i < 12; i++)
            {
                positions[i] = i;
                // Lấy tên tháng bằng tiếng Anh (ví dụ: "January", "February", ...)
                // Hoặc bạn có thể dùng tên viết tắt: dtfi.GetAbbreviatedMonthName(i + 1)
                labels[i] = dtfi.GetMonthName(i + 1);
            }


            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    // ... (Phần lấy dữ liệu từ database như cũ) ...
                    // 1. Tổng số thành viên
                    using (var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM NewMember", conn))
                    {
                        lblTotalMembers.Text = "Total member: " + cmd.ExecuteScalar().ToString();
                    }

                    // 2. Tổng số nhân viên
                    using (var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM NewStaff", conn))
                    {
                        lblTotalStaff.Text = "Total staff: " + cmd.ExecuteScalar().ToString();
                    }

                    // 3. Tổng số thiết bị
                    using (var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM Equipment", conn))
                    {
                        lblTotalEquipment.Text = "Total Equipment: " + cmd.ExecuteScalar().ToString();
                    }

                    // 4. Tổng chi phí thiết bị
                    using (var cmd = new NpgsqlCommand("SELECT SUM(Cost) FROM Equipment", conn))
                    {
                        var result = cmd.ExecuteScalar();
                        lblTotalEquipmentCost.Text = "Total Equipment Cost: " + (result != DBNull.Value ? Convert.ToDecimal(result).ToString("N0") : "0") + " USD";
                    }

                    // 5. Số thành viên mới trong tháng hiện tại
                    using (var cmd = new NpgsqlCommand(
                        @"SELECT COUNT(*) 
                          FROM NewMember 
                          WHERE EXTRACT(MONTH FROM JoinDate) = EXTRACT(MONTH FROM CURRENT_DATE)
                            AND EXTRACT(YEAR FROM JoinDate) = EXTRACT(YEAR FROM CURRENT_DATE)", conn))
                    {
                        lblNewMembersThisMonth.Text = "New member in this month: " + cmd.ExecuteScalar().ToString();
                    }

                    // 6. Dữ liệu cho biểu đồ
                    using (var cmd = new NpgsqlCommand(
                        @"SELECT EXTRACT(MONTH FROM JoinDate) AS Month, COUNT(*) AS MemberCount
                          FROM NewMember
                          WHERE EXTRACT(YEAR FROM JoinDate) = EXTRACT(YEAR FROM CURRENT_DATE)
                          GROUP BY EXTRACT(MONTH FROM JoinDate)
                          ORDER BY Month", conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int month = Convert.ToInt32(reader["Month"]) - 1;
                                int count = Convert.ToInt32(reader["MemberCount"]);
                                if (month >= 0 && month < 12)
                                {
                                    values[month] = count;
                                }
                            }
                        }
                    }
                }

                // Vẽ biểu đồ cột
                var barPlot = formsPlot.Plot.Add.Bars(positions, values);

                // Tạo các Ticks thủ công
                var manualTicks = positions.Select((pos, i) => new Tick(pos, labels[i])).ToArray();

                // Thiết lập nhãn cho trục X
                formsPlot.Plot.Axes.Bottom.TickGenerator = new NumericManual(manualTicks);
                formsPlot.Plot.Axes.Bottom.TickLabelStyle.Rotation = 45;
                formsPlot.Plot.Axes.Bottom.TickLabelStyle.Alignment = Alignment.MiddleRight;

                // Thiết lập tiêu đề và nhãn trục
                formsPlot.Plot.Title("Number of new members per month");
                formsPlot.Plot.YLabel("Number");
                formsPlot.Plot.XLabel("Month");

                // Đặt giới hạn trục Y
                formsPlot.Plot.Axes.SetLimits(left: -0.5, right: 11.5, bottom: 0, top: values.Max() + 1);

                // Làm mới biểu đồ
                formsPlot.Refresh();

                // Thêm FormsPlot vào Panel1 thay vì Form
                panel1.Controls.Add(formsPlot); // <<< THAY ĐỔI: Thêm vào panel1

                // Xóa dòng này nếu có:
                // this.Controls.Add(formsPlot);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OverviewDashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}