using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        string name = "Biloxi Buckwater";

        Assignment assignment = new Assignment(name, "Agriculture");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine();
        MathAssignment mathAssignment = new MathAssignment(name, "Addition", "Section 1.1", "Problems 1-2");
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine();
        WritingAssignment writingAssignment = new WritingAssignment(name, "Creative Writing", "By the Bayou Backwoods");
        Console.WriteLine(writingAssignment.GetWritingInformation());    
    }
}