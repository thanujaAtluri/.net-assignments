//Chanakya Banala
//CS 5110 TR 01:30 PM
// 21 june 2016
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private decimal _salary;

        public Employee(string firstname, string lastname, decimal salary)
        {
            FirstName = firstname;
            LastName = lastname;
            Salary = salary;
        }

        public decimal Salary
        {
            get { return _salary; }
            set
            {
                if (value > 0)
                    _salary = value;
            }
        }
    }
}
