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
    public partial class formAddWork : Form
    {
        private int IDWork = -1;
        public formAddWork()
        {
            InitializeComponent();
        }

        private void btnAddWork_Click(object sender, EventArgs e)
        {
            if (IDWork == -1)
            {
                SqlRepository.AddWork(new Work(txtWorkName.Text, txtWorkDescription.Text));
                MessageBox.Show("uživatel přídán do databáze");

            }
        }
    }
}
