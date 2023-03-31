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
    public partial class formAddEmployee : Form

    {
        private int personalID = -1;
        public formAddEmployee()
        {
            InitializeComponent();
        }

        public formAddEmployee(Employee employee)
        {
            personalID = employee.PersonalID;
            InitializeComponent();

            txtFirstName.Text = employee.FirstName;
            txtForeName.Text = employee.ForeName;
            txtBirthDay.Text = employee.BirthDate;
            txtEmail.Text = employee.Email;
            txtNumber.Text = employee.Phone;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (personalID == -1)
            {
                SqlRepository.AddEmployee(new Employee(txtFirstName.Text, txtForeName.Text, txtBirthDay.Text, txtEmail.Text, txtNumber.Text));
                MessageBox.Show("uživatel přídán do databáze");
            }
            else
            {
                SqlRepository.UpdateEmployee(personalID, new Employee(txtFirstName.Text, txtForeName.Text, txtBirthDay.Text, txtEmail.Text, txtNumber.Text));
                MessageBox.Show("uživatel upraven");
            }

        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            SqlRepository.UpdateEmployee(personalID, new Employee(txtFirstName.Text, txtForeName.Text, txtBirthDay.Text, txtEmail.Text, txtNumber.Text));
            MessageBox.Show("uživatel upraven");
        }
    }
}
