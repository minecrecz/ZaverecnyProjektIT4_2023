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
        
        sql_repository Sql_repository;
        private Employee employee;


        public formAdmin()
        {
            InitializeComponent();
            Sql_repository = new sql_repository();
        }

        private void formAdmin_Load(object sender, EventArgs e)
        {
            listViewEmployee.Items.Clear();
              var employees =Sql_repository.GetEmployees();
            foreach (var row in employees)
            {
                listViewEmployee.Items.Add(new ListViewItem(new string[] { employee.ForeName, employee.FirstName,Convert.ToString(employee.PersonalID) ,}));
            }
        }
        
    }
}
