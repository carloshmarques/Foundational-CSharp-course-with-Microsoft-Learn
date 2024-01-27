using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_5
{
    internal class Program
    {
        static void Main(string[] args)
        {    // Link: https://learn.microsoft.com/en-us/training/modules/csharp-basic-formatting/5-challenge

            // Complete the challenge
            // Code challenges will reinforce what you've learned and help you gain some confidence before continuing on.
            // In this challenge,
            // you'll print instructions to the end user to let them know where your application will output data files.
            // You won't be actually creating any files --you're only interested in displaying formatted instructions to the console window.
            // You'll use what you've learned about character escape sequences,
            // verbatim strings, unicode, and string interpolation to provide instructions in both English and Russian.
            //
            // Challenge: Format and display instructions
            // Begin solving the challenge with the following two lines of code.

            string projectName = "ACME";
            string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434:";
            /*
             * The projectName variable will be used twice in the desired output.
             * The russianMessage variable contains the message "View Russian output" in Russian. 
             * You must use this variable in your code that prints the message.
             * You may not change these two lines of code, but you can add code above and below each line. 
             * You must use these two lines of code to form the desired output.
             * You may only use either the Console.WriteLine() or the Console.Write() method twice.
             * In other words, 
             * to complete this challenge, 
             * you can only create two instructions that actually print output to the console. 
             * If you need to print additional new lines or add any formatting, 
             * you must use what you've learned in this module to accomplish it.
             * Use character escape sequences, verbatim strings, unicode, 
             * and string interpolation to generate the output.
             * 
             * To complete this challenge, your code must produce the following output.
             * View English output:
             *        c:\Exercise\ACME\data.txt
             * Посмотреть русский вывод:
             *        c:\Exercise\ACME\ru-RU\data.txt
             */

            // Format encoding output to console first
            Console.OutputEncoding = Encoding.UTF8;

            string englishOutput = "View English output:\n\t ";
            string englishLocation = $@"C:\Exercise\{projectName}\data.text";
            Console.Write(englishOutput);
            Console.WriteLine(englishLocation);

            string russianOutput = $"{russianMessage}\n\t";
            string russianLocation = $@"C:\Exercise\{projectName}\ru-RU\data.text";
            Console.WriteLine($"{russianOutput} {russianLocation}");


        }
    }
}
