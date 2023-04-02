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
    public partial class formUser : Form
    {
        public formUser()
        {
            InitializeComponent();
        }


        private void formUser_Load(object sender, EventArgs e)
        {
            GetContracs();
            GetHours();
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
        private void GetHours()
        {
            listViewHours.Items.Clear();
            var hours = SqlRepository.GetHours();
            foreach (var hour in SqlRepository.GetHours())
            {
                listViewHours.Items.Add(hour.ToListViewHours());
            }
        }

        private void button1_Click(object sender, EventArgs e)// smazání pracovních hodin(nejde mi to přejmenovat )// 
        {
            if (listViewHours.SelectedIndices.Count > 0)
            {
                var IDWorkHours = listViewHours.Items[listViewHours.SelectedIndices[0]].SubItems[0].Text;
                SqlRepository.DeleteHours(IDWorkHours);
                GetHours();
                MessageBox.Show("Položka smazána");
            }
            else
            {
                MessageBox.Show("vyber položku");
            }
        }

        private void btnAddHours_Click(object sender, EventArgs e)
        {
            formAddHours formAddHours = new formAddHours();
            formAddHours.ShowDialog();
        }
    }
}
