using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //https://learn.microsoft.com/en-us/training/modules/csharp-format-strings/3-exercise-string-interpolation
            // Exercise - Explore string interpolation

            // Display the invoice number using string interpolation
            int invoiceNumber = 1201;
            decimal productShares = 25.4568m;
            decimal subtotal = 2750.00m;
            decimal taxPercentage = .15825m;
            decimal total = 3185.19m;

            Console.WriteLine($"Invoice Number: {invoiceNumber}");

            // Display the product shares with one thousandth of a share (0.001) precision
            Console.WriteLine($"    Shares: {productShares:N3} Product");

            // Display the subtotal that you charge the customer formatted as currency
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"     Sub Total: {subtotal:C}");

            // Display the tax charged on the sale formatted as a percentage
            Console.WriteLine($"           Tax: {taxPercentage:P2}");

            // Finalize the receipt with the total amount due formatted as currency
            Console.WriteLine($"     Total Billed: {total:C}");

        }
    }
}
