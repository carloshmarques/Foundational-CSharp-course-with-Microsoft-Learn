using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Unit_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://learn.microsoft.com/en-us/training/modules/csharp-convert-cast/4-challenge

            //  Unit-4
            // Exercise - Complete a challenge to combine string array values as strings and as integers

            // Instantiate a string array, by entering the following "starter" code:
            string[] values = { "12.3", "45", "ABC", "11", "DEF" };

            decimal total = 0m;
            string message = "";

            // looping structure that can be used to iterate through each string value in the array values.
            foreach (string value in values)             
            {
                CultureInfo.CurrentCulture = new CultureInfo("en-US");

                decimal number;

                if (decimal.TryParse(value, out number))
                {
                    total += number;
                }
                else
                {
                    message += value;
                }
            }
            Console.WriteLine($"Message: {message}");
            Console.WriteLine($"Total: {total}");

        }
    }
}
