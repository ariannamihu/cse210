public class BreathingActivity : GeneralActivity
{
    public BreathingActivity(string name, string activityDescription)
        :  base(name, activityDescription)
    {

    }

    public void RunBreathingActivity()
    {
        base.DisplayStartMessage();
        while (_duration > 0)
        {
            Console.WriteLine("Breathe in");
            Thread.Sleep(2000);

            Console.WriteLine("Breathe out\n");
            Thread.Sleep(2000);

            _duration -= 4;
        }
        base.DisplayEndMessage();

    }
}