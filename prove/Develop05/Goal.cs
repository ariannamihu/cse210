using System;

public class Goal
{
    string _name = "";
    string _description = "";
    int _points = 0;
    
    List<string> goals = new List<string> {

    };

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    // public Goal(string savedString)
    // {

    // }

    // public int RecordEvent()
    // {

    // }

    // public string ToSavedString()
    // {

    // }

    public override string ToString()
    {
        return $"{_name} ({_description}) and {_points} points";
    }
}