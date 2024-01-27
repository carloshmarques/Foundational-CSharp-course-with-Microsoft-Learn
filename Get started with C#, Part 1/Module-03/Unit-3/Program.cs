using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Unit_3
{
    internal class Program
    {
        static void Main(string[] args)
        {   // link: https://learn.microsoft.com/en-us/training/modules/csharp-basic-formatting/3-exercise-string-concatenation

            // Exercise - Combine strings using string concatenation

            /*
             * Often, you'll need to combine data from many different sources, 
             * including literal strings and variables containing both text and numeric data. 
             * In this unit, 
             * you'll use string concatenation to combine two or more values into a new string.
             * What is string concatenation?
             * String concatenation is "programmer speak" for simply combining two or more string values into a new string value. 
             * Unlike addition, 
             * the second value is appended to the end of the first value, and so on. 
             * In the following exercise, you'll write code to concatenate string values together.
             * Concatenate a literal string and a variable
             * To concatenate two strings together, you use the string concatenation operator, which is the plus symbol +.
             */

            // Code here:
            //string firstName = "Bob";
            //string message = "Hello " + firstName;
            // Notice the order—the first string "Hello " is first in the new string,
            // and the value in the firstName variable is appended to the end of it.
            // The output should be:  Hello Bob
            //Console.WriteLine(message);

            // Concatenate multiple variables and literal strings
            // You can perform several concatenation operations in the same line of code.

            //string greeting = "Hello";
            //string messageTwo = greeting + " " + firstName + "!" ;
            //Console.WriteLine(messageTwo);

            /*
             *  Avoiding intermediate variables
             *  In the previous steps, 
             *  you used an extra variable to hold the new string that resulted from the concatenation operation. 
             *  Unless you have a good reason to do so, 
             *  you can (and should) avoid using intermediate variables by performing the concatenation operation as you need it.
             */

            // Like so:
            string firstName = "Bob";
            string greeting = "Hello";
            Console.WriteLine(greeting + " " + firstName + "!");

            // Recap
            // Here's what you've learned about string concatenation so far:
            // String concatenation allows you to combine smaller literal and variable strings into a single string.
            // Avoid creating intermediate variables if adding them doesn't increase readability.

        }
    }
}
