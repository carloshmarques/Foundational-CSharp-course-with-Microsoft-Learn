using System;
using System.Runtime.CompilerServices;

// initialize variables - graded assignments 
int currentAssignments = 5;

// Sophia assignement score's array 
int[] sophiaScores = new int[] {90, 86, 87, 98, 100};

// Andrew assignement score's array 
int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };

// Emma assignement score's array 
int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };

// Logan assignement score's array
int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

// Create a student names array and outer foreach loop

//Student names:
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

// Nested loop to calculate all student scores
int[] studentScores = new int[10];

// Hold the student's letter grade
string currentStudentLetterGrade = "";

// Write the Report Header to the console
Console.WriteLine("Student\t\tGrade\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if(currentStudent == "Sophia")    
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    // initialize/reset the sum of scored assignments
    int sumAssignmentScores = 0;

    // initialize/reset the calculated average of exam + extra credit scores
    decimal currentStudentGrade = 0;

    foreach (int score in studentScores)
    {
        // add the exam score to the sum
        sumAssignmentScores += score;

    }

    currentStudentGrade = (decimal)(sumAssignmentScores) / currentAssignments;

    // Calculate the and assign student's Grade 
    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");

    // continue here: https://learn.microsoft.com/en-us/training/modules/guided-project-arrays-iteration-selection/5-exercise-implement-selection-statements
}
Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
