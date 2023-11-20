using System;

class Program
{
    static void Main(string[] args)
    {
        int _totalPoints = 0;
        int _goalOption = 0;
        string _goalName = "";
        string _goalDescription  = "";
        int _goalPoints = 0;

        List<string> goalsList = new List<string> {

        };
        
        bool quit = false;
        
        while (!quit)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Display Score");
            Console.WriteLine("2. Create New Goal");
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
                        Console.WriteLine($"Your score is {_totalPoints}");

                        break;
                    case 2:
                        Console.WriteLine("The types of Goals are: \n1. Simple Goal \n2. Eternal Goal \n3. Checklist Goal \nWhich type of goal would you like to create? ");
                        _goalOption = int.Parse(Console.ReadLine());
                        
                        Console.WriteLine("What is the name of your goal?");
                        _goalName = Console.ReadLine();

                        Console.WriteLine("What is its description? ");
                        _goalDescription = Console.ReadLine();

                        Console.WriteLine("Points? ");
                        _goalPoints = int.Parse(Console.ReadLine());

                        Goal goal1 = new Goal(_goalName, _goalDescription, _goalPoints);

                        Console.WriteLine(goal1);

                        break;
                    case 3:
                        Goal goal2 = new Goal(_goalName, _goalDescription, _goalPoints);

                        goalsList.Add(goal2.ToString());
                        break;
                    case 4:
                        goalsList.ForEach(p => Console.WriteLine(p));

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