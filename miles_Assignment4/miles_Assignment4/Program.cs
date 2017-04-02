//Chanakya Banala
//CS 5110 TR 01:30 PM
//02 JUNE 2016
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miles_Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Miles \t");
            Console.WriteLine("Kilometers");
            for (int i = 1; i<= 100; i++)
            {
                Console.Write("{0}\t", i);
                Console.WriteLine("{0:F4}",i*1.609);

            }

        }
    }
}
