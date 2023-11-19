using System;
using System.Collections.Generic;

public class ListingActivity : GeneralActivity
{
    List<string> answers = new List<string>
    {

    };
        
    string filePath = "/Users/ariannamihu/Desktop/School/cse210/cse210/prove/Develop04/List.csv";

    


    List<string> prompts = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    
    public ListingActivity(string name, string activityDescription)
        :  base(name, activityDescription)
    {

    }

    public void SaveToFile(string file, string answers)
    {
        using (StreamWriter writer = new StreamWriter(file, true))
        {
            writer.WriteLine(answers);
        }
        Console.WriteLine("Your answers have been saved.");
    }

    public void RunListingActivity()
    {
        base.DisplayStartMessage();

        Random random = new Random();
        int index = random.Next(prompts.Count);
        Console.WriteLine(prompts[index]);

        base.CountdownAnimation();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Write down an item to add to the list:");
            string listItem = Console.ReadLine();
            answers.Add(listItem);
            SaveToFile(filePath, listItem);
        }

        Console.WriteLine(answers);

        base.DisplayEndMessage();

        answers.Clear();
    }
}