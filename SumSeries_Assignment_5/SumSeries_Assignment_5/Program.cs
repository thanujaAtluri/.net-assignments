//Chanakya Banala
//CS 5110 TR 01:30 PM
//07 June 2016
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeries_Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("i \t \t M(i)");
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine("{0} \t\t {1}", j, M(j));
            }
        }
        public static double M(int i)
        {
            double sum = 0.00;
            int x = 1;
            for (double k=1;k<=i;k++)
            {
                sum = sum + (x / k);

            }
            return sum;
        }
    }
}
