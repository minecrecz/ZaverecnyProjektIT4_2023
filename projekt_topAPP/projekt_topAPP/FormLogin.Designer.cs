namespace projekt_topAPP
{
    partial class FormLogin
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
            label1 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            heslo = new Label();
            btnLogin = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(92, 134);
            label1.Name = "label1";
            label1.Size = new Size(145, 21);
            label1.TabIndex = 0;
            label1.Text = "Přihlašovací jméno";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(92, 158);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(145, 23);
            txtUsername.TabIndex = 1;
            txtUsername.TextChanged += TextBoxes_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(92, 250);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(145, 23);
            txtPassword.TabIndex = 2;
            txtPassword.TextChanged += TextBoxes_TextChanged;
            // 
            // heslo
            // 
            heslo.AutoSize = true;
            heslo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            heslo.Location = new Point(136, 226);
            heslo.Name = "heslo";
            heslo.Size = new Size(52, 21);
            heslo.TabIndex = 3;
            heslo.Text = "Heslo";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.OrangeRed;
            btnLogin.Enabled = false;
            btnLogin.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(110, 297);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(98, 34);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Přihlásit";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.OrangeRed;
            label2.Location = new Point(105, 32);
            label2.Name = "label2";
            label2.Size = new Size(103, 32);
            label2.TabIndex = 5;
            label2.Text = "TopAPP";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(125, 64);
            label3.Name = "label3";
            label3.Size = new Size(72, 13);
            label3.TabIndex = 6;
            label3.Text = "Work system";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(325, 378);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnLogin);
            Controls.Add(heslo);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label heslo;
        private Button btnLogin;
        private Label label2;
        private Label label3;
    }
}