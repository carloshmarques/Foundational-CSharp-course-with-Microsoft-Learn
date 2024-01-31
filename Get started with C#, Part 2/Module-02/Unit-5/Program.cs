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
        {   // Link:  https://learn.microsoft.com/en-us/training/modules/csharp-call-methods/5-challenge

            //Exercise - Complete a challenge activity to discover and implement a method call
            //
            //Code challenges will reinforce what you've learned and help you gain some confidence before continuing on.
            //
            //Math class methods challenge
            //In this challenge, you'll use either Intellisense or learn.microsoft.com to find and call a method that returns the larger of two numbers.
            //Code challenge: Implement a method of the Math class that returns the larger of two numbers
            //
            // Here are your challenge requirements:

            int firstValue = 500;
            int secondValue = 600;
            // System.Math link : https://learn.microsoft.com/en-us/dotnet/api/system.math?view=net-8.0
            int largerValue = Math.Max(firstValue,secondValue);

            Console.WriteLine(largerValue);

            /*
             *  Note
             *  Your final solution for this challenge must use this code, 
             *  and must use the Console.WriteLine(largerValue); statement to generate the output.
             *  
             *  Find a method of the System.Math class that returns the larger of two numbers.
             *  You can use either Visual Studio Code "Intellisense" or learn.microsoft.com to find the method and determine how to call it properly.
             *  Use the method that you found to assign a value to the variable named largerValue.
             *  You should be able to pass the two integer values, firstValue and secondValue, to the method that you found. 
             *  The method should return a value of type int that represents the larger of the two arguments that you passed it.
             *  You can assign the return value to largerValue on a new code line or on the existing code line that's used to declare largerValue.
             */


        }
    }
}
