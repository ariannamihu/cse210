using System;

public class Cycling : Activity
{
    private float _speed = 0;

    public Cycling(string date, float minutes, float speed)
     : base(date, minutes)
    {
        _speed = speed;
    }

    public override float GetDistance()
    {
        float distance = _speed * _lengthMin;
        return distance;
    }

    public override float GetSpeed()
    {
        return _speed;
    }

    public override float GetPace()
    {
        float pace = 60 / _speed;
        return pace; 
    }
}