namespace GymManagement
{
    partial class SearchStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchStaff));
            label1 = new Label();
            txtSearch = new TextBox();
            dataGridView1 = new DataGridView();
            btnSearch = new Button();
            btnViewStaffs = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 71);
            label1.Name = "label1";
            label1.Size = new Size(160, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter Staff ID or Phone";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(236, 64);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(316, 27);
            txtSearch.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 150);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(622, 322);
            dataGridView1.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.GradientInactiveCaption;
            btnSearch.Location = new Point(49, 114);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnViewStaffs
            // 
            btnViewStaffs.BackColor = SystemColors.GradientInactiveCaption;
            btnViewStaffs.Location = new Point(174, 114);
            btnViewStaffs.Name = "btnViewStaffs";
            btnViewStaffs.Size = new Size(139, 29);
            btnViewStaffs.TabIndex = 4;
            btnViewStaffs.Text = "View All Staffs";
            btnViewStaffs.UseVisualStyleBackColor = false;
            btnViewStaffs.Click += btnViewStaffs_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.GradientInactiveCaption;
            btnUpdate.Location = new Point(367, 114);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.GradientInactiveCaption;
            btnDelete.Location = new Point(498, 114);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // SearchStaff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(630, 484);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnViewStaffs);
            Controls.Add(btnSearch);
            Controls.Add(dataGridView1);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SearchStaff";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SearchStaff";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearch;
        private DataGridView dataGridView1;
        private Button btnSearch;
        private Button btnViewStaffs;
        private Button btnUpdate;
        private Button btnDelete;
    }
}