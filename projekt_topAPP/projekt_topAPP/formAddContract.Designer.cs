namespace projekt_topAPP
{
    partial class formAddContract
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
            label1 = new Label();
            label2 = new Label();
            txtAddConctractName = new TextBox();
            txtAddDescription = new TextBox();
            btnAddContract = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(61, 51);
            label1.Name = "label1";
            label1.Size = new Size(116, 21);
            label1.TabIndex = 0;
            label1.Text = "Jméno zakázky";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(61, 146);
            label2.Name = "label2";
            label2.Size = new Size(107, 21);
            label2.TabIndex = 1;
            label2.Text = "Popis zakázky";
            // 
            // txtAddConctractName
            // 
            txtAddConctractName.Location = new Point(40, 84);
            txtAddConctractName.Name = "txtAddConctractName";
            txtAddConctractName.Size = new Size(156, 23);
            txtAddConctractName.TabIndex = 2;
            // 
            // txtAddDescription
            // 
            txtAddDescription.Location = new Point(12, 181);
            txtAddDescription.Multiline = true;
            txtAddDescription.Name = "txtAddDescription";
            txtAddDescription.Size = new Size(214, 127);
            txtAddDescription.TabIndex = 3;
            // 
            // btnAddContract
            // 
            btnAddContract.BackColor = Color.OrangeRed;
            btnAddContract.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddContract.Location = new Point(77, 314);
            btnAddContract.Name = "btnAddContract";
            btnAddContract.Size = new Size(82, 40);
            btnAddContract.TabIndex = 4;
            btnAddContract.Text = "Přidat";
            btnAddContract.UseVisualStyleBackColor = false;
            btnAddContract.Click += btnAddContract_Click;
            // 
            // formAddContract
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(238, 381);
            Controls.Add(btnAddContract);
            Controls.Add(txtAddDescription);
            Controls.Add(txtAddConctractName);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "formAddContract";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Přidání zakázky";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtAddConctractName;
        private TextBox txtAddDescription;
        private Button btnAddContract;
    }
}