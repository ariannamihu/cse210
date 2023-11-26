using System;
using System.IO; 

namespace Develop05;

class Program
{
    static void Main(string[] args)
    {
        int _totalPoints = 0;
        int _goalOption = 0;
        string _goalName = "";
        string _goalDescription  = "";
        int _goalPoints = 0;
        string _fileName = "Goals.csv";
        int timesToCompleteGoal = 0;
        int goalBonus = 0;

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

                        if(_goalOption == 1)
                        {
                            SimpleGoal simpleGoal1 = new SimpleGoal(_goalName, _goalDescription, _goalPoints);
                        }
                        else if(_goalOption == 2)
                        {
                            Goal eternalGoal1 = new Goal(_goalName, _goalDescription, _goalPoints);
                        }
                        else
                        {
                            Console.WriteLine("How many times do you need to complete this goal?");
                            timesToCompleteGoal = int.Parse(Console.ReadLine());

                            Console.WriteLine("What is the bonus for completing this goal?");
                            goalBonus = int.Parse(Console.ReadLine());

                            ChecklistGoal checklistGoal1 = new ChecklistGoal(_goalName, _goalDescription, _goalPoints, timesToCompleteGoal, goalBonus);
                        }
                        break;
                    case 3:
                        if(_goalOption == 1)
                        {
                            SimpleGoal simpleGoal2 = new SimpleGoal(_goalName, _goalDescription, _goalPoints);
                            simpleGoal2.ToSavedString(_fileName);
                        }
                        else if(_goalOption == 2)
                        {
                            Goal eternalGoal2 = new Goal(_goalName, _goalDescription, _goalPoints);
                            eternalGoal2.ToSavedString(_fileName);
                        }
                        else
                        {
                            ChecklistGoal checklistGoal2 = new ChecklistGoal(_goalName, _goalDescription, _goalPoints, timesToCompleteGoal, goalBonus);
                            checklistGoal2.ToSavedString(_fileName);
                        }

                        break;
                    case 4:
                        string[] lines = System.IO.File.ReadAllLines(_fileName);

                        foreach (string line in lines)
                        {
                            string[] parts = line.Split(",");

                            string option = parts[0];
                            string name = parts[1];
                            string description = parts[2];
                            string points = parts[3];

                            Console.WriteLine($"{name}: {description}");
                        }

                        break;
                    case 5:
                        Console.WriteLine("The goals are: ");
                        string[] lines2 = System.IO.File.ReadAllLines(_fileName);

                        for (int i = 0; i < lines2.Length; i++)
                        {
                            string[] parts = lines2[i].Split(",");
                   
                            string option = parts[0];
                            string name = parts[1];
                            string description = parts[2];
                            string points = parts[3];
                            Console.WriteLine($"{i + 1}: {name}");                            
                        }

                        Console.WriteLine("Which goal did you accomplish?");
                        int _accomplishedGoal = int.Parse(Console.ReadLine());
                        int goalToAdd = _accomplishedGoal - 1;

                        string[] parts2 = lines2[goalToAdd].Split(",");

                        string option2 = parts2[0];
                        string name2 = parts2[1];
                        string description2 = parts2[2];
                        int points2 = int.Parse(parts2[3]);
                        bool isComplete = bool.Parse(parts2[4]);
                        int timesCompleted2 = int.Parse(parts2[5]);
                        int timesToComplete2 = int.Parse(parts2[6]);

                        if(option2 == "1")
                        {
                            SimpleGoal simpleGoal3 = new SimpleGoal(name2, description2, points2);
                            simpleGoal3.RecordEvent();
                        }
                        else if(option2 == "2")
                        {
                            Goal eternalGoal3 = new Goal(name2, description2, points2);
                            eternalGoal3.RecordEvent();
                        }
                        else
                        {
                            ChecklistGoal checklistGoal3 = new ChecklistGoal(name2, description2, points2, timesCompleted2, timesToComplete2);
                            checklistGoal3.RecordEvent();
                        }

                        // _totalPoints += int.Parse(points2); // Assuming _totalPoints is an integer
                        // Console.WriteLine($"Congratulations! {points2} points have been added to your score!");

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