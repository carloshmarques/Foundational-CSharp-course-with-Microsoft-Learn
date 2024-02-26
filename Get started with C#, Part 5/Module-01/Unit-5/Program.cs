using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://learn.microsoft.com/en-us/training/modules/write-first-c-sharp-method/5-exercise-build-code-with-methods
            // Exercise - Build code with methods

            // Use methods to structure code

            // Break down the problem
            // Enter the following pseudo-code into the Editor:

            /*
            if ipAddress consists of 4 numbers
            and
            if each ipAddress number has no leading zeroes
            and
            if each ipAddress number is in range 0 - 255

            then ipAddress is valid

            else ipAddress is invalid
            */

            // Now let's turn this into real code!
            // Develop your solution

            string[] ipv4Input = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255" };
            string[] address;
            bool validLength = false;
            bool validZeroes = false;
            bool validRange = false;

            foreach (string ip in ipv4Input)
            {
                address = ip.Split('.', (char)StringSplitOptions.RemoveEmptyEntries);

                ValidateLength();
                ValidateZeroes();
                ValidateRange();

                if (validLength && validZeroes && validRange)
                {
                    Console.WriteLine($"{ip} is a valid IPv4 address");
                }
                else
                {
                    Console.WriteLine($"{ip} is an invalid IPv4 address");
                }
            }

            void ValidateLength()
            {
                validLength = address.Length == 4;
            }

            void ValidateZeroes()
            {
                foreach (string number in address)
                {
                    if (number.Length > 1 && number.StartsWith("0"))
                    {
                        validZeroes = false;
                        return;
                    }
                }

                validZeroes = true;
            }

            void ValidateRange()
            {
                foreach (string number in address)
                {
                    int value = int.Parse(number);
                    if (value < 0 || value > 255 || value == 255)
                    {
                        validRange = false;
                        return;
                    }
                }
                validRange = true;
            }

            /*
             * Recap
                Here's what you've learned about using methods so far:

                Methods can be used to quickly structure applications
                The return keyword can be used to terminate method execution
                Each step of a problem can often be translated into its own method
                Use methods to solve small problems to build up your solution

             */
        }
    }
}
