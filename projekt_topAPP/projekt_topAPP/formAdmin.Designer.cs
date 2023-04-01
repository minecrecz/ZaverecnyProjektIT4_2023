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
            button1 = new Button();
            listViewUsers = new ListView();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            btnUserDelete = new Button();
            btnAddUser = new Button();
            listViewWork = new ListView();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            button2 = new Button();
            btnAddWork = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            listViewHours = new ListView();
            columnHeader16 = new ColumnHeader();
            columnHeader17 = new ColumnHeader();
            columnHeader18 = new ColumnHeader();
            columnHeader19 = new ColumnHeader();
            columnHeader20 = new ColumnHeader();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // listViewEmployee
            // 
            listViewEmployee.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listViewEmployee.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            listViewEmployee.FullRowSelect = true;
            listViewEmployee.GridLines = true;
            listViewEmployee.Location = new Point(12, 586);
            listViewEmployee.MultiSelect = false;
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
            btnEmployeeDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmployeeDelete.Location = new Point(12, 557);
            btnEmployeeDelete.Name = "btnEmployeeDelete";
            btnEmployeeDelete.Size = new Size(134, 23);
            btnEmployeeDelete.TabIndex = 1;
            btnEmployeeDelete.Text = "Mazání zaměstnance";
            btnEmployeeDelete.UseVisualStyleBackColor = true;
            btnEmployeeDelete.Click += btnEmployeeDelete_Click;
            // 
            // btnAddEmployeeForm
            // 
            btnAddEmployeeForm.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddEmployeeForm.Location = new Point(314, 557);
            btnAddEmployeeForm.Name = "btnAddEmployeeForm";
            btnAddEmployeeForm.Size = new Size(204, 23);
            btnAddEmployeeForm.TabIndex = 2;
            btnAddEmployeeForm.Text = "Přídání zaměstnanců";
            btnAddEmployeeForm.UseVisualStyleBackColor = true;
            btnAddEmployeeForm.Click += btnAddEmployeeForm_Click;
            // 
            // listViewContract
            // 
            listViewContract.BackColor = Color.White;
            listViewContract.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader8, columnHeader9 });
            listViewContract.FullRowSelect = true;
            listViewContract.GridLines = true;
            listViewContract.Location = new Point(574, 587);
            listViewContract.MultiSelect = false;
            listViewContract.Name = "listViewContract";
            listViewContract.Size = new Size(386, 378);
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
            columnHeader9.Width = 200;
            // 
            // btnDeleteContract
            // 
            btnDeleteContract.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteContract.Location = new Point(574, 557);
            btnDeleteContract.Name = "btnDeleteContract";
            btnDeleteContract.Size = new Size(114, 23);
            btnDeleteContract.TabIndex = 4;
            btnDeleteContract.Text = "Mazání zakázek";
            btnDeleteContract.UseVisualStyleBackColor = true;
            btnDeleteContract.Click += btnDeleteContract_Click;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(806, 558);
            button1.Name = "button1";
            button1.Size = new Size(154, 23);
            button1.TabIndex = 5;
            button1.Text = "Přidání zakázek";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listViewUsers
            // 
            listViewUsers.Columns.AddRange(new ColumnHeader[] { columnHeader10, columnHeader11, columnHeader12 });
            listViewUsers.FullRowSelect = true;
            listViewUsers.GridLines = true;
            listViewUsers.Location = new Point(12, 121);
            listViewUsers.MultiSelect = false;
            listViewUsers.Name = "listViewUsers";
            listViewUsers.Size = new Size(183, 378);
            listViewUsers.TabIndex = 6;
            listViewUsers.UseCompatibleStateImageBehavior = false;
            listViewUsers.View = View.Details;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "ID";
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Jméno";
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Práva";
            // 
            // btnUserDelete
            // 
            btnUserDelete.Location = new Point(41, 71);
            btnUserDelete.Name = "btnUserDelete";
            btnUserDelete.Size = new Size(118, 23);
            btnUserDelete.TabIndex = 7;
            btnUserDelete.Text = "odebrat uživatele";
            btnUserDelete.UseVisualStyleBackColor = true;
            btnUserDelete.Click += btnUserDelete_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(12, 96);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(183, 23);
            btnAddUser.TabIndex = 8;
            btnAddUser.Text = "přidání uživatele";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // listViewWork
            // 
            listViewWork.Columns.AddRange(new ColumnHeader[] { columnHeader13, columnHeader14, columnHeader15 });
            listViewWork.FullRowSelect = true;
            listViewWork.GridLines = true;
            listViewWork.Location = new Point(248, 125);
            listViewWork.MultiSelect = false;
            listViewWork.Name = "listViewWork";
            listViewWork.Size = new Size(270, 374);
            listViewWork.TabIndex = 9;
            listViewWork.UseCompatibleStateImageBehavior = false;
            listViewWork.View = View.Details;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "ID";
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "název práce";
            columnHeader14.Width = 90;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "popis práce";
            columnHeader15.Width = 500;
            // 
            // button2
            // 
            button2.Location = new Point(248, 99);
            button2.Name = "button2";
            button2.Size = new Size(112, 23);
            button2.TabIndex = 10;
            button2.Text = "mazání práce";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnAddWork
            // 
            btnAddWork.Location = new Point(378, 99);
            btnAddWork.Name = "btnAddWork";
            btnAddWork.Size = new Size(140, 23);
            btnAddWork.TabIndex = 11;
            btnAddWork.Text = "přidání práce";
            btnAddWork.UseVisualStyleBackColor = true;
            btnAddWork.Click += btnAddWork_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(57, 22);
            label1.Name = "label1";
            label1.Size = new Size(97, 30);
            label1.TabIndex = 12;
            label1.Text = "Uživatelé";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(344, 22);
            label2.Name = "label2";
            label2.Size = new Size(64, 30);
            label2.TabIndex = 13;
            label2.Text = "Práce";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(168, 531);
            label3.Name = "label3";
            label3.Size = new Size(131, 30);
            label3.TabIndex = 14;
            label3.Text = "Zaměstnanci";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(713, 531);
            label4.Name = "label4";
            label4.Size = new Size(87, 30);
            label4.TabIndex = 15;
            label4.Text = "Zakázky";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(683, 22);
            label5.Name = "label5";
            label5.Size = new Size(161, 30);
            label5.TabIndex = 16;
            label5.Text = "Pracovní hodiny";
            // 
            // listViewHours
            // 
            listViewHours.Columns.AddRange(new ColumnHeader[] { columnHeader16, columnHeader17, columnHeader18, columnHeader19, columnHeader20 });
            listViewHours.FullRowSelect = true;
            listViewHours.GridLines = true;
            listViewHours.Location = new Point(574, 125);
            listViewHours.Name = "listViewHours";
            listViewHours.Size = new Size(386, 374);
            listViewHours.TabIndex = 17;
            listViewHours.UseCompatibleStateImageBehavior = false;
            listViewHours.View = View.Details;
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "ID";
            columnHeader16.Width = 30;
            // 
            // columnHeader17
            // 
            columnHeader17.Text = "zaměstnanec";
            columnHeader17.Width = 100;
            // 
            // columnHeader18
            // 
            columnHeader18.Text = "zakázka";
            columnHeader18.Width = 90;
            // 
            // columnHeader19
            // 
            columnHeader19.Text = "název práce";
            columnHeader19.Width = 100;
            // 
            // columnHeader20
            // 
            columnHeader20.Text = "hodiny";
            // 
            // button3
            // 
            button3.Location = new Point(574, 96);
            button3.Name = "button3";
            button3.Size = new Size(153, 23);
            button3.TabIndex = 18;
            button3.Text = "mazání pracovní hodiny";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(806, 96);
            button4.Name = "button4";
            button4.Size = new Size(154, 23);
            button4.TabIndex = 19;
            button4.Text = "přidání pracovní hodiny";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // formAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(982, 977);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(listViewHours);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAddWork);
            Controls.Add(button2);
            Controls.Add(listViewWork);
            Controls.Add(btnAddUser);
            Controls.Add(btnUserDelete);
            Controls.Add(listViewUsers);
            Controls.Add(button1);
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
            PerformLayout();
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
        private Button button1;
        private ListView listViewUsers;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private Button btnUserDelete;
        private Button btnAddUser;
        private ListView listViewWork;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private Button button2;
        private Button btnAddWork;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListView listViewHours;
        private ColumnHeader columnHeader16;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader18;
        private ColumnHeader columnHeader19;
        private ColumnHeader columnHeader20;
        private Button button3;
        private Button button4;
    }
}