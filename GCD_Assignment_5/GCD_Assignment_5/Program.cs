//Chanakya Banala
//CS 5110 TR 01:30 PM
//07 June 2016
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCD_Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first integer:");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second integer :");
            int j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("GCD({0},{1}) = {2}", i, j, GreatestCommonDivisor(i, j));
        }
        public static int GreatestCommonDivisor(int m,int n)
        {
            if (m % n == 0)
            {
                return n;
            }
            else
            {
                return GreatestCommonDivisor(n, m % n);
            }
        }
    }
}
