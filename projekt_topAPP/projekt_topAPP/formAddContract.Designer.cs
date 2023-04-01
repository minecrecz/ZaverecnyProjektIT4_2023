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
            label1.Location = new Point(77, 56);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "jméno zakázky";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 150);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 1;
            label2.Text = "popis zakázky";
            // 
            // txtAddConctractName
            // 
            txtAddConctractName.Location = new Point(70, 85);
            txtAddConctractName.Name = "txtAddConctractName";
            txtAddConctractName.Size = new Size(100, 23);
            txtAddConctractName.TabIndex = 2;
            // 
            // txtAddDescription
            // 
            txtAddDescription.Location = new Point(42, 178);
            txtAddDescription.Name = "txtAddDescription";
            txtAddDescription.Size = new Size(100, 23);
            txtAddDescription.TabIndex = 3;
            // 
            // btnAddContract
            // 
            btnAddContract.Location = new Point(80, 247);
            btnAddContract.Name = "btnAddContract";
            btnAddContract.Size = new Size(75, 23);
            btnAddContract.TabIndex = 4;
            btnAddContract.Text = "button1";
            btnAddContract.UseVisualStyleBackColor = true;
            btnAddContract.Click += btnAddContract_Click;
            // 
            // formAddContract
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(238, 381);
            Controls.Add(btnAddContract);
            Controls.Add(txtAddDescription);
            Controls.Add(txtAddConctractName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formAddContract";
            Text = "AddContact";
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