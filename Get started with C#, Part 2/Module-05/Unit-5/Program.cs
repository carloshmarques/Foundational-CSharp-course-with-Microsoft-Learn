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
            // Link:  https://learn.microsoft.com/en-us/training/modules/csharp-readable-code/5-challenge
            // Exercise - Complete a challenge activity to improve code readability

            /*
                This code reverses a message, counts the number of times 
                a particular character appears, then prints the results
                to the console window.
            */

            string str = "The quick brown fox jumps over the lazy dog.";

            // convert the message into a char array
            char[] charMessage = str.ToCharArray();

            // Reverse the chars
            Array.Reverse(charMessage);

            int x = 0;
            // count the o's
            foreach (char i in charMessage) 
            { 
                if (i == 'o')
                { 
                    x++; 
                } 
            }

            // convert it back to a string
            string new_message = new String(charMessage);

            // print it out
            Console.WriteLine(new_message);
            Console.WriteLine($"'o' appears {x} times.");

            /*
             * 
            Note
            This code sample may include .NET Class Library methods that are unfamiliar to you. 
            For example, you may not be familiar with the ToCharArray() method of the String class, 
            or the Reverse method of the Array class. 
            You do not need to fully understand the code sample in order to be successful in this challenge.

            Tip
            The high-level purpose of this code is to reverse a string and count the number of times a particular character appears.
             */


        }
    }
}
