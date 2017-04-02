//Chanakya Banala
//CS 5110 TR 01:30 PM
//25 May 2016
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisibility_Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int a = num % 5; 
            int b = num % 7;
            Console.WriteLine("{0} and {1}",num%5,num%7);
            if (a == 0 && b == 0)
            {
                Console.WriteLine("{0} is divisible by 5 and 7",num);
            }
            if (a == 0 || b == 0)
            {
                Console.WriteLine("{0} is divisible by either 5 or 7", num);
            }
           if(a == 0 ^ b == 0)
            {
                Console.WriteLine("{0} is  divisible by either 5 or 7,but not both", num);
            }
        }
    }
}
