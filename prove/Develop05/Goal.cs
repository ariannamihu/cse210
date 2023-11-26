using System;

namespace Develop05;

public class Goal
{
    protected string _name = "";
    protected string _description = "";
    protected int _points = 0;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public Goal(string savedString)
    {

    }

    public virtual int RecordEvent()
    {
        Console.WriteLine($"Your goal has been recorded and {_points} points have been added");
        return _points;
    }

    
    public override string ToString()
    {
        return $"{_name},{_description},{_points}";
    }

    public virtual string ToSavedString(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            outputFile.WriteLine($"1,{this.ToString()}");
        }

        return this.ToString();
    }
}