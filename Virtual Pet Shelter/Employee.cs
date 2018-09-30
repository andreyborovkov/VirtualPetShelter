using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Pet_Shelter
{
    abstract class Employee
    {
        //properties
        public string EmployeeID { get; set; }

        //methods
        public abstract void Menu();
        public abstract void LunchTime();


    }
}
