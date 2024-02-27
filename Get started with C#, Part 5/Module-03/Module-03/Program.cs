using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://learn.microsoft.com/en-us/training/modules/create-c-sharp-methods-return-values/
            // Create C# methods that return values

            // Unit-1
            //https://learn.microsoft.com/en-us/training/modules/create-c-sharp-methods-return-values/1-introduction

            //  Unit-2
            // https://learn.microsoft.com/en-us/training/modules/create-c-sharp-methods-return-values/2-exercise-understand-return-type-syntax

            // Exercise - Understand return type syntax

            // Use methods to calculate the total purchase price
            double total = 0;
            double minimumSpend = 30.00;

            double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
            double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };

            for (int i = 0; i < items.Length; i++)
            {
                total += GetDiscountedPrice(i);
            }

            if (TotalMeetsMinimum())
            {
                total -= 5.00;
            }


            Console.WriteLine($"Total: ${FormatDecimal(total)}");

            double GetDiscountedPrice(int itemIndex)
            {
                // Calculate the discounted price of the item
               return items[itemIndex] * (1 - discounts[itemIndex]);
                
            }

            bool TotalMeetsMinimum()
            {
                // Check if the total meets the minimum
                return total >= minimumSpend;
            }

            string FormatDecimal(double input)
            {
                // Format the double so only 2 decimal places are displayed
                return input.ToString().Substring(0, 5);
            }
        }
    }
}
