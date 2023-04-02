using projekt_topAPP.třídy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            dateBirthDay.Value = DateTime.ParseExact(employee.BirthDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            txtEmail.Text = employee.Email;
            txtNumber.Text = employee.Phone;
            string birthday = dateBirthDay.Value.ToString("yyyy-MM-dd");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (personalID == -1)
            {
                SqlRepository.AddEmployee(new Employee(txtFirstName.Text, txtForeName.Text, dateBirthDay.Value.ToString("yyyy-MM-dd"), txtEmail.Text, txtNumber.Text));
                MessageBox.Show("uživatel přídán do databáze");

            }


        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            SqlRepository.UpdateEmployee(personalID, new Employee(txtFirstName.Text, txtForeName.Text, dateBirthDay.Value.ToString("yyyy-MM-dd"), txtEmail.Text, txtNumber.Text));
            MessageBox.Show("uživatel upraven");
        }
    }
}
