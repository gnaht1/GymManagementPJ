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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            textBox5 = new TextBox();
            richTextBox1 = new RichTextBox();
            textBox6 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(118, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(118, 119);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(118, 192);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 24);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(220, 192);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 24);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(122, 256);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(121, 27);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(118, 337);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(457, 24);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(377, 91);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(457, 154);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 8;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(457, 223);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(125, 120);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(457, 406);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 32);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 11;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 122);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 12;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 196);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 13;
            label3.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 340);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 14;
            label4.Text = "Mobile";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(377, 27);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 15;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(377, 154);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 16;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(377, 406);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 17;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(377, 271);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 18;
            label8.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 261);
            label9.Name = "label9";
            label9.Size = new Size(94, 20);
            label9.TabIndex = 19;
            label9.Text = "Date of Birth";
            // 
            // button1
            // 
            button1.Location = new Point(194, 453);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 20;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(343, 453);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 21;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // NewMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(630, 484);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox6);
            Controls.Add(richTextBox1);
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
            Name = "NewMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewMember";
            Load += NewMember_Load;
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
        private RichTextBox richTextBox1;
        private TextBox textBox6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button button1;
        private Button button2;
    }
}