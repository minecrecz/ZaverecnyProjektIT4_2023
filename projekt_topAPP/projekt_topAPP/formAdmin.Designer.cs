namespace projekt_topAPP
{
    partial class formAdmin
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
            listViewEmployee = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            btnEmployeeDelete = new Button();
            btnAddEmployeeForm = new Button();
            listViewContract = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            btnDeleteContract = new Button();
            SuspendLayout();
            // 
            // listViewEmployee
            // 
            listViewEmployee.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listViewEmployee.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            listViewEmployee.FullRowSelect = true;
            listViewEmployee.GridLines = true;
            listViewEmployee.Location = new Point(12, 586);
            listViewEmployee.Name = "listViewEmployee";
            listViewEmployee.Size = new Size(506, 379);
            listViewEmployee.TabIndex = 0;
            listViewEmployee.UseCompatibleStateImageBehavior = false;
            listViewEmployee.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Jméno";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Příjmení";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Datum narození";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Email";
            columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Telefoní číslo";
            columnHeader6.Width = 100;
            // 
            // btnEmployeeDelete
            // 
            btnEmployeeDelete.Location = new Point(12, 557);
            btnEmployeeDelete.Name = "btnEmployeeDelete";
            btnEmployeeDelete.Size = new Size(134, 23);
            btnEmployeeDelete.TabIndex = 1;
            btnEmployeeDelete.Text = "mazání zaměstnance";
            btnEmployeeDelete.UseVisualStyleBackColor = true;
            btnEmployeeDelete.Click += btnEmployeeDelete_Click;
            // 
            // btnAddEmployeeForm
            // 
            btnAddEmployeeForm.Location = new Point(180, 557);
            btnAddEmployeeForm.Name = "btnAddEmployeeForm";
            btnAddEmployeeForm.Size = new Size(204, 23);
            btnAddEmployeeForm.TabIndex = 2;
            btnAddEmployeeForm.Text = "přídání/upravení zaměstnanců";
            btnAddEmployeeForm.UseVisualStyleBackColor = true;
            btnAddEmployeeForm.Click += btnAddEmployeeForm_Click;
            // 
            // listViewContract
            // 
            listViewContract.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader8, columnHeader9 });
            listViewContract.FullRowSelect = true;
            listViewContract.GridLines = true;
            listViewContract.Location = new Point(574, 587);
            listViewContract.Name = "listViewContract";
            listViewContract.Size = new Size(334, 378);
            listViewContract.TabIndex = 3;
            listViewContract.UseCompatibleStateImageBehavior = false;
            listViewContract.View = View.Details;
            listViewContract.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "ID zakázky";
            columnHeader7.Width = 90;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "zákazník";
            columnHeader8.Width = 90;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Popis";
            columnHeader9.Width = 150;
            // 
            // btnDeleteContract
            // 
            btnDeleteContract.Location = new Point(574, 557);
            btnDeleteContract.Name = "btnDeleteContract";
            btnDeleteContract.Size = new Size(114, 23);
            btnDeleteContract.TabIndex = 4;
            btnDeleteContract.Text = "mazání zakázek";
            btnDeleteContract.UseVisualStyleBackColor = true;
            btnDeleteContract.Click += btnDeleteContract_Click;
            // 
            // formAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(1563, 977);
            Controls.Add(btnDeleteContract);
            Controls.Add(listViewContract);
            Controls.Add(btnAddEmployeeForm);
            Controls.Add(btnEmployeeDelete);
            Controls.Add(listViewEmployee);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "formAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formAdmin";
            Load += formAdmin_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewEmployee;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button btnEmployeeDelete;
        private Button btnAddEmployeeForm;
        private ListView listViewContract;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private Button btnDeleteContract;
    }
}