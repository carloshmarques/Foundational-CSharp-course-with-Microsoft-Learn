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
            // Console output encoding to europe location
            Console.OutputEncoding = Encoding.UTF8;
            string customerName = "Ms. Barros";

            string currentProduct = "Magic Yield";
            int currentShares = 2975000;
            decimal currentReturn = 0.1275m;
            decimal currentProfit = 55000000.0m;

            string newProduct = "Glorious Future";
            decimal newReturn = 0.13125m;
            decimal newProfit = 63000000.0m;

            // Your logic here
            Console.WriteLine($"Dear {customerName},");
            Console.WriteLine($"As a costumer of our {currentProduct} offering we are excited to tell you about" +
                $" a new financial product that would dramatically increase your return.\n");
            Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P2}.\n");

            Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}. Given your current volume," +
                $" your potencial profit would be {newProfit:C}.\n");
            Console.WriteLine("Here's a quick comparison:\n");

            string comparisonMessage = "";

            // Your logic here
            Console.WriteLine("123456789012345678901234567890123456789012345");

            comparisonMessage = currentProduct.PadRight(20);
            comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
            comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);


            comparisonMessage += "\n";
            comparisonMessage += newProduct.PadRight(20);
            comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
            comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

            Console.WriteLine(comparisonMessage);

        }
    }
}
