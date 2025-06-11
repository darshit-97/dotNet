/*
Student Grading Application
----------------------------
1. This C# console application calculates and displays final grades for students based on their exam and extra credit scores.

2. Each student has 5 exam scores (0–100), and optional extra credit assignments.

3. Extra credit scores (if present) are identified by array length and weighted at 10% of a full exam score.

4. The program calculates the average score, applies extra credit, and assigns a letter grade automatically.

5. Uses arrays and foreach loops to handle students and scores for scalability and easier maintenance.

6. Outputs each student’s name, final numeric grade, and corresponding letter grade in a formatted report.
*/

using System;

// initialize variables - graded assignments 
int examAssignments = 5;

int[] godricScores = new int[] { 90, 86, 87, 98, 100, 94, 80 };
int[] helgaScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] rowenaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] salazarScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

string[] studentNames = new string[] { "Godric", "Helga", "Rowena", "Salazar", "Becky", "Chris", "Eric", "Gregor" };
int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

Console.WriteLine("Student\t\tGrade\n");

foreach (string name in studentNames)
{
    string currentStudent = name;
    if (currentStudent == "Godric")
        studentScores = godricScores;
    else if (currentStudent == "Helga")
        studentScores = helgaScores;
    else if (currentStudent == "Rowena")
        studentScores = rowenaScores;
    else if (currentStudent == "Salazar")
        studentScores = salazarScores;
    else if (currentStudent == "Becky")
        studentScores = beckyScores;
    else if (currentStudent == "Chris")
        studentScores = chrisScores;
    else if (currentStudent == "Eric")
        studentScores = ericScores;
    else if (currentStudent == "Gregor")
        studentScores = gregorScores;
    // else
    //     continue;

    int sumAssignmentScores = 0;
    decimal currentStudentGrade = 0;
    int gradedAssignments = 0;

    foreach (int score in studentScores)
    {
        gradedAssignments += 1;
        if (gradedAssignments <= examAssignments)
            sumAssignmentScores += score;
        else
            sumAssignmentScores += score / 10;
    }

    currentStudentGrade = (decimal)sumAssignmentScores / examAssignments;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";
    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";
    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";
    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";
    else if (currentStudentGrade >= 83)
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
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();