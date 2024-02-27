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
            // https://learn.microsoft.com/en-us/training/modules/create-c-sharp-methods-return-values/3-exercise-create-methods-return-numbers
            // Unit-3
            // Exercise - Return numbers from methods
            // Create a method that returns an integer

            double usd = 23.73;
            int vnd = UsdToVnd(usd);

            Console.WriteLine($"${usd} USD = ${vnd} VND");
            Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

        }

        static int UsdToVnd(double usd)
        {
            int rate = 23500;
            return (int)(rate * usd);
        }

        static double VndToUsd(int vnd)
        {
            double rate = 23500;
            return vnd / rate;
        }

    }
}
