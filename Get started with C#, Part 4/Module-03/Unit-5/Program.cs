using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://learn.microsoft.com/en-us/training/modules/csharp-format-strings/5-challenge
            // Exercise - Complete a challenge to apply string interpolation to a form letter

            // initial code:

            string customerName = "Ms. Barros";

            string currentProduct = "Magic Yield";
            int currentShares = 2975000;
            decimal currentReturn = 0.1275m;
            decimal currentProfit = 55000000.0m;

            string newProduct = "Glorious Future";
            decimal newReturn = 0.13125m;
            decimal newProfit = 63000000.0m;

            // Your logic here

            Console.WriteLine("Here's a quick comparison:\n");

            string comparisonMessage = "";

            // Your logic here

            Console.WriteLine(comparisonMessage);

        }
    }
}
