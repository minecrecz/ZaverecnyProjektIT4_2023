namespace projekt_topAPP
{
    partial class formAddWork
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
            txtWorkName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtWorkDescription = new TextBox();
            btnAddWork = new Button();
            SuspendLayout();
            // 
            // txtWorkName
            // 
            txtWorkName.Location = new Point(158, 67);
            txtWorkName.Name = "txtWorkName";
            txtWorkName.Size = new Size(173, 23);
            txtWorkName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(195, 43);
            label1.Name = "label1";
            label1.Size = new Size(103, 21);
            label1.TabIndex = 1;
            label1.Text = "Jméno práce";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(195, 135);
            label2.Name = "label2";
            label2.Size = new Size(94, 21);
            label2.TabIndex = 2;
            label2.Text = "Popis práce";
            // 
            // txtWorkDescription
            // 
            txtWorkDescription.Location = new Point(65, 168);
            txtWorkDescription.Multiline = true;
            txtWorkDescription.Name = "txtWorkDescription";
            txtWorkDescription.Size = new Size(370, 260);
            txtWorkDescription.TabIndex = 3;
            // 
            // btnAddWork
            // 
            btnAddWork.BackColor = Color.OrangeRed;
            btnAddWork.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddWork.Location = new Point(195, 450);
            btnAddWork.Name = "btnAddWork";
            btnAddWork.Size = new Size(94, 39);
            btnAddWork.TabIndex = 4;
            btnAddWork.Text = "Přidat";
            btnAddWork.UseVisualStyleBackColor = false;
            btnAddWork.Click += btnAddWork_Click;
            // 
            // formAddWork
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(478, 530);
            Controls.Add(btnAddWork);
            Controls.Add(txtWorkDescription);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtWorkName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "formAddWork";
            Text = "Přidání práce";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtWorkName;
        private Label label1;
        private Label label2;
        private TextBox txtWorkDescription;
        private Button btnAddWork;
    }
}