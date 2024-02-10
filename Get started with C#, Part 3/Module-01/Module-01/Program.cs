using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Module_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // link: https://learn.microsoft.com/en-us/training/modules/csharp-evaluate-boolean-expressions/
            // Module-01
            // Evaluate Boolean expressions to make decisions in C#

            /*
             * Learn the operators and techniques required to evaluate and compare values in your decision statements.
             * 
             * Learning objectives
             * After you complete this module, you'll be able to:
             * Use operators to create Boolean expressions that test for comparison and equality
             * Use built-in methods to the string class to perform better evaluations on string
             * Use the negation operator to test for the opposite of a given condition
             * Use the conditional operator to perform an inline evaluation
             */

            // Units-(1-2)
            // Link: https://learn.microsoft.com/en-us/training/modules/csharp-evaluate-boolean-expressions/1-introduction

            // Use the equality operator
         
            Console.WriteLine("a" == "a");
            Console.WriteLine("a" == "A");
            Console.WriteLine(1 == 2);

            string myValue = "a";
            Console.WriteLine(myValue == "a");
           

            string value1 = " a";
            string value2 = "A ";
            Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

            // Use the inequality operator
            Console.WriteLine("a" != "a");
            Console.WriteLine("a" != "A");
            Console.WriteLine(1 != 2);

            string myValue1 = "a";
            Console.WriteLine(myValue1 != "a");

            // Use the Comparison operators
            Console.WriteLine(1 > 2);
            Console.WriteLine(1 < 2);
            Console.WriteLine(1 >= 1);
            Console.WriteLine(1 <= 1);

            // Use a method that returns a Boolean
            string pangram = "The quick brown fox jumps over the lazy dog.";
            Console.WriteLine(pangram.Contains("fox"));
             Console.WriteLine(pangram.Contains("cow"));

            // These two lines of code will create the same output
            Console.WriteLine(pangram.Contains("fox") == false);
            Console.WriteLine(!pangram.Contains("fox"));

            // Use the Logical Negation operator
            string pangram1 = "The quick brown fox jumps over the lazy dog.";
            Console.WriteLine(!pangram1.Contains("fox"));
            Console.WriteLine(!pangram1.Contains("cow"));

            // Inequality operator versus logical negation
            int a = 7;
            int b = 6;
            Console.WriteLine(a != b); // output: True
            string s1 = "Hello";
            string s2 = "Hello";
            Console.WriteLine(s1 != s2); // output: False

            // Recap
            /*
             * Here's the main takeaways you learned about evaluating Boolean expressions so far:
             * There are many different kinds of expressions that evaluate to either true or false.
             * Evaluate equality using the == operator
             * Evaluating equality of strings requires you to consider the possibility that the strings have different case and leading or trailing spaces. 
             * Depending on your situation, use the ToLower() or ToUpper() helper methods, 
             * and the Trim() helper method to improve the likelihood that two strings are equal.
             * Evaluate inequality using the != operator.
             * Evaluate greater than, less than and similar operations using comparison operators like >, <, >=, and <=.
             * If a method returns a bool, it can be used as a Boolean expression.
             * Use the logical negation operator !to evaluate the opposite of a given expression.
             */
        }
    }
}
