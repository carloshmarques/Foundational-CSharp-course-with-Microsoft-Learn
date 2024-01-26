using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Unit_3
{
    internal class Program
    {
        static void Main(string[] args)
        {   // Link: https://learn.microsoft.com/en-us/training/modules/csharp-literals-variables/3-declaring-variables

            // Declare variables
            // A literal is literally a hard - coded value.
            // Hard - coded values, are values that are constant and unchanged throughout the execution of the program.
            // However, most applications will require you to work with values that you don't know much about ahead of time.
            // In other words, you'll need to work with data that comes from users, from files, or from across the network.

            // When you need to work with data that isn't hard-coded, you'll declare a variable.

            // What is a variable ?
            // A variable is a container for storing a type of value.
            // Variables are important because their values can change, or vary, throughout the execution of a program.
            // Variables can be assigned, read, and changed.You use variables to store values that you intend to use in your code.

            // A variable name is a human - friendly label that the compiler assigns to a memory address.
            // When you want to store or change a value in that memory address,
            // or whenever you want to retrieve the stored value, you just use the variable name you created.

            //Declare a variable
            //To create a new variable, you must first declare the data type of the variable, and then give it a name.
            string firstName;
            /*
             * In this case, you're creating a new variable of type string called firstName. 
             * From now on, this variable can only hold string values.
             * You can choose any name as long as it adheres to a few C# syntax rules for naming variables.
             */
            // Variable name examples

            char userOption;

            int gameScore;

            decimal particlesPerMillion;

            bool processedCustomer;

            // Recap:


            // Here's what you've learned so far about variables:
            // Variables are temporary values you store in the computer's memory.
            // Before you can use a variable, you have to declare it.
            // To declare a variable, you first select a data type for the kind of data you want to store,
            // and then give the variable a name that follows the rules.


        }
    }
}
