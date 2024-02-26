using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://learn.microsoft.com/en-us/training/modules/csharp-modify-content/
            // Modify the content of strings using built-in string data type methods in C#

            // Unit-1
            // https://learn.microsoft.com/en-us/training/modules/csharp-modify-content/1-introduction

            // Unit-2
            // https://learn.microsoft.com/en-us/training/modules/csharp-modify-content/2-exercise-indexof-substring

            // Exercise - Use the string's IndexOf() and Substring() helper methods
            /*
             * 
             *  
             * string message = "Find what is (inside the parentheses)";
             * 
             * int openingPosition = message.IndexOf('(');
             * int closingPosition = message.IndexOf(')');
             * 
             * Console.WriteLine(openingPosition);
             * Console.WriteLine(closingPosition);
             */

            // Write code to find parenthesis pairs embedded in a string
            /*
             * string message = "Find what is (inside the parentheses)";
             * 
             * int openingPosition = message.IndexOf('(');
             * int closingPosition = message.IndexOf(')');
             * 
             * Console.WriteLine(openingPosition);
             * Console.WriteLine(closingPosition); 
             */

            // Add code to retrieve the value between parenthesis
            /*
             *   string message = "Find what is (inside the parentheses)";
             *   
             *   int openingPosition = message.IndexOf('(');
             *   int closingPosition = message.IndexOf(')');
             *   
             *   // Console.WriteLine(openingPosition);
             *   // Console.WriteLine(closingPosition);
             *   
             *   int length = closingPosition - openingPosition;
             *   Console.WriteLine(message.Substring(openingPosition, length));
             * 
             */

            // Modify the starting position of the sub string
            /*
             *   string message = "Find what is (inside the parentheses)";
             *   
             *   int openingPosition = message.IndexOf('(');
             *   int closingPosition = message.IndexOf(')');
             *   
             *   openingPosition += 1;
             *   int length = closingPosition - openingPosition;
             *   Console.WriteLine(message.Substring(openingPosition, length));
             *   
             */

            /*
             * By increasing the openingPosition by 1, you skip over the opening parenthesis character.
             * The reason you're using the value 1 is because that is the length of the character. 
             * If you attempt to locate a value starting after a longer string, 
             * for example, <div> or ---, you would use the length of that string instead.
             */

            // Like so:
            /*
             *  string message = "What is the value <span>between the tags</span>?";
             *  
             *  int openingPosition = message.IndexOf("<span>");
             *  int closingPosition = message.IndexOf("</span>");
             *  
             *  openingPosition += 6;
             *  int length = closingPosition - openingPosition;
             *  
             *  Console.WriteLine(message.Substring(openingPosition, length));
             *  
             */

            // Avoid magic values

            /*
             *   Hardcoded strings like "<span>" in the previous code listing are known as "magic strings"
             *   and hardcoded numeric values like 6 are known as "magic numbers". 
             *   These "Magic" values are undesirable for many reasons and you should try to avoid them if possible.
             *   Review the previous code to consider how the code might break if you 
             *   hardcoded the string "<span>" multiple times in your code, 
             *   but misspelled one instance of it as "<sapn>".
             *   
             *   The compiler doesn't catch "<sapn>" at compile time because the value is in a string. 
             *   The misspelling leads to problems at run time, 
             *   and depending on the complexity of your code, it might be difficult to track down.
             *   
             *   Furthermore, if you change the string "<span>" to the shorter "<div>", 
             *   but forget to change the number 6 to 5, then your code produces undesirable results.
             */


            string message = "What is the value <span>between the tags</span>?";

            const string openSpan = "<span>";
            const string closeSpan = "</span>";

            int openingPosition = message.IndexOf(openSpan);
            int closingPosition = message.IndexOf(closeSpan);

            openingPosition += openSpan.Length;
            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));

            /*
             * Take a minute to examine the updated code and the use of the keyword const as used in const string openSpan = "<span>";.
             * The code uses a constant with the const keyword. 
             * A constant allows you to define and initialize a variable whose value can never be changed. 
             * You would then use that constant in the rest of the code whenever you needed that value. 
             * This ensures that the value is only defined once and misspelling the const variable is caught by the compiler.
             * The previous code listing is a safer way to write the same code you examined in the previous section.
             * 
             * Now, if the value of openSpan changes to <div>, the line of code that uses the Length property continues to be valid.
             */

            // Recap
            /*
             *  This unit covered much material. Here's the most important things to remember:

                IndexOf() gives you the first position of a character or string inside of another string.
                IndexOf() returns -1 if it can't find a match.
                Substring() returns just the specified portion of a string, using a starting position and optional length.
                There's often more than one way to solve a problem. You used two separate techniques to find all instances of a given character or string.
                Avoid hardcoded magic values. Instead, define a const variable. A constant variable's value can't be changed after initialization.
             */
        }
    }
}
