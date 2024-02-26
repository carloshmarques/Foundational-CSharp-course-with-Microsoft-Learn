﻿using System;
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
            // https://learn.microsoft.com/en-us/training/modules/csharp-modify-content/3-exercise-lastindexof-indexofany
            // Unit-3
            // Exercise - Use the string's IndexOfAny() and LastIndexOf() helper methods

            // Retrieve the last occurrence of a sub string
            /*
             *  string message = "(What if) I am (only interested) in the last (set of parentheses)?";
                int openingPosition = message.LastIndexOf('(');

                openingPosition += 1;
                int closingPosition = message.LastIndexOf(')');
                int length = closingPosition - openingPosition;
                Console.WriteLine(message.Substring(openingPosition, length));

             */

            // Retrieve all instances of substrings inside parentheses
            /*
            string message = "(What if) there are (more than) one (set of parentheses)?";
            while (true)
            {
                int openingPosition = message.IndexOf('(');
                if (openingPosition == -1) break;

                openingPosition += 1;
                int closingPosition = message.IndexOf(')');
                int length = closingPosition - openingPosition;
                Console.WriteLine(message.Substring(openingPosition, length));

                // Note the overload of the Substring to return only the remaining 
                // unprocessed message:
                message = message.Substring(closingPosition + 1);
            }
            */

            // Work with different types of symbol sets
            /*
            string message = "Help (find) the {opening symbols}";
            Console.WriteLine($"Searching THIS Message: {message}");
            char[] openSymbols = { '[', '{', '(' };
            int startPosition = 5;
            int openingPosition = message.IndexOfAny(openSymbols);
            Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

            openingPosition = message.IndexOfAny(openSymbols, startPosition);
            Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message.Substring(openingPosition)}");
            */

            string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

            // The IndexOfAny() helper method requires a char array of characters. 
            // You want to look for:

            char[] openSymbols = { '[', '{', '(' };

            // You'll use a slightly different technique for iterating through 
            // the characters in the string. This time, use the closing 
            // position of the previous iteration as the starting index for the 
            //next open symbol. So, you need to initialize the closingPosition 
            // variable to zero:

            int closingPosition = 0;

            while (true)
            {
                int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

                if (openingPosition == -1) break;

                string currentSymbol = message.Substring(openingPosition, 1);

                // Now  find the matching closing symbol
                char matchingSymbol = ' ';

                switch (currentSymbol)
                {
                    case "[":
                        matchingSymbol = ']';
                        break;
                    case "{":
                        matchingSymbol = '}';
                        break;
                    case "(":
                        matchingSymbol = ')';
                        break;
                }

                // To find the closingPosition, use an overload of the IndexOf method to specify 
                // that the search for the matchingSymbol should start at the openingPosition in the string. 

                openingPosition += 1;
                closingPosition = message.IndexOf(matchingSymbol, openingPosition);

                // Finally, use the techniques you've already learned to display the sub-string:

                int length = closingPosition - openingPosition;
                Console.WriteLine(message.Substring(openingPosition, length));

                /*
                 *  Recap
                 *  Here are two important things to remember:
                 *  LastIndexOf() returns the last position of a character or string inside of another string.
                 *  IndexOfAny() returns the first position of an array of char that occurs inside of another string.
                 */
            }

        }
    }
}