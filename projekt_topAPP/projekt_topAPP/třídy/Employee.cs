using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_topAPP.třídy
{
    public class Employee
    {
        public Employee( string firstN, string foreN, string birthDate, string email, string phone)
        {
            
            FirstName = firstN;
            ForeName = foreN;
            BirthDate = birthDate;
            Email = email;
            Phone = phone;
        }
        public Employee(int personalID, string firstN, string foreN, string birthDate, string email, string phone)
        {
            PersonalID = personalID;
            FirstName = firstN;
            ForeName = foreN;
            BirthDate = birthDate;
            Email = email;
            Phone = phone;
        }


        public int PersonalID { get; set; }
        public string FirstName { get; set; } 
        public string ForeName { get; set; } 
        public string BirthDate { get; set; }
        public string Email { get; set; } 
        public string Phone { get; set; } 

        public ListViewItem ToListViewEmployee()
        {
           return new ListViewItem(new string[] {PersonalID.ToString(), FirstName, ForeName,BirthDate ,Email,Phone,});
        }

       
    }
}
