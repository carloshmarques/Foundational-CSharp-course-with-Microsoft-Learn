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
            // https://learn.microsoft.com/en-us/training/modules/csharp-do-while/5-exercise-challenge-differentiate-while-do-statements
            // Exercise - Complete a challenge activity to differentiate between do and while iteration statements
            // Manage user input during this challenge
            
            string readResult;
            bool validEntry = false;
            Console.WriteLine("Enter a string containing at least three characters:");
            Console.WriteLine("Enter a string:");
            do
            {
              
                readResult = Console.ReadLine();
                if(readResult != null)
                {
                    if(readResult.Length >= 3)
                    {
                        validEntry = true;
                    }
                    else
                    {
                        Console.WriteLine("Your input is invalid, please try again.");
                    }
                }
            } while (validEntry == false);

            // Continue after
        }
    }
}
