using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;

namespace WriteYourFirstCode
{
    internal class Program
    {
        static void Main(string[] args)
        {   // link : https://learn.microsoft.com/en-us/training/modules/csharp-write-first/


            // Unit-2

            // link : https://learn.microsoft.com/en-us/training/modules/csharp-write-first/2-exercise-hello-world

            // Exercise - Write your first code

            Console.WriteLine("Hello World!");

            // What to do if you get an error message
            // Writing C# code is an exercise in precision.
            // If you type just one character incorrectly,
            // you'll get an error message in the output area when you run the code.
            // For example, if you were to incorrectly enter a lower-case c in the word console like so:

            //console.WriteLine("Hello World!");

            // You'd get the following error message:

            // Output
            // (1, 1): error CS0103: The name 'console' does not exist in the current context

            // The first part (1,1) indicates the line and column where the error occurred.

            // But what does this error message mean?

            // C# is a case-sensitive language, meaning that the C# compiler considers the words console and Console as different as the words cat and dog.
            // Sometimes, the error message can be a bit misleading.
            // You'll need to understand the true reason why the error exists,
            // and that comes through learning more about C#'s syntax.

            //Similarly, if you used single-quotation marks (') to surround the literal string Hello World! like so:

            //Console.WriteLine('Hello World!');

            //You would get the following error message:

            //Output
            //(1, 19): error CS1012: Too many characters in character literal

            /* Again, in line 1, character 19 points to the culprit. 
             * You can use the message as a clue as you investigate the problem.
             * But what does the error message mean? 
             * What exactly is a "character literal?" 
             * Later, you'll learn more about literals of various data types (including character literals). 
             * For now, be careful when you're entering code.
             * 
             * Fortunately, errors are never permanent. 
             * You merely spot the error, fix it, and rerun your code.
             * 
             * If you got an error when you ran your code, 
             * take a moment to look at it closely.
             * Examine each character and make sure you entered this line of code exactly.
             * 
             * Note: 
             * The code editor is constantly monitoring the code you write by performing pre - compilation to find potential errors. 
             * It will try to help you by adding red squiggly lines underlining the code that will produce an error.
             * 
             * 
             * Common mistakes new programmers make:
             * 
             * Entering lower-case letters instead of capitalizing C in Console, or the letters W or L in WriteLine.
             * Entering a comma instead of a period between Console and WriteLine.
             * Forgetting to use double-quotation marks, or using single-quotation marks to surround the phrase Hello World!.
             * Forgetting a semi - colon at the end of the command.
             */


            // Display a new message

            Console.WriteLine();
            Console.Write("Congratulations!");
            Console.Write(" ");
            Console.Write("You wrote your first line of code!");
            Console.ReadLine();

            /*  Unit-3
             *  Link: https://learn.microsoft.com/pt-pt/training/modules/csharp-write-first/3-how-it-works
             *  
             *  
             * The difference between Console.Write and Console.WriteLine
             * 
             * he three new lines of code you added demonstrated the difference between the Console.WriteLine() and Console.Write methods.
             * To print an entire message to the output console, 
             * you used the first technique, Console.WriteLine(). 
             * 
             * 
             * At the end of the line, 
             * it added a line feed similar to how to create a new line of text by pressing Enter or Return.
             * To print to the output console, 
             * but without adding a line feed at the end, 
             * you used the second technique, Console.Write(). 
             * So, the next call to Console.Write() prints another message to the same line.
             * Congratulations on writing your first lines of code!
             */
        }
    }
}
