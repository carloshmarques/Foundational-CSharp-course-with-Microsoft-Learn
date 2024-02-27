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
            // https://learn.microsoft.com/en-us/training/modules/create-c-sharp-methods-return-values/6-exercise-create-methods-return-arrays
            // Exercise - Return arrays from methods
            // Find coins to make change

            // Test your solution
            int target = 80;
            int[] coins = new int[] { 5, 5, 50, 25, 25, 10, 5 };
            int[,] result = TwoCoins(coins, target);

            if (result.Length == 0)
            {
                Console.WriteLine("No two coins make change");
            }
            else
            {
                Console.WriteLine("Change found at positions:");
                for (int i = 0; i < result.GetLength(0); i++)
                {
                    if (result[i, 0] == -1)
                    {
                        break;
                    }
                    Console.WriteLine($"{result[i, 0]},{result[i, 1]}");
                }
            }
        }
        static int[,] TwoCoins(int[] coins, int target)
        {
            int[,] result = { { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 } };
            int count = 0;

            // check each number in the array
            for (int curr = 0; curr < coins.Length; curr++)
            {
                for (int next = curr + 1; next < coins.Length; next++)
                {
                    if (coins[curr] + coins[next] == target)
                    {
                        result[count, 0] = curr;
                        result[count, 1] = next;
                        count++;
                    }
                    if (count == result.GetLength(0))
                    {
                        return result;
                    }
                }
            }
            return (count == 0) ? new int[0,0] : result;         
        }
    }
}
