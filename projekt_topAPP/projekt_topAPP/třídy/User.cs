using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace projekt_topAPP.třídy
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; }
        public string Role { get; set; }

        public User(int iD, string name, string role)
        {
            ID = iD;
            Name = name;
            Role = role;
        }
        public User( string name, string role)
        {
            
            Name = name;
            Role = role;
        }
        public ListViewItem ToListViewUser()
        {
            return new ListViewItem(new string[] { ID.ToString(), Name, Role });
        }
    }
}
