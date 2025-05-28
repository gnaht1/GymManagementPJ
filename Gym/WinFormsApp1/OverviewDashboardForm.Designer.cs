namespace GymManagement
{
    partial class OverviewDashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTotalMembers = new Label();
            lblTotalStaff = new Label();
            lblTotalEquipment = new Label();
            lblTotalEquipmentCost = new Label();
            lblNewMembersThisMonth = new Label();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTotalMembers
            // 
            lblTotalMembers.AutoSize = true;
            lblTotalMembers.Location = new Point(3, 0);
            lblTotalMembers.Name = "lblTotalMembers";
            lblTotalMembers.Size = new Size(102, 20);
            lblTotalMembers.TabIndex = 0;
            lblTotalMembers.Text = "Total Member";
            // 
            // lblTotalStaff
            // 
            lblTotalStaff.AutoSize = true;
            lblTotalStaff.Location = new Point(142, 0);
            lblTotalStaff.Name = "lblTotalStaff";
            lblTotalStaff.Size = new Size(77, 20);
            lblTotalStaff.TabIndex = 1;
            lblTotalStaff.Text = "Total Staff";
            // 
            // lblTotalEquipment
            // 
            lblTotalEquipment.AutoSize = true;
            lblTotalEquipment.Location = new Point(3, 62);
            lblTotalEquipment.Name = "lblTotalEquipment";
            lblTotalEquipment.Size = new Size(118, 20);
            lblTotalEquipment.TabIndex = 2;
            lblTotalEquipment.Text = "Total Equipment";
            // 
            // lblTotalEquipmentCost
            // 
            lblTotalEquipmentCost.AutoSize = true;
            lblTotalEquipmentCost.Location = new Point(142, 62);
            lblTotalEquipmentCost.Name = "lblTotalEquipmentCost";
            lblTotalEquipmentCost.Size = new Size(113, 20);
            lblTotalEquipmentCost.TabIndex = 3;
            lblTotalEquipmentCost.Text = "Total EquipCost";
            // 
            // lblNewMembersThisMonth
            // 
            lblNewMembersThisMonth.AutoSize = true;
            lblNewMembersThisMonth.Location = new Point(281, 0);
            lblNewMembersThisMonth.Name = "lblNewMembersThisMonth";
            lblNewMembersThisMonth.Size = new Size(80, 40);
            lblNewMembersThisMonth.TabIndex = 4;
            lblNewMembersThisMonth.Text = "Total New Member";
            // 
            // panel1
            // 
            panel1.Location = new Point(52, 229);
            panel1.Name = "panel1";
            panel1.Size = new Size(851, 393);
            panel1.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 89F));
            tableLayoutPanel1.Controls.Add(lblTotalMembers, 0, 0);
            tableLayoutPanel1.Controls.Add(lblTotalStaff, 1, 0);
            tableLayoutPanel1.Controls.Add(lblTotalEquipment, 0, 1);
            tableLayoutPanel1.Controls.Add(lblTotalEquipmentCost, 1, 1);
            tableLayoutPanel1.Controls.Add(lblNewMembersThisMonth, 2, 0);
            tableLayoutPanel1.Location = new Point(60, 30);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(367, 125);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // OverviewDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 644);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OverviewDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OverviewDashboardForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTotalMembers;
        private Label lblTotalStaff;
        private Label lblTotalEquipment;
        private Label lblTotalEquipmentCost;
        private Label lblNewMembersThisMonth;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}