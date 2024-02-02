using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Module_03
{
    internal class Program
    {
        static void Main(string[] args)
        {  // Link: https://learn.microsoft.com/en-us/training/modules/csharp-if-elseif-else/
            // Unit-2
            // Exercise - Create decision logic with if statements

            Random dice = new Random();

            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);

            int total = roll1 + roll2 + roll3;

            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

            // Add an if statement to display different messages based on the value of the total variable
            if (total > 14)
            { 
                Console.WriteLine("You win!"); 
            }
            if (total < 15)
            {
                Console.WriteLine("You lose!");
            }

            // 
            // 
            // Continue here:   https://learn.microsoft.com/en-us/training/modules/csharp-if-elseif-else/2-exercise-if



        }
    }
}
