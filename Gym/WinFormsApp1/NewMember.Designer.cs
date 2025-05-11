namespace WinFormsApp1
{
    partial class NewMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMember));
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            dateTimePickerDOB = new DateTimePicker();
            txtMobile = new TextBox();
            txtEmail = new TextBox();
            dateTimePickerJoinDate = new DateTimePicker();
            txtAddress = new RichTextBox();
            FirstName = new Label();
            LastName = new Label();
            label3 = new Label();
            Mobile = new Label();
            Mail = new Label();
            label6 = new Label();
            label7 = new Label();
            Address = new Label();
            label9 = new Label();
            btnSave = new Button();
            btnReset = new Button();
            label10 = new Label();
            comboBoxGymTime = new ComboBox();
            comboBoxMembershipTime = new ComboBox();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(147, 32);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(125, 27);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(147, 115);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(125, 27);
            txtLastName.TabIndex = 1;
            txtLastName.TextChanged += textBox2_TextChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.Location = new Point(147, 191);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 24);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Transparent;
            radioButton2.Location = new Point(216, 191);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 24);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = false;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // dateTimePickerDOB
            // 
            dateTimePickerDOB.Format = DateTimePickerFormat.Short;
            dateTimePickerDOB.Location = new Point(147, 252);
            dateTimePickerDOB.Name = "dateTimePickerDOB";
            dateTimePickerDOB.Size = new Size(121, 27);
            dateTimePickerDOB.TabIndex = 4;
            dateTimePickerDOB.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(118, 337);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(125, 27);
            txtMobile.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(457, 24);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 6;
            // 
            // dateTimePickerJoinDate
            // 
            dateTimePickerJoinDate.Format = DateTimePickerFormat.Short;
            dateTimePickerJoinDate.Location = new Point(457, 89);
            dateTimePickerJoinDate.Name = "dateTimePickerJoinDate";
            dateTimePickerJoinDate.Size = new Size(101, 27);
            dateTimePickerJoinDate.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(457, 223);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(125, 120);
            txtAddress.TabIndex = 9;
            txtAddress.Text = "";
            // 
            // FirstName
            // 
            FirstName.BackColor = Color.Transparent;
            FirstName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            FirstName.Image = (Image)resources.GetObject("FirstName.Image");
            FirstName.ImageAlign = ContentAlignment.MiddleLeft;
            FirstName.Location = new Point(1, 32);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(126, 23);
            FirstName.TabIndex = 11;
            FirstName.Text = "First Name";
            FirstName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LastName
            // 
            LastName.BackColor = Color.Transparent;
            LastName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            LastName.Image = (Image)resources.GetObject("LastName.Image");
            LastName.ImageAlign = ContentAlignment.MiddleLeft;
            LastName.Location = new Point(1, 119);
            LastName.Name = "LastName";
            LastName.Size = new Size(115, 23);
            LastName.TabIndex = 12;
            LastName.Text = "Last Name";
            LastName.TextAlign = ContentAlignment.TopRight;
            LastName.Click += label2_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(12, 192);
            label3.Name = "label3";
            label3.Size = new Size(94, 23);
            label3.TabIndex = 13;
            label3.Text = "Gender";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // Mobile
            // 
            Mobile.BackColor = Color.Transparent;
            Mobile.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            Mobile.Image = (Image)resources.GetObject("Mobile.Image");
            Mobile.ImageAlign = ContentAlignment.MiddleLeft;
            Mobile.Location = new Point(22, 340);
            Mobile.Name = "Mobile";
            Mobile.Size = new Size(90, 23);
            Mobile.TabIndex = 14;
            Mobile.Text = "Mobile";
            Mobile.TextAlign = ContentAlignment.TopRight;
            // 
            // Mail
            // 
            Mail.BackColor = Color.Transparent;
            Mail.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            Mail.Image = (Image)resources.GetObject("Mail.Image");
            Mail.ImageAlign = ContentAlignment.MiddleLeft;
            Mail.Location = new Point(365, 25);
            Mail.Name = "Mail";
            Mail.Size = new Size(86, 23);
            Mail.TabIndex = 15;
            Mail.Text = "Email";
            Mail.TextAlign = ContentAlignment.TopRight;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label6.Image = (Image)resources.GetObject("label6.Image");
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(335, 150);
            label6.Name = "label6";
            label6.Size = new Size(116, 23);
            label6.TabIndex = 16;
            label6.Text = "Gym Time";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label7.Image = (Image)resources.GetObject("label7.Image");
            label7.ImageAlign = ContentAlignment.MiddleLeft;
            label7.Location = new Point(130, 401);
            label7.Name = "label7";
            label7.Size = new Size(185, 23);
            label7.TabIndex = 17;
            label7.Text = "Membership Time";
            label7.TextAlign = ContentAlignment.TopRight;
            // 
            // Address
            // 
            Address.BackColor = Color.Transparent;
            Address.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            Address.Image = (Image)resources.GetObject("Address.Image");
            Address.ImageAlign = ContentAlignment.MiddleLeft;
            Address.Location = new Point(341, 256);
            Address.Name = "Address";
            Address.Size = new Size(110, 23);
            Address.TabIndex = 18;
            Address.Text = "Address";
            Address.TextAlign = ContentAlignment.TopRight;
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label9.Image = (Image)resources.GetObject("label9.Image");
            label9.ImageAlign = ContentAlignment.MiddleLeft;
            label9.Location = new Point(1, 256);
            label9.Name = "label9";
            label9.Size = new Size(140, 23);
            label9.TabIndex = 19;
            label9.Text = "Date of Birth";
            label9.TextAlign = ContentAlignment.TopRight;
            // 
            // btnSave
            // 
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(216, 443);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(81, 29);
            btnSave.TabIndex = 20;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnReset
            // 
            btnReset.Image = (Image)resources.GetObject("btnReset.Image");
            btnReset.ImageAlign = ContentAlignment.MiddleLeft;
            btnReset.Location = new Point(335, 443);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(81, 29);
            btnReset.TabIndex = 21;
            btnReset.Text = "Reset";
            btnReset.TextAlign = ContentAlignment.MiddleRight;
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label10.Image = (Image)resources.GetObject("label10.Image");
            label10.ImageAlign = ContentAlignment.MiddleLeft;
            label10.Location = new Point(341, 89);
            label10.Name = "label10";
            label10.Size = new Size(110, 23);
            label10.TabIndex = 22;
            label10.Text = "Join Date";
            label10.TextAlign = ContentAlignment.TopRight;
            // 
            // comboBoxGymTime
            // 
            comboBoxGymTime.FormattingEnabled = true;
            comboBoxGymTime.Items.AddRange(new object[] { "6AM-7AM", "7AM-8AM", "8AM-9AM", "5PM-6PM", "6PM-7PM" });
            comboBoxGymTime.Location = new Point(457, 149);
            comboBoxGymTime.Name = "comboBoxGymTime";
            comboBoxGymTime.Size = new Size(151, 28);
            comboBoxGymTime.TabIndex = 23;
            // 
            // comboBoxMembershipTime
            // 
            comboBoxMembershipTime.FormattingEnabled = true;
            comboBoxMembershipTime.Items.AddRange(new object[] { "1 Month", "2 Months", "3 Months", "6 Months", "12 Months" });
            comboBoxMembershipTime.Location = new Point(321, 396);
            comboBoxMembershipTime.Name = "comboBoxMembershipTime";
            comboBoxMembershipTime.Size = new Size(151, 28);
            comboBoxMembershipTime.TabIndex = 24;
            // 
            // NewMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(630, 484);
            Controls.Add(comboBoxMembershipTime);
            Controls.Add(comboBoxGymTime);
            Controls.Add(label10);
            Controls.Add(btnReset);
            Controls.Add(btnSave);
            Controls.Add(label9);
            Controls.Add(Address);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(Mail);
            Controls.Add(Mobile);
            Controls.Add(label3);
            Controls.Add(LastName);
            Controls.Add(FirstName);
            Controls.Add(txtAddress);
            Controls.Add(dateTimePickerJoinDate);
            Controls.Add(txtEmail);
            Controls.Add(txtMobile);
            Controls.Add(dateTimePickerDOB);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NewMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewMember";
            Load += NewMember_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private TextBox txtLastName;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private DateTimePicker dateTimePickerDOB;
        private TextBox txtMobile;
        private TextBox txtEmail;
        private DateTimePicker dateTimePickerJoinDate;
        private RichTextBox txtAddress;
        private Label FirstName;
        private Label LastName;
        private Label label3;
        private Label Mobile;
        private Label Mail;
        private Label label6;
        private Label label7;
        private Label Address;
        private Label label9;
        private Button btnSave;
        private Button btnReset;
        private Label label10;
        private ComboBox comboBoxGymTime;
        private ComboBox comboBoxMembershipTime;
    }
}