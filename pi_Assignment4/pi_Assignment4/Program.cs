//Chanakya Banala
//CS 5110 TR 01:30 PM
//02 JUNE 2016
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi_Assignment4
{
    class Program
    {   
        static void Main(string[] args)
        {
            
            Console.Write("Iterationss \t");
            Console.WriteLine("Approximation");
            for (int i = 1; i <= 10; i++)
            {
                double pi_sum = 0;
                for (int j =1;j<=i*10000;j++)
                {
                    pi_sum = pi_sum + (Math.Pow((-1), (j + 1)) / ((2 * j)-1));
                    if (j == i * 10000)
                    {
                        Console.Write("{0}\t\t", j);
                        Console.WriteLine("{0}", pi_sum*4);
                    }
                    

                }
                


            }
        }
    }
}
