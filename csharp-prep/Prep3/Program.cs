using System;

class Program

// Write a program that determines picks a magic number, and then the user tries to guess it. After each guess, the computer tells the user to guess "higher" or "lower" until they guess the magic number.
{
    static void Main(string[] args)
    {
        Random randomGenorator = new Random();
        int magicNumber = randomGenorator.Next(1, 20);

        
        float guess = -1;

        do
        {
            Console.Write("What is your guess? ");
            string userInput2 = Console.ReadLine();
            guess = float.Parse(userInput2);
            
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess == magicNumber)
            {
                Console.Write("Congratulations you guessed it!");
            }
        } while (guess != magicNumber);
    }
}