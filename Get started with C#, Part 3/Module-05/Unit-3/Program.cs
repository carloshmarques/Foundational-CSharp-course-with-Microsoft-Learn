using System;
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
            // https://learn.microsoft.com/en-us/training/modules/csharp-do-while/3-challenge
            // Exercise -
            // Complete a challenge activity using do and while iteration statements

            // Code challenge - write code to implement the game rules

            /* Output
             *  Monster was damaged and lost 1 health and now has 9 health.
                Hero was damaged and lost 1 health and now has 9 health.
                Monster was damaged and lost 7 health and now has 2 health.
                Hero was damaged and lost 6 health and now has 3 health.
                Monster was damaged and lost 9 health and now has -7 health.
                Hero wins!
             */
            // Code Here:
            int hero = 10;
            int monster = 10;

            Random dice = new Random();

            do
            {
                int roll = dice.Next(1,11);
                monster -= roll;
                Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster}");

                if(monster <= 0) continue;
                roll = dice.Next(1,11);
                hero -= roll;
                Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero}");


            } while (hero > 0 && monster > 0);

            Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");



        }
    }
}
