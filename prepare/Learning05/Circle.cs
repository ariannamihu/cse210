using System;


public class Circle : Shape
{
    public Circle(string color, double radius)
        : base(color)
    {
        _radius = radius;
    }

    private double _radius = 0;

    public override double GetArea()
    {
        double pi = Math.PI;
        double area = pi * (_radius * _radius);

        return area;
    }

}