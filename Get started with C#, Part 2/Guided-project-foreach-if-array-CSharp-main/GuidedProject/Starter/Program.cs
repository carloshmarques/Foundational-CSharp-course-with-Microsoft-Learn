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
    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t?");
}
Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
