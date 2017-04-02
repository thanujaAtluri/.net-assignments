//Chanakya Banala
//CS 5110 TR 01:30 PM
//07 June 2016
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintMAtrix_Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer : ");
            int n = Convert.ToInt32(Console.ReadLine());
            PrintMatrix(n);
            while (n <= 0)
            {
                Console.WriteLine("Please enter positive number");
                n = Convert.ToInt32(Console.ReadLine());
                PrintMatrix(n);
            }
            Console.WriteLine();

        }
        public static void PrintMatrix(int n)
        {
            Random rand = new Random();
            for(int i=0;i<=n;i++)
            {
                for(int j=0;j<n;j++)
                {
                    if (i == j)
                        Console.WriteLine();
                    else
                        Console.Write(" " + rand.Next(0, 2));
                }
            }

        }
    }
}
