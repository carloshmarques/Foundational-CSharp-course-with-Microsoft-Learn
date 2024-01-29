using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_05_Guided_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {     // https://learn.microsoft.com/en-us/training/modules/guided-project-calculate-print-student-grades/

            // Guided project - Calculate and print student grades
            /*
             * Project overview
             * You're developing a Student Grading application that automates the calculation of current grades for each student in a class. 
             * The parameters for your application are:
             * 
             * You're given a short list of four students and their five assignment grades.
             * Each assignment grade is expressed as an integer value, 0-100, where 100 represents 100% correct.
             * Final scores are calculated as an average of the five assignment scores.
             * Your application needs to perform basic math operations to calculate the final grades for each student.
             * Your application needs to output/display each student’s name and final score.
             * Currently, the teachers grade book shows the graded assignments for each student as follows:
             * 
             *  Sophia: 93, 87, 98, 95, 100
             *  Nicolas: 80, 83, 82, 88, 85
             *  Zahirah:   84, 96, 73, 85, 79
             *  Jeong:  90, 92, 98, 100, 97
             *  
             *  The teacher requires that the calculated grades for each student are displayed as follows:
             *  Student     Grade
             *  Sophia      94.6  A
             *  Nicolas     83.6  B
             *  Zahirah     83.4  B
             *  Jeong       95.4  A
             */

            // Setup
            // Use the following steps to prepare for the Guided project exercises:

            // initialize variables - graded assignments 
            int currentAssignments = 5;

            int sophia1 = 93;
            int sophia2 = 87;
            int sophia3 = 98;
            int sophia4 = 95;
            int sophia5 = 100;

            int nicolas1 = 80;
            int nicolas2 = 83;
            int nicolas3 = 82;
            int nicolas4 = 88;
            int nicolas5 = 85;

            int zahirah1 = 84;
            int zahirah2 = 96;
            int zahirah3 = 73;
            int zahirah4 = 85;
            int zahirah5 = 79;

            int jeong1 = 90;
            int jeong2 = 92;
            int jeong3 = 98;
            int jeong4 = 100;
            int jeong5 = 97;

            // Unit - 3
            // Link : https://learn.microsoft.com/en-us/training/modules/guided-project-calculate-print-student-grades/3-exercise-store-data

            // Exercise - Calculate the sum of each student's assignment scores

            // In this exercise,
            // you'll use the assignment scores for each student to calculate their current grade in the class.
            // To perform this calculation,
            // you'll first sum the values of their assignment scores,
            // and then calculate their average score (their current grade).
            //
            // Let's get started.

            // Sum of student score's variables

            int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
            int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
            int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
            int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

            // Unit 4
            // Link :  https://learn.microsoft.com/en-us/training/modules/guided-project-calculate-print-student-grades/4-exercise-perform-division

            // Exercise - Calculate the average of the student's assignment scores
            // Create variables to store the average

            decimal sophiaScore = (decimal)sophiaSum / currentAssignments;
            decimal nicolasScore = (decimal)nicolasSum / currentAssignments;
            decimal zahirahScore = (decimal)zahirahSum / currentAssignments;
            decimal jeongScore = (decimal)jeongSum / currentAssignments;



            // Console.WriteLine() statements that display the student name
            // and the value of their summed assignment scores:

            // Unit - 5
            // Link: https://learn.microsoft.com/en-us/training/modules/guided-project-calculate-print-student-grades/5-exercise-format-strings

            // Exercise - Format the output using escaped character sequences

            // Format the console output
            Console.WriteLine("Student\t\tGrade\n");
            // Do teh same in the rest of Console.WriteLine Statments:

            Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA");
            Console.WriteLine("Nicolas:\t" + nicolasScore + "\tB");
            Console.WriteLine("Zahirah:\t" + zahirahScore + "\tB");
            Console.WriteLine("Jeong:\t\t" + jeongScore + "\tA");






        }
    }
}
