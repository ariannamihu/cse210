public class GeneralActivity
{
    public int _duration = 0;
    private int _originalDuration = 0;
    private string _activityName = "";
    private string _description = "";
    // private string _endMessage = "";

    public GeneralActivity(string name, string activityDescription)
    {
        _activityName = name;
        _description = activityDescription;
    }

    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"You chose the {_activityName} activity.\n");
        Console.WriteLine(_description);
        
        Console.WriteLine($"\nHow long, in seconds, would you like for your session? ");
        string time = Console.ReadLine();
        int duration = Convert.ToInt32(time);

        _duration = duration;
        _originalDuration = duration;

        CountdownAnimation();
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine("\nGood Job!!");
        Console.WriteLine($"\nYou spent {_originalDuration} seconds on the {_activityName} activity.");

        CountdownAnimation();
        Console.Clear();
    }

    public void CountdownAnimation()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}