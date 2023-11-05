using System;

public class Program
{
    static void Main(string[] args)
    {
        bool quit = false;
        
        while (!quit)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Enter your choice (1-4): ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        BreathingActivity breathingActivity1 = new BreathingActivity("breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");

                        breathingActivity1.RunBreathingActivity();

                        break;
                    case 2:
                        GeneralActivity generalActivityReflecting = new GeneralActivity("reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

                        generalActivityReflecting.DisplayStartMessage();
                        generalActivityReflecting.DisplayEndMessage();

                        break;
                    case 3:
                        ListingActivity listing = new ListingActivity("listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

                        listing.RunListingActivity();

                        break;
                    case 4:
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("\nInvalid choice. Please select a valid option (1-4).");
                        break;
                }
            }
            else
            {
                Console.WriteLine("\nPlease enter a valid number (1-5).");
            }
        }
    }
}