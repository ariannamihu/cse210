using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activitiesList = new List<Activity>();
        Running running1 = new Running("05 Dec 2023", 30, 3);
        Cycling cycling1 = new Cycling("04 Oct 2023", 45, 15);
        Swimming swimming1 = new Swimming("14 Nov 2023", 20, 32);

        activitiesList.Add(running1);
        activitiesList.Add(cycling1);
        activitiesList.Add(swimming1);

        foreach (Activity a in activitiesList)
        {
            Console.WriteLine(a.GetSummary());
            Console.WriteLine("");
        }
        
    }
}