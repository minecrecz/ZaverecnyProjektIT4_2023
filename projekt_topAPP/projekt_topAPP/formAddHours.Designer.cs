namespace projekt_topAPP
{
    partial class formAddHours
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
            lbl = new Label();
            label3 = new Label();
            label4 = new Label();
            txtEmployeeName = new TextBox();
            txtContractName = new TextBox();
            txtWorkType = new TextBox();
            btnAddHours = new Button();
            txtWorkHours = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)txtWorkHours).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(181, 48);
            label1.Name = "label1";
            label1.Size = new Size(156, 21);
            label1.TabIndex = 0;
            label1.Text = "Jméno zaměstnance";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl.Location = new Point(190, 163);
            lbl.Name = "lbl";
            lbl.Size = new Size(116, 21);
            lbl.TabIndex = 1;
            lbl.Text = "Jméno zakázky";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(198, 260);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 2;
            label3.Text = "Typ práce";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(198, 369);
            label4.Name = "label4";
            label4.Size = new Size(94, 21);
            label4.TabIndex = 3;
            label4.Text = "Doba práce";
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(154, 89);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(194, 23);
            txtEmployeeName.TabIndex = 4;
            // 
            // txtContractName
            // 
            txtContractName.Location = new Point(154, 203);
            txtContractName.Name = "txtContractName";
            txtContractName.Size = new Size(194, 23);
            txtContractName.TabIndex = 5;
            // 
            // txtWorkType
            // 
            txtWorkType.Location = new Point(154, 305);
            txtWorkType.Name = "txtWorkType";
            txtWorkType.Size = new Size(194, 23);
            txtWorkType.TabIndex = 6;
            // 
            // btnAddHours
            // 
            btnAddHours.BackColor = Color.OrangeRed;
            btnAddHours.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddHours.Location = new Point(190, 488);
            btnAddHours.Name = "btnAddHours";
            btnAddHours.Size = new Size(123, 39);
            btnAddHours.TabIndex = 8;
            btnAddHours.Text = "přidat";
            btnAddHours.UseVisualStyleBackColor = false;
            btnAddHours.Click += btnAddHours_Click;
            // 
            // txtWorkHours
            // 
            txtWorkHours.Location = new Point(155, 427);
            txtWorkHours.Name = "txtWorkHours";
            txtWorkHours.Size = new Size(193, 23);
            txtWorkHours.TabIndex = 9;
            // 
            // formAddHours
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(492, 585);
            Controls.Add(txtWorkHours);
            Controls.Add(btnAddHours);
            Controls.Add(txtWorkType);
            Controls.Add(txtContractName);
            Controls.Add(txtEmployeeName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbl);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "formAddHours";
            Text = "přidání odpracovaných hodin";
            ((System.ComponentModel.ISupportInitialize)txtWorkHours).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl;
        private Label label3;
        private Label label4;
        private TextBox txtEmployeeName;
        private TextBox txtContractName;
        private TextBox txtWorkType;
        private Button btnAddHours;
        private NumericUpDown txtWorkHours;
    }
}