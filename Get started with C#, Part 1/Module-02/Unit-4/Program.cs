using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Unit_4
{
    internal class Program
    {
        static void Main(string[] args)
        {   // link: https://learn.microsoft.com/en-us/training/modules/csharp-literals-variables/4-exercise-variables


            // Exercise - Setting and getting values from variables
            // Because variables are temporary storage containers for data, they're meant to be written to and read from.
            // You'll get a chance to do both in the following exercise.

            // Exercise - Working with variables
            // In this exercise, you'll declare a variable, assign it a value, retrieve its value, and more.
            // Create your first variable
            string firstName;
            firstName = "Bob";
          
            // To declare a variable, you enter the data type you want to use followed by a name for the variable.
            // To assign a value to a variable, you use the assignment operator, which is a single equals character =.

            Console.WriteLine(firstName);

            // Reassign the value of a variable
            // You can reuse and reassign the variable as many times as you want.This example illustrates that idea.
            firstName = "Liem";
            Console.WriteLine(firstName);
            firstName = "Isabella";
            Console.WriteLine(firstName);
            firstName = "Yasmin";
            Console.WriteLine(firstName);

            // To declare and iniatilize the variable in order to avoid the possibility of an unassigned local variable,
            // it is recommended that you set the value as soon as possible after you declare it.
            // Like so;

            string myName = "Carlos";
            Console.WriteLine(myName);

            // Recap
            // Here's what you've learned about working with variables so far:
            // You must assign(set)
            // a value to a variable before you can retrieve(get)
            // a value from a variable.
            // You can initialize a variable by assigning a value to the variable at the point of declaration.
            // Assignment happens from right to left.
            // You use a single equals character as the assignment operator.
            // To retrieve the value from the variable, you merely use the variable's name.

        }
    }
}
