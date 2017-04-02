//Chanakya Banala
//CS 5110 TR 01:30 PM
//02 JUNE 2016
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pounds_Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kilograms \t");
            Console.WriteLine("Pounds");
            for (int i = 1; i <= 100; i++)
            {
                if(i%2 != 0){
                    Console.Write("{0}\t\t", i);
                    Console.WriteLine("{0:F1}", i * 2.2);
                }

            }
        }
    }
}
