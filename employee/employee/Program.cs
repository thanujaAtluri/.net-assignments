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
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Chanakya", "Banala", (decimal)15000.25);
            Employee emp2 = new Employee("Praveen", "Galla", (decimal)18000.75);

            Console.WriteLine("Employee 1 Fisrt Name: {0}", emp1.FirstName);
            Console.WriteLine("Employee 1 Last Name: {0}", emp1.LastName);
            Console.WriteLine("Employee 1 Salary: {0:C}", emp1.Salary);

            Console.WriteLine();

            Console.WriteLine("Employee 2 Fisrt Name: {0}", emp2.FirstName);
            Console.WriteLine("Employee 2 Last Name: {0}", emp2.LastName);
            Console.WriteLine("Employee 2 Salary: {0:C}", emp2.Salary);

            Console.WriteLine();

            Console.WriteLine("After 10% Raise: ");

            emp1.Salary = emp1.Salary * (decimal)1.1;
            emp2.Salary = emp2.Salary * (decimal)1.1;

            Console.WriteLine("Employee 1 New Salary: {0:C}", emp1.Salary);
            Console.WriteLine("Employee 2 New Salary: {0:C}", emp2.Salary);

        }
    }
}

