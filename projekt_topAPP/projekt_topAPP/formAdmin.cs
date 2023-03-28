using projekt_topAPP.třídy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt_topAPP
{
    public partial class formAdmin : Form
        
    {
        
        private sql_repository sql_repository;
        private Employee employee;
        private List<string[]> employees;
        
        public formAdmin()
        {
            InitializeComponent();
            sql_repository = new sql_repository();
        }

        private void formAdmin_Load(object sender, EventArgs e)
        {
            foreach (var row in sql_repository.GetEmployees)
            {
                listViewEmployee.Items.Add(new ListViewItem(row));
            }
        }
        
    }
}
