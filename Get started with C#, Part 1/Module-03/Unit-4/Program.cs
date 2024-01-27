using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Unit_4
{
    internal class Program
    {
        static void Main(string[] args)
        {   //link:  https://learn.microsoft.com/en-us/training/modules/csharp-basic-formatting/4-exercise-string-interpolation

            // Exercise - Combine strings using string interpolation
            /*
             *  While string concatenation is simple and convenient, 
             *  string interpolation is growing in popularity in situations 
             *  where you need to combine many literal strings and variables into a single formatted message.
             *  
             *  What is string interpolation?
             *  String interpolation combines multiple values into a single literal string
             *  by using a "template" and one or more interpolation expressions. 
             *  An interpolation expression is indicated by an opening and closing curly brace symbol { }. 
             *  You can put any C# expression that returns a value inside the braces. 
             *  The literal string becomes a template when it's prefixed by the $ character.
             *  In other words, instead of writing the following lines of code:
             */

            /*
            string firstName = "Bob";
            string greeting = "Hello";
            Console.WriteLine(greeting + " " + firstName + "!");
            */

            //  Write this instead

            //string firstName = "Bob";
            //string greeting = "Hello";
            //string message = $"{greeting} {firstName}!";
            //Console.WriteLine(message);

            /*
             * In this simple example, you save a few keystrokes. 
             * You can imagine how much more concise string interpolation can be in more complex operations.
             * Moreover, many find the string interpolation syntax cleaner and easier to read.
             * 
             * In the following exercise, you'll rewrite the previous messages using string interpolation.
            */

            // Use string interpolation to combine a literal string and a variable value
            //To interpolate two strings together, you create a literal string and prefix the string with the $ symbol.
            //The literal string should contain at least one set of curly braces { }
            //and inside of those characters you use the name of a variable.

            string firstName = "Bob";
            string message = $"Hello {firstName}";
            Console.WriteLine(message);

            // Use string interpolation with multiple variables and literal strings
            //You can perform several interpolation operations in the same line of code.
            int version = 11;
            string updateText = "Update to Windows";
            //string updateMessage = $"{updateText} {version}!";
           // Console.WriteLine(updateMessage);

            // Avoid intermediate variables
            // Just as you did in the previous exercise,
            // you can eliminate the temporary variable to store the message.
            Console.WriteLine($"{updateText} {version}!");

            //Combine verbatim literals and string interpolation
            //Suppose you need to use a verbatim literal in your template.
            //You can use both the verbatim literal prefix symbol @ and the string interpolation $ symbol together.

            string projectName = "First-Project";
            Console.WriteLine($@"C:\Output\{projectName}\Data");
            // In this example,
            // the $ symbol allows you to reference the projectName variable inside the braces,
            // while the @ symbol allows you to use the unescaped \ character.

            /* Recap:
             *   Here's what you've learned about string interpolation so far:
             *   String interpolation provides an improvement over string concatenation by reducing the number of characters required in some situations.
             *   You can combine string interpolation and verbatim literals by combining the symbols for each and using that as a prefix for the string template.
             */

        }
    }
}
