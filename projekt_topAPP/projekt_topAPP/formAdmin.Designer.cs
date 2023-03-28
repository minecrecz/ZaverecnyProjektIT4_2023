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
            txtSearchEmployee = new TextBox();
            SuspendLayout();
            // 
            // listViewEmployee
            // 
            listViewEmployee.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listViewEmployee.GridLines = true;
            listViewEmployee.Location = new Point(12, 47);
            listViewEmployee.Name = "listViewEmployee";
            listViewEmployee.Size = new Size(374, 379);
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
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Telefoní číslo";
            // 
            // txtSearchEmployee
            // 
            txtSearchEmployee.Location = new Point(115, 18);
            txtSearchEmployee.Name = "txtSearchEmployee";
            txtSearchEmployee.Size = new Size(165, 23);
            txtSearchEmployee.TabIndex = 1;
            // 
            // formAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1265, 785);
            Controls.Add(txtSearchEmployee);
            Controls.Add(listViewEmployee);
            Name = "formAdmin";
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
        private TextBox txtSearchEmployee;
    }
}