namespace projekt_topAPP
{
    partial class formAddEmployee
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtFirstName = new TextBox();
            txtForeName = new TextBox();
            txtEmail = new TextBox();
            txtNumber = new TextBox();
            label6 = new Label();
            button1 = new Button();
            dateBirthDay = new DateTimePicker();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(117, 46);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 1;
            label2.Text = "Jméno";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(111, 125);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 2;
            label3.Text = "Přijmení";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(117, 211);
            label4.Name = "label4";
            label4.Size = new Size(48, 21);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(96, 275);
            label5.Name = "label5";
            label5.Size = new Size(105, 21);
            label5.TabIndex = 4;
            label5.Text = "Telefoní číslo";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(44, 79);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(200, 23);
            txtFirstName.TabIndex = 6;
            // 
            // txtForeName
            // 
            txtForeName.Location = new Point(44, 163);
            txtForeName.Name = "txtForeName";
            txtForeName.Size = new Size(200, 23);
            txtForeName.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(44, 235);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 8;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(44, 299);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(200, 23);
            txtNumber.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(90, 331);
            label6.Name = "label6";
            label6.Size = new Size(124, 21);
            label6.TabIndex = 11;
            label6.Text = "Datum narození";
            // 
            // button1
            // 
            button1.BackColor = Color.OrangeRed;
            button1.Location = new Point(90, 422);
            button1.Name = "button1";
            button1.Size = new Size(124, 37);
            button1.TabIndex = 13;
            button1.Text = "Přidat";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dateBirthDay
            // 
            dateBirthDay.Location = new Point(44, 355);
            dateBirthDay.Name = "dateBirthDay";
            dateBirthDay.Size = new Size(200, 23);
            dateBirthDay.TabIndex = 14;
            // 
            // formAddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(285, 493);
            Controls.Add(dateBirthDay);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(txtNumber);
            Controls.Add(txtEmail);
            Controls.Add(txtForeName);
            Controls.Add(txtFirstName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "formAddEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Přidání zaměstnance";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtFirstName;
        private TextBox txtForeName;
        private TextBox txtEmail;
        private TextBox txtNumber;
        private Label label6;
        private Button button1;
        private DateTimePicker dateBirthDay;
    }
}