using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guidedproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://learn.microsoft.com/en-us/training/modules/guided-project-visit-petting-zoo/

            //  Unit-1
            //  https://learn.microsoft.com/en-us/training/modules/guided-project-visit-petting-zoo/1-introduction

            // Unit-2
            // https://learn.microsoft.com/en-us/training/modules/guided-project-visit-petting-zoo/2-prepare

            // Initial code here:
            string[] pettingZoo =
            {
                "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
                "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
                "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
            };

            PlanSchoolVisit("School A");
            PlanSchoolVisit("School B", 3);
            PlanSchoolVisit("School C", 2);

            void PlanSchoolVisit(string schoolName, int groups = 6)
            {
                RandomizeAnimals();
                string[,] group = AssignGroup(groups);
                Console.WriteLine(schoolName);
                PrintGroup(group);
            }


            void RandomizeAnimals()
            {
                // Create a method to shuffle an array
                Random random = new Random();

                for (int i = 0; i < pettingZoo.Length; i++) 
                {
                    int r = random.Next(i, pettingZoo.Length);

                    string temp = pettingZoo[i];
                    pettingZoo[i] = pettingZoo[r];
                    pettingZoo[r] = temp;

                }
            }

            string[,] AssignGroup(int groups = 6)
            {
                string[,] result = new string[groups, pettingZoo.Length / groups];

                int start = 0;

                for (int i = 0; i < groups; i++)
                {
                    for (int j = 0; j < result.GetLength(1); j++)
                    {
                        result[i, j] = pettingZoo[start++];
                    }
                }

                return result;
            }

            void PrintGroup(string[,] groups)
            {
                for (int i = 0; i < groups.GetLength(0); i++)
                {
                    Console.Write($"Group {i + 1}: ");
                    for (int j = 0; j < groups.GetLength(1); j++)
                    {
                        Console.Write($"{groups[i, j]}  ");
                    }
                    Console.WriteLine();
                }
            }
        }       
    }
}
