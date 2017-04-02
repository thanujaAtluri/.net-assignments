//Chanakya Banala
//CS 5110 TR 01:30 PM
//25 May 2016
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomMonth_Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 12);
            switch (randomNumber)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                    
                case 10:
                    Console.WriteLine("October");
                    break;
                   
                case 11:
                    Console.WriteLine("November");
                    break;
                    
                case 12:
                    Console.WriteLine("December");

                    break;
                    
            }
        }
    }
}
