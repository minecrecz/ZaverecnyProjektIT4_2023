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
    public partial class formAddHours : Form
    {
        private int IDWorkHours = -1;
        public formAddHours()
        {
            InitializeComponent();
        }

        private void btnAddHours_Click(object sender, EventArgs e)
        {
            if (IDWorkHours == -1)
            {
                SqlRepository.AddHours(new Hours(txtEmployeeName.Text, txtContractName.Text, txtWorkType.Text, txtWorkHours.Value.ToString()));
                MessageBox.Show("uživatel přídán do databáze");

            }
        }
    }
}
