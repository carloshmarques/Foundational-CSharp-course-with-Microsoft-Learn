﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://learn.microsoft.com/en-us/training/modules/create-c-sharp-methods-return-values/7-exercise-challenge-dice-game
            // Exercise - Complete the challenge to add methods to make the game playable
            // Dice mini-game challenge

            // Code challenge: add methods to make the game playable

            Random random = new Random();

            Console.WriteLine("Would you like to play? (Y/N)");
            if (ShouldPlay())
            {
                PlayGame();
            }

            bool ShouldPlay()
            {
                string response = Console.ReadLine();
                return response.ToLower().Equals("y");
            }

            void PlayGame()
            {
                var play = true;

                while (play)
                {
                    var target = GetTarget();
                    var roll = RollDice();

                    Console.WriteLine($"Roll a number greater than {target} to win!");
                    Console.WriteLine($"You rolled a {roll}");
                    Console.WriteLine(WinOrLose(roll, target));
                    Console.WriteLine("\nPlay again? (Y/N)");

                    play = ShouldPlay();
                }
            }

            int GetTarget()
            {
                return random.Next(1, 6);
            }

            int RollDice()
            {
                return random.Next(1, 7);
            }

            string WinOrLose(int roll, int target)
            {
                if (roll > target)
                {
                    return "You win!";
                }
                return "You lose!";
            }





        }
       
    }
}
