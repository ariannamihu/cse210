using System.Numerics;

namespace Develop05;

public class ChecklistGoal : CompletableGoal
{   
    protected int _bonusAmount = 0;
    protected int _timesCompleted = 0;
    protected int _timesToComplete = 0;
    
    public ChecklistGoal(string name, string description, int points, int timesToComplete, int bonusAmount)
        : base(name, description, points)
    {
        _timesToComplete = timesToComplete;
        _bonusAmount = bonusAmount;
    }



    public override int RecordEvent()
    {
        _timesCompleted += 1;

        if (_timesCompleted == _timesToComplete)
        {
            _isCompleted = true;
        }

        int pointsEarned = _points + _bonusAmount;
        Console.WriteLine($"Your goal has been recorded and {pointsEarned} points have been added");
        return pointsEarned;
    }

    public override string ToSavedString(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            outputFile.WriteLine($"3,{this.ToString()},{_timesCompleted},{_timesToComplete}");

            return this.ToString();
        }
    }
}