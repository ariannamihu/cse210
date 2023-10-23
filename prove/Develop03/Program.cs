using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Select a scripture: \n1. Mosiah 2:41 \nHelaman 5:12 \nMosiah 18:8-10 \n(type 1, 2, or 3)");
        string selection = Console.ReadLine();

        int selectionInt = int.Parse(selection);
        int choice = selectionInt - 1;
        
        var scriptureToMemorize = Scripture.scripturesList[choice];

        bool allWordsHidden = false;

        while (!allWordsHidden)
        {
            Console.Clear();
            Console.WriteLine(scriptureToMemorize);
            Console.WriteLine();

            Console.Write("\n\nPress Enter to hide random words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scriptureToMemorize.hideRandomWord();
        }

    }
}
