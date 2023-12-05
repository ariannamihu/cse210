using System;

public abstract class Activity
{
    protected string _date = "";
    protected float _lengthMin = 0;
    // int _distance = 0;
    // int _speed = 0;
    // int _pace = 0;

    public Activity(string date, float minutes)
    {
        _date = date;
        _lengthMin = minutes;
    }

    public abstract float GetDistance();
    public abstract float GetSpeed();
    public abstract float GetPace();
    
    public string GetSummary()
    {
        return $"{_date} Running ({_lengthMin} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}