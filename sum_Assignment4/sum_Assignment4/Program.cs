//Chanakya Banala
//CS 5110 TR 01:30 PM
//02 JUNE 2016
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_Assignment4
{
    class Program
    {
        
        

        static void Main(string[] args)
        {
            decimal s = 0;
            for (decimal i = 1; i <= 97; i++) {
               if (i % 2 != 0) {
                    s = s + (i / (i + 2));
                    if (i == 97)
                    {
                        Console.WriteLine("{0 }/{1}  ", i, i + 2);

                    }
                    else
                    {
                        Console.Write("{0 }/{1} +", i, i + 2);
                    }
                }
            }
            Console.WriteLine("Sum of series : {0}",s);

        }
    }
}
