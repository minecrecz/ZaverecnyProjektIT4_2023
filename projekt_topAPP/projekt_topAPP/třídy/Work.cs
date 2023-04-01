using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace projekt_topAPP.třídy
{
    public class Work
    {
        public Work(string nameWork, string descriptionWork)
        {
            NameWork = nameWork;
            DescriptionWork = descriptionWork;
        }

        public Work(int iDWork, string nameWork, string descriptionWork)
        {
            IDWork = iDWork;
            NameWork = nameWork;
            DescriptionWork = descriptionWork;
        }

        public int IDWork { get; set; }
        public string NameWork { get; }
        public string DescriptionWork { get; set; }
        public ListViewItem ToListViewWork()
        {
            return new ListViewItem(new string[] { IDWork.ToString(), NameWork, DescriptionWork, });
        }
    }
}
