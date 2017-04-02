//Chanakya Banala
//CS 5110 TR 01:30 PM
//02 JUNE 2016
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_Assignment4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int i = -1;
             decimal j = 0;
            int p = 0;
            int n = 0;
            decimal c = -1;
            do {
                Console.Write("Enter an integer (or 0 to quit):");
                i = Convert.ToInt32(Console.ReadLine());
                if (i > 0)
                {
                    p++;
                }
                if (i < 0)
                {
                    n++;
                }
                j = j + i;
                c++;
                

            } while(i != 0) ;
            Console.WriteLine("Positives:{0}", p);
            Console.WriteLine("Negatives:{0}",n);
            Console.WriteLine("Sum:{0}",j);
            Console.WriteLine("Average:{0:F2}", j/c);
        }
    }
}
