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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label9 = new Label();
            Mail = new Label();
            Mobile = new Label();
            label3 = new Label();
            LastName = new Label();
            FirstName = new Label();
            label10 = new Label();
            label1 = new Label();
            label2 = new Label();
            btnReset = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(155, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(155, 140);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
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
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(168, 262);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(124, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(155, 329);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(481, 85);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(481, 144);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(125, 27);
            dateTimePicker2.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(481, 201);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 8;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(481, 266);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 9;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(406, 266);
            label2.Name = "label2";
            label2.Size = new Size(42, 23);
            label2.TabIndex = 28;
            label2.Text = "City";
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
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(Mail);
            Controls.Add(Mobile);
            Controls.Add(label3);
            Controls.Add(LastName);
            Controls.Add(FirstName);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(dateTimePicker2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(dateTimePicker1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NewStaff";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewStaff";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox3;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker2;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label9;
        private Label Mail;
        private Label Mobile;
        private Label label3;
        private Label LastName;
        private Label FirstName;
        private Label label10;
        private Label label1;
        private Label label2;
        private Button btnReset;
        private Button btnSave;
    }
}