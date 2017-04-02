//Chanakya Banala
//CS 5110 TR 01:30 PM
// 21 june 2016
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    class Program
    {
        static void Main(string[] args)
        {
            string partNumber, partDescr;
            int qty;
            decimal price;

            Console.Write("Please Enter the Part Number: ");
            partNumber = Console.ReadLine();

            Console.Write("Please Enter the Part Description: ");
            partDescr = Console.ReadLine();

            Console.Write("Please Enter the Quantity: ");
            qty = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please Enter the Price: ");
            price = Convert.ToDecimal(Console.ReadLine());

            Invoice invoice = new Invoice(partNumber, partDescr, qty, price);

            Console.WriteLine("Your Order: ");
            Console.WriteLine("Part Number: {0}", invoice.PartNumber);
            Console.WriteLine("Part Description: {0}", invoice.PartDescr);
            Console.WriteLine("Quantity: {0}", invoice.Qty);
            Console.WriteLine("Price: {0}", invoice.Price);
            Console.WriteLine("Total: {0:C}", invoice.GetInvoiceAmount());

        }
    }
}

