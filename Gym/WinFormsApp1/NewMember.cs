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
        public NewMember()
        {
            InitializeComponent();
            InitializeComponent();
            this.Location = new Point(100, 100); // Đặt vị trí cố định trên màn hình
            this.Size = new Size(800, 600);     // Đảm bảo kích thước hợp lý
            this.Opacity = 1.0;                 // Đảm bảo form không trong suốt
            this.Visible = true;                // Đảm bảo form hiển thị
            this.WindowState = FormWindowState.Normal; // Đảm bảo form không bị thu nhỏ
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
    }
}
