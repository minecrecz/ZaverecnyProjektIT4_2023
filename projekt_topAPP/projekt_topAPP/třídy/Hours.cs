using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_topAPP.třídy
{
    public class Hours
    {
        public Hours(int iDWorkHours, string employee, string contract, string workType, string workHours)
        {
            IDWorkHours = iDWorkHours;
            Employee = employee;
            Contract = contract;
            WorkType = workType;
            WorkHours = workHours;
        }
        public Hours( string employee, string contract, string workType, string workHours)
        {
           
            Employee = employee;
            Contract = contract;
            WorkType = workType;
            WorkHours = workHours;
        }

        public int IDWorkHours { get; set; }
        public string Employee { get; set; }
        public string Contract { get; set; }
        public string WorkType { get; set; }
        public string WorkHours { get; set; }

        public ListViewItem ToListViewHours()
        {
            return new ListViewItem(new string[] { IDWorkHours.ToString(), Employee, Contract,WorkType,WorkHours.ToString() });
        }
    }
}
