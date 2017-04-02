//Chanakya Banala
//CS 5110 TR 01:30 PM
//07 June 2016

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pantagonal_assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n\t\t PentagonalNumber(n)");
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("{0} \t\t {1}", i, pantagonalNumber(i));
            }
        }
        public static int pantagonalNumber(int n)
        {
            return n * (3 * n - 1) / 2;
        }
    }
}
