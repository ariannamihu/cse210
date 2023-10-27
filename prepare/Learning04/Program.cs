using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Arianna", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine();

        MathAssignment mathAssignment1 = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment writingAssignment1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War 11");
        Console.WriteLine(writingAssignment1.GetSummary());
        Console.WriteLine(writingAssignment1.GetWritingInformation());
        Console.WriteLine();
    }
}