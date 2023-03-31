using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

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
    }
}
