using System;


class Program
{
    static void Main(string[] args)
    {
        bool exit = false;

        PromptGenerator promptGenerator1 = new PromptGenerator();
        // JournalEntry journalEntry1 = new JournalEntry();
        Journal journal1 = new Journal();

        while (!exit)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Save the journal to a Json file");
            Console.WriteLine("6. Load the journal from a Json file");
            Console.WriteLine("7. Exit");
            Console.Write("Enter your choice (1-7): ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        string prompt = promptGenerator1.GenerateRandomPrompt();
                        Console.Write("Enter your response: ");
                        string response = Console.ReadLine();
                        journal1.AddEntry(prompt, response);

                        break;
                    case 2:
                        journal1.DisplayJournalEntriesList();
                        break;
                    case 3:
                        Console.Write("Enter file name: ");
                        string file = Console.ReadLine();
                        journal1.SaveToFile(file);
                        break;
                    case 4:
                        Console.Write("Enter file name: ");
                        string file1 = Console.ReadLine();
                        journal1.LoadFromFile(file1);
                        break;
                    case 5:
                        Console.Write("Enter file name: ");
                        string Jsonfile = Console.ReadLine();
                        journal1.SaveToJson(Jsonfile);
                        break;
                    case 6:
                        Console.Write("Enter file name: ");
                        string Jsonfile1 = Console.ReadLine();
                        journal1.LoadFromJson(Jsonfile1);
                        break;
                    case 7:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option (1-5).");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number (1-5).");
            }
        }
    }
}
