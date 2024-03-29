﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // link: https://learn.microsoft.com/en-us/training/modules/csharp-readable-code/
            // Unit - 3

            /*
            string firstName = "Bob";
            int widgetsPurchased = 7;
            Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");
            */

            /*
               The following code creates five random OrderIDs
               to test the fraud detection process.  OrderIDs 
               consist of a letter from A to E, and a three
               digit number. Ex. A123.
             */
            Random random = new Random();
            string[] orderIDs = new string[5];

            for (int i = 0; i < orderIDs.Length; i++)
            {
                int prefixValue = random.Next(65, 70);
                string prefix = Convert.ToChar(prefixValue).ToString();
                string suffix = random.Next(1, 1000).ToString("000");

                orderIDs[i] = prefix + suffix;
            }

            foreach (var orderID in orderIDs)
            {
                Console.WriteLine(orderID);
            }

            /*
             *  Recap
             *  
                The main takeaways from this exercise:
                Use code comments to leave meaningful notes to yourself about the problem your code solves.
                Don't use code comments that explain how C# or the .NET Class Library works.
                Use code comments when temporarily trying alternative solutions until you're ready to commit to the new code solution, 
                at which point you can delete the old code.
                Never trust comments. They may not reflect the current state of the code after many changes and updates.
             */
        }
    }
}
