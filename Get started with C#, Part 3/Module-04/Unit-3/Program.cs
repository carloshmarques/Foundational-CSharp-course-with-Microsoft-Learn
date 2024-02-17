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
            // Exercise - Complete a challenge activity using for and if statements
            // linK : https://learn.microsoft.com/en-us/training/modules/csharp-for/3-challenge

            // Code challenge - implement the FizzBuzz challenge rules
            for (int i = 0; i < 101; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine($"{i} - FizzBuzz");
                }
                else if ((i % 3 == 0))
                {
                    Console.WriteLine($"{i} - Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine($"{i} - Buzz");
                }
                else
                {
                    Console.WriteLine($"{i}");
                }
                
            }
        }
    }
}
