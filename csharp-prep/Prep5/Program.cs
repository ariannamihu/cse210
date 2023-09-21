using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squared = SquareNumber(number);
        DisplayResult(name, squared);

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userInput = Console.ReadLine();
        return userInput;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userInput = Console.ReadLine();
        int num = int.Parse(userInput);
        return num;
    }

    static int SquareNumber(int number)
    {
        int squared = number * number;
        return squared;
    }

    static void DisplayResult(string userName, int squaredNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
    }
}