using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_4
{
    internal class Program
    {
        static void Main(string[] args)
        {   // https://learn.microsoft.com/en-us/training/modules/csharp-if-elseif-else/4-challenge
            // Exercise - Complete a challenge activity to apply business rules

            Random random = new Random();
            int daysUntilExpiration = random.Next(12);
            int discountPercentage = 0;

            // Your code goes here
            // Rules of renewal of subscription
            if (daysUntilExpiration == 0) 
            {
                Console.WriteLine("Your subscription has expired.");
            }
            else if(daysUntilExpiration == 1)
            {
                Console.WriteLine($"Your subscription ends within one day!");
                discountPercentage = 20;
                
            }
            else if (daysUntilExpiration <= 5)
            {
                Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
                discountPercentage = 10;
            }
            else if (daysUntilExpiration <= 10)
            {
                Console.WriteLine("Your subscription will expire soon. Renew now!");
            }

            if (discountPercentage > 0)
            {
                Console.WriteLine($"Renew now and save {discountPercentage}%.");
            }

        }
    }
}
