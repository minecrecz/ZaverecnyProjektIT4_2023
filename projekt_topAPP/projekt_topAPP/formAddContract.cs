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
    public partial class formAddContract : Form
    {
        private int contractNumber = -1;
        public formAddContract()
        {
            InitializeComponent();
        }

        private void btnAddContract_Click(object sender, EventArgs e)
        {
            if (contractNumber == -1)
            {
                SqlRepository.AddContract(new Contract(txtAddConctractName.Text, txtAddDescription.Text));
                MessageBox.Show("uživatel přídán do databáze");

            }
        }
    }
}
