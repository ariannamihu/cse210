using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square shape1 = new Square("orange", 12);
        Rectangle shape2 = new Rectangle("blue", 10, 4);
        Circle shape3 = new Circle("pink", 5);

        shapes.Add(shape1);
        shapes.Add(shape2);
        shapes.Add(shape3);
        
        foreach (Shape e in shapes)
        {
            string color = e.GetColor();
            double area = e.GetArea();

            Console.WriteLine($"{color},{area}");
        }
        
        // Square square1 = new Square("orange", 12);
        // string color = square1.GetColor();
        // double area = square1.GetArea();

        // Console.WriteLine(color);
        // Console.WriteLine(area);

        // Rectangle rectangle1 = new Rectangle("blue", 10, 4);
        // string rectangleColor = rectangle1.GetColor();
        // double rectangleArea = rectangle1.GetArea();

        // Console.WriteLine(rectangleColor);
        // Console.WriteLine(rectangleArea);

        // Circle circle1 = new Circle("pink", 5);
        // string circleColor = circle1.GetColor();
        // double circleArea = circle1.GetArea();

        // Console.WriteLine(circleColor);
        // Console.WriteLine(circleArea);
    }
}