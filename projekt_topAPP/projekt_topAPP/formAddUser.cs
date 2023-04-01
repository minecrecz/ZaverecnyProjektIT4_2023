using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class formAddUser : Form
    {
        private int iD = -1;
        public formAddUser()
        {
            InitializeComponent();
        }
        public formAddUser(string username, string password, string rights)
        {
            iD = iD;
            txtUsername.Text = username;
            txtPassword.Text = password;
            comboBox1.SelectedItem = rights;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (iD == -1)
            {
                string selectedRights = comboBox1.SelectedItem.ToString();
                SqlRepository.RegisterUser(txtUsername.Text, txtPassword.Text, selectedRights);
                MessageBox.Show("uživatel přídán do databáze");

            }
        }
    }
}
