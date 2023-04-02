namespace projekt_topAPP
{
    partial class formUser
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
            listViewContract = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            btnDeleteHours = new Button();
            listViewHours = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            btnAddHours = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // listViewContract
            // 
            listViewContract.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewContract.FullRowSelect = true;
            listViewContract.GridLines = true;
            listViewContract.Location = new Point(12, 103);
            listViewContract.Name = "listViewContract";
            listViewContract.Size = new Size(379, 399);
            listViewContract.TabIndex = 0;
            listViewContract.UseCompatibleStateImageBehavior = false;
            listViewContract.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Customer";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Description";
            columnHeader3.Width = 350;
            // 
            // btnDeleteHours
            // 
            btnDeleteHours.BackColor = Color.OrangeRed;
            btnDeleteHours.FlatAppearance.BorderColor = Color.OrangeRed;
            btnDeleteHours.FlatAppearance.BorderSize = 5;
            btnDeleteHours.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteHours.Location = new Point(427, 506);
            btnDeleteHours.Name = "btnDeleteHours";
            btnDeleteHours.Size = new Size(176, 34);
            btnDeleteHours.TabIndex = 1;
            btnDeleteHours.Text = "Smazat odpracováné hodiny";
            btnDeleteHours.UseVisualStyleBackColor = false;
            btnDeleteHours.Click += button1_Click;
            // 
            // listViewHours
            // 
            listViewHours.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            listViewHours.FullRowSelect = true;
            listViewHours.GridLines = true;
            listViewHours.Location = new Point(427, 103);
            listViewHours.Name = "listViewHours";
            listViewHours.Size = new Size(412, 397);
            listViewHours.TabIndex = 2;
            listViewHours.UseCompatibleStateImageBehavior = false;
            listViewHours.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "ID";
            columnHeader4.Width = 40;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Jméno zaměstnance";
            columnHeader5.Width = 130;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "zakázka";
            columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Typ práce";
            columnHeader7.Width = 90;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Hodiny";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(137, 70);
            label1.Name = "label1";
            label1.Size = new Size(87, 30);
            label1.TabIndex = 3;
            label1.Text = "Zakázky";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(524, 70);
            label2.Name = "label2";
            label2.Size = new Size(206, 30);
            label2.TabIndex = 4;
            label2.Text = "Odpracované hodiny";
            // 
            // btnAddHours
            // 
            btnAddHours.BackColor = Color.OrangeRed;
            btnAddHours.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddHours.Location = new Point(641, 507);
            btnAddHours.Name = "btnAddHours";
            btnAddHours.Size = new Size(198, 33);
            btnAddHours.TabIndex = 5;
            btnAddHours.Text = "Přidání odpracovaných hodin";
            btnAddHours.UseVisualStyleBackColor = false;
            btnAddHours.Click += btnAddHours_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.OrangeRed;
            label3.Location = new Point(338, 9);
            label3.Name = "label3";
            label3.Size = new Size(139, 46);
            label3.TabIndex = 6;
            label3.Text = "TopAPP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(363, 55);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 7;
            label4.Text = "User terminal";
            // 
            // formUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(851, 552);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnAddHours);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listViewHours);
            Controls.Add(btnDeleteHours);
            Controls.Add(listViewContract);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "formUser";
            Text = "Uživatel";
            Load += formUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewContract;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button btnDeleteHours;
        private ListView listViewHours;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private Label label1;
        private Label label2;
        private Button btnAddHours;
        private Label label3;
        private Label label4;
    }
}