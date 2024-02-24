using System;
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
            //  https://learn.microsoft.com/en-us/training/modules/csharp-arrays-operations/7-challenge-2
            // Exercise - Complete a challenge to parse a string of orders, sort the orders and tag possible errors

            // Initial code:
            string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

            string[] items = orderStream.Split(',');
            Array.Sort(items);

            foreach ( var item in items )
            {
                if(item.Length == 4)
                {
                    Console.WriteLine(item);

                } 
                else
                {
                    Console.WriteLine(item + "\t- error");
                }
            }
          
        }
    }
}
