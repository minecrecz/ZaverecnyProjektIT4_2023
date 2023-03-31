using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace projekt_topAPP.třídy
{
    public class Contract
    {
        public Contract(int contractNumber, string customer, string description)
        {
            ContractNumber = contractNumber;
            Customer = customer;
            Description = description;
        }

        public int ContractNumber{ get; set; }
        public string Customer { get; set; }
        public string Description { get; set; }
        public ListViewItem ToListViewContract()
        {
            return new ListViewItem(new string[] { ContractNumber.ToString(), Customer, Description,  });
        }
    }
}
