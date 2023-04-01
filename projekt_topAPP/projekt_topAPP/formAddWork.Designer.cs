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
            txtWorkName.Location = new Point(158, 57);
            txtWorkName.Name = "txtWorkName";
            txtWorkName.Size = new Size(173, 23);
            txtWorkName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(204, 25);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 1;
            label1.Text = "jméno práce";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(204, 128);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 2;
            label2.Text = "popis práce";
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
            btnAddWork.Location = new Point(195, 450);
            btnAddWork.Name = "btnAddWork";
            btnAddWork.Size = new Size(94, 39);
            btnAddWork.TabIndex = 4;
            btnAddWork.Text = "Přidej práci";
            btnAddWork.UseVisualStyleBackColor = true;
            btnAddWork.Click += btnAddWork_Click;
            // 
            // formAddWork
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 530);
            Controls.Add(btnAddWork);
            Controls.Add(txtWorkDescription);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtWorkName);
            Name = "formAddWork";
            Text = "AddWork";
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