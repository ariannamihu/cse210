using System;

public class Swimming : Activity
{
    private float _laps = 0;

    public Swimming(string date, float minutes, float laps)
     : base(date, minutes)
    {
        _laps = laps;
    }

    public override float GetDistance()
    {
        float distance = _laps * 50 / 1000;
        return distance;
    }

    public override float GetSpeed()
    {
        float speed = (GetDistance() / _lengthMin) * 60;
        return speed;
    }

    public override float GetPace()
    {
        float pace = 60 / GetSpeed();
        return pace; 
    }
}