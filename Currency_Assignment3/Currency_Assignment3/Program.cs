//Chanakya Banala
//CS 5110 TR 01:30 PM
//25 May 2016
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the exchange rate from dollars to yuan: ");
            double convertionRatio = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter 0 to convert from dollars to yuan or 1 for the vice versa: ");
            double type = Convert.ToDouble(Console.ReadLine());
            if (type == 0)
            {
                Console.Write("Enter the dollar amount:");
                double amount = Convert.ToDouble(Console.ReadLine());
                double yaunamount = amount * convertionRatio;
               Console.WriteLine("{0:C} is {1:F1} yuan",amount,yaunamount);
            }
            if (type == 1)
            {
                Console.Write("Enter the yaun amount:");
                double amount = Convert.ToDouble(Console.ReadLine());
                double yaunamount = amount / convertionRatio;
                Console.WriteLine("{0:F1} yuan is {1:C} ", amount, yaunamount);
            }
            else if(type != 0 && type !=1)
            { 
                Console.WriteLine("Invalid option");
            }
        }
    }
}
