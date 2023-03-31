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
            txtBirthDay = new TextBox();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 37);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Jméno";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(204, 37);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Přijmení";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(343, 37);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(495, 37);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 4;
            label5.Text = "Telefoní číslo";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(54, 74);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(111, 23);
            txtFirstName.TabIndex = 6;
            // 
            // txtForeName
            // 
            txtForeName.Location = new Point(190, 74);
            txtForeName.Name = "txtForeName";
            txtForeName.Size = new Size(102, 23);
            txtForeName.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(309, 74);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(146, 23);
            txtEmail.TabIndex = 8;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(476, 74);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(154, 23);
            txtNumber.TabIndex = 9;
            // 
            // txtBirthDay
            // 
            txtBirthDay.Location = new Point(645, 74);
            txtBirthDay.Name = "txtBirthDay";
            txtBirthDay.Size = new Size(108, 23);
            txtBirthDay.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Location = new Point(645, 37);
            label6.Name = "label6";
            label6.Size = new Size(91, 15);
            label6.TabIndex = 11;
            label6.Text = "Datum narození";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(655, 58);
            label7.Name = "label7";
            label7.Size = new Size(85, 13);
            label7.TabIndex = 12;
            label7.Text = "(DD/MM/RRRR)";
            // 
            // button1
            // 
            button1.Location = new Point(322, 131);
            button1.Name = "button1";
            button1.Size = new Size(144, 37);
            button1.TabIndex = 13;
            button1.Text = "Přidat";
            button1.UseVisualStyleBackColor = true;
            // 
            // formAddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 180);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtBirthDay);
            Controls.Add(txtNumber);
            Controls.Add(txtEmail);
            Controls.Add(txtForeName);
            Controls.Add(txtFirstName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "formAddEmployee";
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
        private TextBox txtBirthDay;
        private Label label6;
        private Label label7;
        private Button button1;
    }
}