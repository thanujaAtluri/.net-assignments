//Chanakya Banala
//CS 5110 TR 01:30 PM
//07 June 2016
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureInvestment_Assignment5
{
    class Program
    {
        public static double futureInvestmentValue(double investmentAmount,
double annualInterestRate, int years)
        {
            double monthlyInterestRate = annualInterestRate / 1200;
            double futureInvestmentValue = investmentAmount * (Math.Pow((1 + monthlyInterestRate), (years * 12)));
            return futureInvestmentValue;
        }
        static void Main(string[] args)
        {
            double investmentAmount, annualInterestRate;
            Console.Write("Enter investment amount:");
            investmentAmount = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter annual percentage rate:");
            annualInterestRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Years \t\t Future Value");
            for (int i = 1; i <= 30; i++)
                {
                Console.WriteLine("{0} \t\t {1:C}",i,futureInvestmentValue(investmentAmount,annualInterestRate,i));
            }
        }
      
    }
}
