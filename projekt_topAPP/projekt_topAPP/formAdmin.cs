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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projekt_topAPP
{
    public partial class formAdmin : Form

    {

        sql_repository Sql_repo;



        public formAdmin()
        {
            InitializeComponent();
            Sql_repo = new sql_repository();
        }

        private void formAdmin_Load(object sender, EventArgs e)
        {
            GetEmployees();
        }
        private void GetEmployees()
        {
            listViewEmployee.Items.Clear();
            var employees = Sql_repo.GetEmployees();
            foreach (var employee in Sql_repo.GetEmployees())
            {
                listViewEmployee.Items.Add(employee.ToListViewEmployee());
            }
        }

        private void btnEmployeeDelete_Click(object sender, EventArgs e)
        {

            if (listViewEmployee.SelectedIndices.Count > 0)
            {
                var id = listViewEmployee.Items[listViewEmployee.SelectedIndices[0]].SubItems[0].Text;
                Sql_repo.DeleteEmployee(id);
                GetEmployees();
            }
            else
            {
                MessageBox.Show("Vyber položku");
            }

        }
    }
}
