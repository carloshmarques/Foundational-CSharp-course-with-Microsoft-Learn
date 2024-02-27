using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://learn.microsoft.com/en-us/training/modules/create-c-sharp-methods-parameters/6-exercise-challenge-email-addresses
            // Unit-6
            // Exercise - Complete the challenge to display email addresses


            // Code challenge: Add a method to display email addresses

            string[,] corporate =
            {
                {"Robert", "Bavin"}, {"Simon", "Bright"},
                {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
                {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
            };

            string[,] external =
            {
                {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
                {"Shay", "Lawrence"}, {"Daren", "Valdes"}
            };

            string externalDomain = "hayworth.com";

            for (int i = 0; i < corporate.GetLength(0); i++)
            {
                // display internal email addresses
                DisplayEmail(first: corporate[i, 0], last: corporate[i, 1]);

            }

            for (int i = 0; i < external.GetLength(0); i++)
            {
                // display external email addresses
                DisplayEmail(first: external[i, 0], last: external[i, 1], domain: externalDomain);
            }

            void DisplayEmail(string first, string last, string domain = "contoso.com")
            {
                string email = first.Substring(0, 2) + last;
                email = email.ToLower();
                Console.WriteLine($"{email}@{domain}");

            }
        }
    }
}
