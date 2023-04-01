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




        public formAdmin()
        {
            InitializeComponent();

        }

        private void formAdmin_Load(object sender, EventArgs e)
        {
            GetEmployees();
            GetContracs();
            GetUsers();
            GetWorks();


        }
        private void GetEmployees()
        {
            listViewEmployee.Items.Clear();
            var employees = SqlRepository.GetEmployees();
            foreach (var employee in SqlRepository.GetEmployees())
            {
                listViewEmployee.Items.Add(employee.ToListViewEmployee());
            }
        }

        private void btnEmployeeDelete_Click(object sender, EventArgs e)
        {

            if (listViewEmployee.SelectedIndices.Count > 0)
            {
                var id = listViewEmployee.Items[listViewEmployee.SelectedIndices[0]].SubItems[0].Text;
                SqlRepository.DeleteEmployee(id);
                GetEmployees();
                MessageBox.Show("Položka smazána");
            }
            else
            {
                MessageBox.Show("Vyber položku");
            }

        }

        private void btnAddEmployeeForm_Click(object sender, EventArgs e)
        {
            formAddEmployee formAddEmployee = new formAddEmployee();

            formAddEmployee.ShowDialog();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void GetContracs()
        {
            listViewContract.Items.Clear();
            var contracts = SqlRepository.GetContracts();
            foreach (var contract in SqlRepository.GetContracts())
            {
                listViewContract.Items.Add(contract.ToListViewContract());
            }
        }

        private void btnDeleteContract_Click(object sender, EventArgs e)
        {
            if (listViewContract.SelectedIndices.Count > 0)
            {
                var contractNumber = listViewContract.Items[listViewContract.SelectedIndices[0]].SubItems[0].Text;
                SqlRepository.DeleteContract(contractNumber);
                GetContracs();
                MessageBox.Show("Položka smazána");
            }
            else
            {
                MessageBox.Show("Vyber položku");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formAddContract formAddContract = new formAddContract();
            formAddContract.ShowDialog();
        }
        private void GetUsers()
        {
            listViewUsers.Items.Clear();
            var users = SqlRepository.GetUsers();
            foreach (var user in SqlRepository.GetUsers())
            {
                listViewUsers.Items.Add(user.ToListViewUser());
            }
        }

        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            if (listViewUsers.SelectedIndices.Count > 0)
            {
                var ID = listViewUsers.Items[listViewUsers.SelectedIndices[0]].SubItems[0].Text;
                SqlRepository.DeleteUser(ID);
                GetUsers();
                MessageBox.Show("položka smazána");
            }
            else
            {
                MessageBox.Show("vyber položku");
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            formAddUser formAddUser = new formAddUser();
            formAddUser.ShowDialog();
        }
        private void GetWorks()
        {
            listViewWork.Items.Clear();
            var works = SqlRepository.GetWorks();
            foreach (var work in SqlRepository.GetWorks())
            {
                listViewWork.Items.Add(work.ToListViewWork());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listViewWork.SelectedIndices.Count > 0)
            {
                var IDWork = listViewWork.Items[listViewWork.SelectedIndices[0]].SubItems[0].Text;
                SqlRepository.DeleteWork(IDWork);
                GetWorks();
                MessageBox.Show("Položka smazána");
            }
            else
            {
                MessageBox.Show("vyber položku");
            }
        }

        private void btnAddWork_Click(object sender, EventArgs e)
        {
            formAddWork formAddWork = new formAddWork();
            formAddWork.ShowDialog();
        }
    }
}
