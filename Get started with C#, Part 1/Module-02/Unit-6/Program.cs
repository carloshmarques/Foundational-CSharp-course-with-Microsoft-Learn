using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Unit_6
{
    internal class Program
    {
        static void Main(string[] args)
        {     // link:  https://learn.microsoft.com/en-us/training/modules/csharp-literals-variables/6-challenge

            // Complete the challenge
            // In this challenge,
            // you'll write code that will combine literal and variable values into a single message.
            //
            // Challenge: Display literal and variable values
            // Store the following values in variables:

            // Bob
            // 3
            // 34.4

            // These variables should be given names that reflect their purpose.
            // Make sure you select the correct data type for each of the variables based on the type of data it will hold.
            // Finally,
            // you'll combine the variables with literal strings passed into a series of Console.Write() commands to form a complete message.
            //
            // Write code in the.NET Editor to display the following message:

            // "Hello, Bob! You have 3 messages in your inbox.The temperature is 34.4 celsius."

            // Declaring variables here:
            string firstName = "Bob";
            int messages = 3;
            decimal temperature = 34.4m;
            // Output teh message to console:
            Console.Write("Hello,");
            Console.Write(" ");
            Console.Write(firstName + "!");
            Console.Write(" ");
            Console.Write("You have ");
            Console.Write(messages);
            Console.Write(" ");
            Console.Write("messages in your inbox.");
            Console.Write("The temperature is " + temperature + " celsius.");
        }
    }
}
