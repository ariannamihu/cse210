using System;

class Program

// Write a program that determines the letter grade for a course accoring to the following scale: A >= 90, B >= 80, C >= 70, D >= 60, F < 60,

{
    static void Main(string[] args)
    {
        Console.Write("What was your grade percentage? ");
        string userInput = Console.ReadLine();
        float grade = float.Parse(userInput);

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
            Console.WriteLine("Congratulations you passed.");
        }
        else if (grade >= 80)
        {
            letter = "B";
            Console.WriteLine("Congratulations you passed.");
        }
        else if (grade >= 70)
        {
            letter = "C";
            Console.WriteLine("Congratulations you passed.");
        }
        else if (grade >= 60)
        {
            letter = "D";
            Console.WriteLine("You did not pass. Better luck next time!");
        }
        else
        {
            letter = "F";
            Console.WriteLine("You did not pass. Better luck next time!");
        }

        Console.WriteLine($"The letter grade you received was: {letter}");
    }
}