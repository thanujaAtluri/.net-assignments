//Chanakya Banala
//CS 5110 TR 01:30 PM
//25 May 2016
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadriaticEquation_Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double dis = Math.Pow(b, 2) - (4 * a * c);
            if(dis < 0)
            {
                Console.WriteLine("The equation has no real roots");
            }
            if (dis == 0)
            {
                double root = (-b + Math.Sqrt(dis)) / (2 * a);
                Console.WriteLine("The equation has one real root:{0:F5}",root);
            }
            if (dis >  0)
            {   double r1 = (-b + Math.Sqrt(dis)) / (2 * a);
                double r2 = (-b - Math.Sqrt(dis)) / (2 * a);
                Console.WriteLine("The equation has two roots:{0:F5} and {1:F5}",r1,r2);
            }
        }
    }
}
