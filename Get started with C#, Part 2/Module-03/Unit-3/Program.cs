using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Unit_3
{
    internal class Program
    {
        static void Main(string[] args)
        {   // https://learn.microsoft.com/en-us/training/modules/csharp-if-elseif-else/3-exercise-elseif-else
            // Exercise - Create nested decision logic with if, else if, and else

           
            Random dice = new Random();

            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);
          
            int total = roll1 + roll2 + roll3;

            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

            // Remove the stacking bonus for doubles and triples using nesting
            if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
            {
                if ((roll1 == roll2) && (roll2 == roll3))
                {
                    Console.WriteLine("You rolled triples! +6 bonus total!");
                    total += 6;
                }
                else
                {
                    Console.WriteLine("You rolled doubles! +2 bonus total!");
                    total += 2;

                }
                Console.WriteLine($"Your total including the bonus: {total}");
            }
            // Use if and else statements instead of two separate if statements
            // Use if, else, and else if statements to give a prize instead of a win-lose message

            if (total >= 16)
            {
                Console.WriteLine("Congrats, you win a new car!");
            }
            else if (total >=10) 
            { 
                Console.WriteLine("Congrats, you win a new laptop!"); 
            }
            else if(total == 7)
            {
                Console.WriteLine("Congrats, you win a trip for two!");

            }
            else
            {
                Console.WriteLine("Congrats, you win a kitten!");
            }
          
          Console.ReadLine();

            /*
             *  The if, else if, and else statements allow you to create multiple exclusive conditions as Boolean expressions.
             *  
             *  In other words, when you only want one outcome to happen, but you have several possible conditions and results, 
             *  use as many else if statements as you want. 
             *  If none of the if and else if statements apply, the final else code block will be executed. 
             *  The else is optional, but it must come last if you choose to include it.
             *  Use the technique of temporarily hard coding the roll variables to test each message.
             *  
             *  Recap
             *  The combination of if and else statements allows you to test for one condition, and then perform one of two outcomes. 
             *  The code block for the if will be run when the Boolean expression is true, 
             *  and the code block for the else will be run when the Boolean expression is false.
             *  You can nest if statements to narrow down a possible condition. 
             *  However, you should consider using the if, else if, and else statements instead.
             *  Use else if statements to create multiple exclusive conditions.
             *  An else is optional, but it must always come last when included.
             */
        }
    }
}
