using System;

public class Running : Activity
{
    private float _distance = 0;

    public Running(string date, float minutes, float distance)
     : base(date, minutes)
    {
        _distance = distance;
    }

    public override float GetDistance()
    {
        return _distance;
    }

    public override float GetSpeed()
    {
        float speed = _distance / _lengthMin * 60;
        return speed;
    }

    public override float GetPace()
    {
        float pace = _lengthMin / _distance;
        return pace; 
    }
}