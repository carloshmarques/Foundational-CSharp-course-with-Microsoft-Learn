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
            // https://learn.microsoft.com/en-us/training/modules/create-c-sharp-methods-parameters/3-exercise-understand-method-scope
            // Unit-3
            // Exercise - Understand method scope

            // Test variable scope
            string[] students = { "Jenna", "Ayesha", "Carlos", "Viktor" };

            DisplayStudents(students);
            DisplayStudents(new string[] { "Robert", "Vanya" });

            double pi = 3.14159;
            PrintCircleInfo(12);
            PrintCircleInfo(24);

            void PrintCircleInfo(int radius)
            {
                Console.WriteLine($"Circle with radius {radius}");
                PrintCircleArea(radius);
                PrintCircleCircumference(radius);
            }

            void PrintCircleArea(int radius)
            {
                double area = pi * (radius * radius);
                Console.WriteLine($"Area = {area}");
            }

            void PrintCircleCircumference(int radius)
            {
                double circumference = 2 * pi * radius;
                Console.WriteLine($"Circumference = {circumference}");
            }


        }
    
        static void DisplayStudents(string[] students)
        {
            foreach (string student in students)
            {
                Console.Write($"{student}, ");
            }
            Console.WriteLine();
        }

        /*
         * Recap
            Here's what you've learned about method scope so far:

            Variables declared inside of a method are only accessible to that method.
            Variables declared in top-level statements are accessible throughout the program.
            Methods don't have access to variables defined within different methods.
            Methods can call other methods.
         */
    }
}
