namespace WinFormsApp1
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            newMemberToolStripMenuItem = new ToolStripMenuItem();
            newStaffToolStripMenuItem = new ToolStripMenuItem();
            equipmentToolStripMenuItem = new ToolStripMenuItem();
            searchMemberToolStripMenuItem = new ToolStripMenuItem();
            deleteMemberToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            dashBoardToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, newMemberToolStripMenuItem, newStaffToolStripMenuItem, equipmentToolStripMenuItem, searchMemberToolStripMenuItem, deleteMemberToolStripMenuItem, logOutToolStripMenuItem, dashBoardToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1300, 58);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(14, 54);
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // newMemberToolStripMenuItem
            // 
            newMemberToolStripMenuItem.BackColor = Color.Silver;
            newMemberToolStripMenuItem.Image = (Image)resources.GetObject("newMemberToolStripMenuItem.Image");
            newMemberToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            newMemberToolStripMenuItem.Name = "newMemberToolStripMenuItem";
            newMemberToolStripMenuItem.Size = new Size(163, 54);
            newMemberToolStripMenuItem.Text = "New Member";
            newMemberToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // newStaffToolStripMenuItem
            // 
            newStaffToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            newStaffToolStripMenuItem.Image = (Image)resources.GetObject("newStaffToolStripMenuItem.Image");
            newStaffToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            newStaffToolStripMenuItem.Name = "newStaffToolStripMenuItem";
            newStaffToolStripMenuItem.Size = new Size(138, 54);
            newStaffToolStripMenuItem.Text = "New Staff";
            newStaffToolStripMenuItem.Click += newStaffToolStripMenuItem_Click;
            // 
            // equipmentToolStripMenuItem
            // 
            equipmentToolStripMenuItem.BackColor = Color.Silver;
            equipmentToolStripMenuItem.Image = (Image)resources.GetObject("equipmentToolStripMenuItem.Image");
            equipmentToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            equipmentToolStripMenuItem.Name = "equipmentToolStripMenuItem";
            equipmentToolStripMenuItem.Size = new Size(145, 54);
            equipmentToolStripMenuItem.Text = "Equipment";
            equipmentToolStripMenuItem.Click += equipmentToolStripMenuItem_Click;
            // 
            // searchMemberToolStripMenuItem
            // 
            searchMemberToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            searchMemberToolStripMenuItem.Image = (Image)resources.GetObject("searchMemberToolStripMenuItem.Image");
            searchMemberToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            searchMemberToolStripMenuItem.Name = "searchMemberToolStripMenuItem";
            searchMemberToolStripMenuItem.Size = new Size(177, 54);
            searchMemberToolStripMenuItem.Text = "Search Member";
            searchMemberToolStripMenuItem.Click += searchMemberToolStripMenuItem_Click;
            // 
            // deleteMemberToolStripMenuItem
            // 
            deleteMemberToolStripMenuItem.BackColor = Color.Silver;
            deleteMemberToolStripMenuItem.Image = (Image)resources.GetObject("deleteMemberToolStripMenuItem.Image");
            deleteMemberToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            deleteMemberToolStripMenuItem.Name = "deleteMemberToolStripMenuItem";
            deleteMemberToolStripMenuItem.Size = new Size(152, 54);
            deleteMemberToolStripMenuItem.Text = "Search Staff";
            deleteMemberToolStripMenuItem.Click += deleteMemberToolStripMenuItem_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            logOutToolStripMenuItem.Image = (Image)resources.GetObject("logOutToolStripMenuItem.Image");
            logOutToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(126, 54);
            logOutToolStripMenuItem.Text = "Log Out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.BackColor = Color.Silver;
            exitToolStripMenuItem.Image = (Image)resources.GetObject("exitToolStripMenuItem.Image");
            exitToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(72, 54);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // dashBoardToolStripMenuItem
            // 
            dashBoardToolStripMenuItem.BackColor = Color.FromArgb(128, 255, 255);
            dashBoardToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashBoardToolStripMenuItem.Name = "dashBoardToolStripMenuItem";
            dashBoardToolStripMenuItem.Size = new Size(107, 54);
            dashBoardToolStripMenuItem.Text = "DashBoard";
            dashBoardToolStripMenuItem.Click += dashBoardToolStripMenuItem_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1300, 690);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Home";
            Text = "Home";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem newMemberToolStripMenuItem;
        private ToolStripMenuItem newStaffToolStripMenuItem;
        private ToolStripMenuItem equipmentToolStripMenuItem;
        private ToolStripMenuItem searchMemberToolStripMenuItem;
        private ToolStripMenuItem deleteMemberToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem dashBoardToolStripMenuItem;
    }
}
