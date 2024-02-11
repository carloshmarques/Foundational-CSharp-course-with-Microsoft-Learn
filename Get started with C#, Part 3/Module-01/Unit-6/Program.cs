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
            // https://learn.microsoft.com/en-us/training/modules/csharp-evaluate-boolean-expressions/6-challenge-2
            // Exercise - Complete a challenge activity using Boolean expressions

            // Code here:
            string permission = "Admin|Manager";
            int level = 53;

            if (permission.Contains("Admin"))
            {
                
                if(level > 55)
                {
                    Console.WriteLine("Welcome, Super Admin user.");
                }
                else 
                {
                    Console.WriteLine("Welcome, Admin.");
                }
            }
            else if (permission.Contains("Manager"))
            {
                if (level >= 20)
                {
                    Console.WriteLine("Contact an Admin for access.");
                }
                else
                {
                    Console.WriteLine("You do not have sufficient privileges.");
                }

            }
            else 
            {
                Console.WriteLine("You do not have sufficient privileges.");
            }
        }
    }
}
