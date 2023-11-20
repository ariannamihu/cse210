using System;

public class Goal
{
    string _name = "";
    string _description = "";
    int _points = 0;
    

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

    public int RecordEvent()
    {
        return _points;
    }

    public override string ToString()
    {
        return $"{_name},{_description},{_points}";
    }


}