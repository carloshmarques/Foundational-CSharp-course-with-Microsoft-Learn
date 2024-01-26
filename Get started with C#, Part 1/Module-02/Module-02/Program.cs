using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Module_02
{
    internal class Program
    {
        static void Main(string[] args)
        {    // Link: https://learn.microsoft.com/en-us/training/modules/csharp-literals-variables/
             //
             // Store and retrieve data using literal and variable values in C#

            // Unit-2
            //
            // Exercise - Print literal values

            // Print different literal data types
            // Use of character literals are typed with single quotation marks
           
            
            Console.WriteLine("To output a single char to console allways surround yhe char with single 'b'.\n");
            Console.WriteLine('b');
            // the output in the console is: b

            // Console.WriteLine('Hello World!');
            // this will throw an error "Too many characters in character literal"

            // Notice the single quotation marks surrounding Hello World!.
            // When you use single quotation marks,
            // the C# compiler expects a single character.
            // However, in this case, the character literal syntax was used,
            // but 12 characters were supplied instead!
            Console.WriteLine();
            Console.WriteLine("A string must allways be surrounded with double \"like so\".\n");


            // Just like the string data type,
            // you use char whenever you have a single alphanumeric character for presentation(not calculation).

            // Use integer literals
            // If you want to display a numeric whole number(no fractions) value in the output console,
            // you can use an int literal. The term int is short for integer, which you may recognize from studying math.In C#,
            // this data type is officially named "int",
            // but frequently referred to as "integer".
            // An int literal requires no other operators like the string or char.

            Console.WriteLine();
            Console.WriteLine(123);
            //
            // Use of floating-point literals.
            // A floating-point number is a number that contains a decimal,
            // for example 3.14159.
            // C# supports three data types to represent decimal numbers:
            // float, double, and decimal.

            // Each type supports varying degrees of precision.
            // Float Type    Precision
            // ----------------------------
            // float         ~6 - 9 digits
            // double        ~15 - 17 digits
            // decimal        28 - 29 digits

            Console.WriteLine();
            // To create a float literal, append the letter F after the number.
            Console.WriteLine(0.25F);
            // To create a double literal, just enter a decimal number.
            Console.WriteLine(2.652);
            // To create a decimal literal, append the letter m after the number.
            Console.WriteLine(10.236589m);

            // Use of Boolean literals
            // If you wanted to print a value representing either true or false, you could use a bool literal.
            // The term bool is short for Boolean.
            // In C#, they're officially referred to as "bool", but often developers use the term "Boolean".
            Console.WriteLine(true);
            Console.WriteLine(false);
            // The bool literals represent the idea of truth and falsehood.
            // You'll use bool values extensively when you start to add decision logic to your applications.
            // You'll evaluate expressions to see whether the expression is true or false.

            // Why emphasize data types?

            /* Data types play a central role in C#. 
             * In fact, 
             * the emphasis on data types is one of the key distinguishing features of C# compared to other languages like JavaScript. 
             * The designers of C# believed they can help developers avoid common software bugs by enforcing data types. 
             * You'll see this concept unfold as you learn more about C#.
             * 
             * Data types define capabilities
             * Earlier, 
             * you saw that strings and chars are used for "presentation, not calculation".
             * 
             * If you need to perform a mathematical operation on numeric values, 
             * you should use an int or decimal.
             * 
             * 
             * If you have data that is used for presentation or text manipulation, 
             * you should use a string or char data type.
             * 
             * Suppose you needed to collect data from a user, 
             * like a phone number or postal code.
             * Depending on the country / region where you live, that
             * data may consist of numeric characters.
             * However, 
             * since you rarely perform mathematical calculations on phone numbers and postal codes,
             * you should prefer to use a string data type when working with them.
             * 
             * The same can be said of bool.
             * If you need to work with the words "true" and "false" in your application, 
             * you would use a string.
             * However, 
             * if you need to work with the concept of true or false when performing an evaluation, you use a bool.
             * It's important to know that these values may look like their string literal equivalents.
             * In other words, you may think these statements are the same:
             */

            Console.WriteLine("123");
            Console.WriteLine(123);

            Console.WriteLine("true");
            Console.WriteLine(true);

            // However, it's only the displayed output that appears to be similar.
            // The fact is that the kinds of things you can do with the underlying int or bool will be different than their string equivalent.

            /* Recap
             * 
             * The main takeaway is that there are many data types, 
             * but you'll focus on just a few for now:
             * 
             * string for words, phrases, or any alphanumeric data for presentation, not calculation
             * 
             * char for a single alphanumeric character
             * 
             * int for a whole number
             * 
             * decimal for a number with a fractional component
             * 
             * bool for a true/false value
            */
        }
    }
}
