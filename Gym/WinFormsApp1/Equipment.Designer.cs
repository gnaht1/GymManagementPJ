namespace WinFormsApp1
{
    partial class Equipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equipment));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtEquipName = new TextBox();
            txtMucleUsed = new TextBox();
            txtDsc = new RichTextBox();
            dateTimePickerDeliveryDate = new DateTimePicker();
            btnSave = new Button();
            btnReset = new Button();
            btnViewEq = new Button();
            txtCost = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(64, 55);
            label1.Name = "label1";
            label1.Size = new Size(150, 23);
            label1.TabIndex = 0;
            label1.Text = "Equipment Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(64, 114);
            label2.Name = "label2";
            label2.Size = new Size(102, 23);
            label2.TabIndex = 1;
            label2.Text = "Description";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(64, 262);
            label3.Name = "label3";
            label3.Size = new Size(109, 23);
            label3.TabIndex = 2;
            label3.Text = "Muscle Used";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(64, 324);
            label4.Name = "label4";
            label4.Size = new Size(120, 23);
            label4.TabIndex = 3;
            label4.Text = "Delivery Date";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(64, 381);
            label5.Name = "label5";
            label5.Size = new Size(45, 23);
            label5.TabIndex = 4;
            label5.Text = "Cost";
            label5.Click += label5_Click;
            // 
            // txtEquipName
            // 
            txtEquipName.Location = new Point(262, 55);
            txtEquipName.Name = "txtEquipName";
            txtEquipName.Size = new Size(125, 27);
            txtEquipName.TabIndex = 6;
            // 
            // txtMucleUsed
            // 
            txtMucleUsed.Location = new Point(262, 262);
            txtMucleUsed.Name = "txtMucleUsed";
            txtMucleUsed.Size = new Size(125, 27);
            txtMucleUsed.TabIndex = 7;
            // 
            // txtDsc
            // 
            txtDsc.Location = new Point(262, 111);
            txtDsc.Name = "txtDsc";
            txtDsc.Size = new Size(125, 120);
            txtDsc.TabIndex = 8;
            txtDsc.Text = "";
            // 
            // dateTimePickerDeliveryDate
            // 
            dateTimePickerDeliveryDate.Format = DateTimePickerFormat.Short;
            dateTimePickerDeliveryDate.Location = new Point(262, 324);
            dateTimePickerDeliveryDate.Name = "dateTimePickerDeliveryDate";
            dateTimePickerDeliveryDate.Size = new Size(125, 27);
            dateTimePickerDeliveryDate.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(164, 433);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(293, 433);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 11;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnViewEq
            // 
            btnViewEq.Location = new Point(422, 433);
            btnViewEq.Name = "btnViewEq";
            btnViewEq.Size = new Size(135, 29);
            btnViewEq.TabIndex = 12;
            btnViewEq.Text = "View Equipments";
            btnViewEq.UseVisualStyleBackColor = true;
            btnViewEq.Click += btnViewEq_Click;
            // 
            // txtCost
            // 
            txtCost.Location = new Point(262, 381);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(125, 27);
            txtCost.TabIndex = 13;
            // 
            // Equipment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(630, 484);
            Controls.Add(txtCost);
            Controls.Add(btnViewEq);
            Controls.Add(btnReset);
            Controls.Add(btnSave);
            Controls.Add(dateTimePickerDeliveryDate);
            Controls.Add(txtDsc);
            Controls.Add(txtMucleUsed);
            Controls.Add(txtEquipName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Equipment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Equipment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtEquipName;
        private TextBox txtMucleUsed;
        private RichTextBox txtDsc;
        private DateTimePicker dateTimePickerDeliveryDate;
        private Button btnSave;
        private Button btnReset;
        private Button button1;
        private Button button2;
        private Button btnViewEq;
        private TextBox txtCost;
    }
}