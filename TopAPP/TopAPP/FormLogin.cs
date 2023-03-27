using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopAPP
{
    public partial class FormLogin : Form
    {
        SqlRepo sqlRepo;
        public FormLogin()
        {
            InitializeComponent();
            sqlRepo = new SqlRepo();
            sqlRepo.ConvertUsersToHashed();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user =sqlRepo.GetUsers(txtLogin.Text.Trim());
        }
    }
}
