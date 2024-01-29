using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_06
{
    internal class Program
    {
        static void Main(string[] args)
        {   // link: https://learn.microsoft.com/en-us/training/modules/guided-project-calculate-final-gpa/
            // Guided project - Calculate final GPA

            /*
             * Project overview
             * You're developing a Student GPA Calculator that will help calculate students' overall Grade Point Average. 
             * The parameters for your application are:
             * 
             * You're given the student's name and class information.
             * Each class has a name, the student's grade, and the number of credit hours for that class.
             * Your application needs to perform basic math operations to calculate the GPA for the given student.
             * Your application needs to output/display the student’s name, class information, and GPA.
            To calculate the GPA:

            Multiply the grade value for a course by the number of credit hours for that course.
            Do this for each course, then add these results together.
            Divide the resulting sum by the total number of credit hours.
            You're provided with the following sample of a student's course information and GPA:
            Student: Sophia Johnson

            Course          Grade   Credit Hours	
            English 101         4       3
            Algebra 101         3       3
            Biology 101         3       4
            Computer Science I  3       4
            Psychology 101      4       3

            Final GPA:          3.35

             */

            // Setup:
            // Use the following steps to prepare for the Guided project exercises:

            // initialing variables:

            string studentName = "Sophia Johnson";
            string course1Name = "English 101";
            string course2Name = "Algebra 101";
            string course3Name = "Biology 101";
            string course4Name = "Computer Science I";
            string course5Name = "Psychology 101";

            int course1Credit = 3;
            int course2Credit = 3;
            int course3Credit = 4;
            int course4Credit = 4;
            int course5Credit = 3;

            // Unit-3
            // Exercise - Store the numeric grade values for each course
            /* 
            Review the mockup:

            Course          Grade   Credit Hours	
            English 101         4       3
            Algebra 101         3       3
            Biology 101         3       4
            Computer Science I  3       4
            Psychology 101      4       3

            Final GPA:          3.35

            */

            // Create variables to store the grade values
            int gradeA = 4;
            int gradeB = 3;

            // Create variables that will store the grades for each course;
            int course1Grade = gradeA;
            int course2Grade = gradeB;
            int course3Grade = gradeB;
            int course4Grade = gradeB;
            int course5Grade = gradeA;

            // Unit-4 
            // Calculate the sums of credit hours and grade points
            // Create variables to store the average
            int totalCreditHours = 0;

            // Increment the sum to represent the total number 
            // of credit hours

            totalCreditHours += course1Credit;
            totalCreditHours += course2Credit;
            totalCreditHours += course3Credit;
            totalCreditHours += course4Credit;
            totalCreditHours += course5Credit;

            // create a variable that will store,
            // the total number of grade points earned for each course, 
            int totalGradePoints = 0;

            // increment the sum by the grade points earned for the first course
            totalGradePoints += course1Credit * course1Grade;
            totalGradePoints += course2Credit * course2Grade;
            totalGradePoints += course3Credit * course3Grade;
            totalGradePoints += course4Credit * course4Grade;
            totalGradePoints += course5Credit * course5Grade;

            // Format the decimal output
            decimal gradePointAverage = (decimal) totalGradePoints / totalCreditHours;
            //  initialize a variable that will store the leading digit of the GPA
            int leadingDigit = (int)gradePointAverage;
            // initialize a variable that will store the first two digits after the decimal
            int firstDigit = (int)(gradePointAverage * 10) % 10;
            int secondDigit = (int)(gradePointAverage * 100) % 10;
            // Unit-6
            // Format the output using escaped character sequences

            Console.WriteLine($"Student: {studentName}\n");
            Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");
            Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
            Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
            Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
            Console.WriteLine($"{course4Name}\t\t{course4Grade}\t\t{course4Credit}");
            Console.WriteLine($"{course5Name}\t\t\t{course5Grade}\t\t{course5Credit}");
            Console.WriteLine($"\nFinal GPA:\t\t\t{leadingDigit}.{firstDigit}{secondDigit}");





        }
    }
}
