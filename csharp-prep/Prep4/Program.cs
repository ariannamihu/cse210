using System;

class Program
{
    static void Main(string[] args)
    {
        List<float> numbers = new List<float>();
        float number = 1;
        float sum = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        while (number != 0)
        {
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();
            number = float.Parse(userInput);
            numbers.Add(number);
            sum += number;
        }

        numbers.RemoveAt(numbers.Count - 1);

        float avg = sum / numbers.Count;
        float max = numbers.AsQueryable().Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {max}");
    }
}