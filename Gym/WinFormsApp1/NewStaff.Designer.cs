namespace WinFormsApp1
{
    partial class NewStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewStaff));
            txtFName = new TextBox();
            txtLName = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            dateTimePickerDOB = new DateTimePicker();
            txtMobile = new TextBox();
            txtEmail = new TextBox();
            dateTimePickerJoinDate = new DateTimePicker();
            txtState = new TextBox();
            txtCity = new TextBox();
            label9 = new Label();
            Mail = new Label();
            Mobile = new Label();
            label3 = new Label();
            LastName = new Label();
            FirstName = new Label();
            label10 = new Label();
            label1 = new Label();
            city_label = new Label();
            btnReset = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtFName
            // 
            txtFName.Location = new Point(155, 85);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(125, 27);
            txtFName.TabIndex = 0;
            txtFName.TextChanged += textBox1_TextChanged;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(155, 140);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(125, 27);
            txtLName.TabIndex = 1;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.Location = new Point(155, 200);
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
            radioButton2.Location = new Point(243, 201);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 24);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // dateTimePickerDOB
            // 
            dateTimePickerDOB.Format = DateTimePickerFormat.Short;
            dateTimePickerDOB.Location = new Point(168, 262);
            dateTimePickerDOB.Name = "dateTimePickerDOB";
            dateTimePickerDOB.Size = new Size(124, 27);
            dateTimePickerDOB.TabIndex = 4;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(155, 329);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(125, 27);
            txtMobile.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(481, 85);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 6;
            // 
            // dateTimePickerJoinDate
            // 
            dateTimePickerJoinDate.Format = DateTimePickerFormat.Short;
            dateTimePickerJoinDate.Location = new Point(481, 144);
            dateTimePickerJoinDate.Name = "dateTimePickerJoinDate";
            dateTimePickerJoinDate.Size = new Size(125, 27);
            dateTimePickerJoinDate.TabIndex = 7;
            // 
            // txtState
            // 
            txtState.Location = new Point(481, 201);
            txtState.Name = "txtState";
            txtState.Size = new Size(125, 27);
            txtState.TabIndex = 8;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(481, 266);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(125, 27);
            txtCity.TabIndex = 9;
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label9.Image = (Image)resources.GetObject("label9.Image");
            label9.ImageAlign = ContentAlignment.MiddleLeft;
            label9.Location = new Point(22, 266);
            label9.Name = "label9";
            label9.Size = new Size(140, 23);
            label9.TabIndex = 25;
            label9.Text = "Date of Birth";
            label9.TextAlign = ContentAlignment.TopRight;
            // 
            // Mail
            // 
            Mail.BackColor = Color.Transparent;
            Mail.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            Mail.Image = (Image)resources.GetObject("Mail.Image");
            Mail.ImageAlign = ContentAlignment.MiddleLeft;
            Mail.Location = new Point(372, 85);
            Mail.Name = "Mail";
            Mail.Size = new Size(86, 23);
            Mail.TabIndex = 24;
            Mail.Text = "Email";
            Mail.TextAlign = ContentAlignment.TopRight;
            // 
            // Mobile
            // 
            Mobile.BackColor = Color.Transparent;
            Mobile.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            Mobile.Image = (Image)resources.GetObject("Mobile.Image");
            Mobile.ImageAlign = ContentAlignment.MiddleLeft;
            Mobile.Location = new Point(26, 329);
            Mobile.Name = "Mobile";
            Mobile.Size = new Size(90, 23);
            Mobile.TabIndex = 23;
            Mobile.Text = "Mobile";
            Mobile.TextAlign = ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(22, 201);
            label3.Name = "label3";
            label3.Size = new Size(94, 23);
            label3.TabIndex = 22;
            label3.Text = "Gender";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // LastName
            // 
            LastName.BackColor = Color.Transparent;
            LastName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            LastName.Image = (Image)resources.GetObject("LastName.Image");
            LastName.ImageAlign = ContentAlignment.MiddleLeft;
            LastName.Location = new Point(22, 144);
            LastName.Name = "LastName";
            LastName.Size = new Size(115, 23);
            LastName.TabIndex = 21;
            LastName.Text = "Last Name";
            LastName.TextAlign = ContentAlignment.TopRight;
            // 
            // FirstName
            // 
            FirstName.BackColor = Color.Transparent;
            FirstName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            FirstName.Image = (Image)resources.GetObject("FirstName.Image");
            FirstName.ImageAlign = ContentAlignment.MiddleLeft;
            FirstName.Location = new Point(22, 89);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(126, 23);
            FirstName.TabIndex = 20;
            FirstName.Text = "First Name";
            FirstName.TextAlign = ContentAlignment.MiddleRight;
            FirstName.Click += FirstName_Click;
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label10.Image = (Image)resources.GetObject("label10.Image");
            label10.ImageAlign = ContentAlignment.MiddleLeft;
            label10.Location = new Point(365, 144);
            label10.Name = "label10";
            label10.Size = new Size(110, 23);
            label10.TabIndex = 26;
            label10.Text = "Join Date";
            label10.TextAlign = ContentAlignment.TopRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.Location = new Point(406, 201);
            label1.Name = "label1";
            label1.Size = new Size(52, 23);
            label1.TabIndex = 27;
            label1.Text = "State";
            // 
            // city_label
            // 
            city_label.AutoSize = true;
            city_label.BackColor = Color.Transparent;
            city_label.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            city_label.Location = new Point(406, 266);
            city_label.Name = "city_label";
            city_label.Size = new Size(42, 23);
            city_label.TabIndex = 28;
            city_label.Text = "City";
            // 
            // btnReset
            // 
            btnReset.Image = (Image)resources.GetObject("btnReset.Image");
            btnReset.ImageAlign = ContentAlignment.MiddleLeft;
            btnReset.Location = new Point(318, 434);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(81, 29);
            btnReset.TabIndex = 30;
            btnReset.Text = "Reset";
            btnReset.TextAlign = ContentAlignment.MiddleRight;
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnSave
            // 
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(199, 434);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(81, 29);
            btnSave.TabIndex = 29;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // NewStaff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(630, 484);
            Controls.Add(btnReset);
            Controls.Add(btnSave);
            Controls.Add(city_label);
            Controls.Add(label1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(Mail);
            Controls.Add(Mobile);
            Controls.Add(label3);
            Controls.Add(LastName);
            Controls.Add(FirstName);
            Controls.Add(txtCity);
            Controls.Add(txtState);
            Controls.Add(dateTimePickerJoinDate);
            Controls.Add(txtEmail);
            Controls.Add(txtMobile);
            Controls.Add(dateTimePickerDOB);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(txtLName);
            Controls.Add(txtFName);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NewStaff";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewStaff";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFName;
        private TextBox txtLName;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private DateTimePicker dateTimePickerDOB;
        private TextBox txtMobile;
        private TextBox txtEmail;
        private DateTimePicker dateTimePickerJoinDate;
        private TextBox txtState;
        private TextBox txtCity;
        private Label label9;
        private Label Mail;
        private Label Mobile;
        private Label label3;
        private Label LastName;
        private Label FirstName;
        private Label label10;
        private Label label1;
        private Label city_label;
        private Button btnReset;
        private Button btnSave;
    }
}