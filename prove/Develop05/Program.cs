using System;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;
        
        while (!quit)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");            
            Console.Write("Enter your choice (1-6): ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("The types of Goals are: \n1. Simple Goal \n2. Eternal Goal \n3. Checklist Goal \nWhich type of goal would you like to create? ");
                        string goalOption = Console.ReadLine();
                        Console.WriteLine("What is the name of your goal?");
                        string goalName = Console.ReadLine();
                        Console.WriteLine("What is its description? ");
                        string goalDescription = Console.ReadLine();
                        Console.WriteLine("Points? ");
                        int goalPoints = int.Parse(Console.ReadLine());

                        Goal goal1 = new Goal(goalName, goalDescription, goalPoints);

                        Console.WriteLine(goal1);

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    case 6:
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("\nInvalid choice. Please select a valid option (1-6).");
                        break;
                }
            }
            else
            {
                Console.WriteLine("\nPlease enter a valid number (1-6).");
            }
        }
    }
}