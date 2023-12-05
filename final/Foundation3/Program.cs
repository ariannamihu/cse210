using System;

class Program
{
    static void Main(string[] args)
    {
        Address lecture1Address = new Address("Cherry Lane", "Provo", "Utah", "USA");
        Lecture lecture1 = new Lecture("Sewing Class", "This class will teach the basics of how to use a sewing machine", "12/29/23", "10:30am", lecture1Address, "Sabrina Jones", 50);

        Console.WriteLine(lecture1.StandardMessage());
        Console.WriteLine("");
        Console.WriteLine(lecture1.GenerateFullDetails());
        Console.WriteLine("");
        Console.WriteLine(lecture1.GenerateShortDescription());
        Console.WriteLine("");

        Address reception1Address = new Address("1294 Boulder Circle", "London", "England", "United Kingdom");
        Reception reception1 = new Reception("Wedding", "This is the wedding of Joe and Sarah", "05/28/24", "6:00pm", reception1Address, "joeandsarah@wedding.com");

        Console.WriteLine(reception1.StandardMessage());
        Console.WriteLine("");
        Console.WriteLine(reception1.GenerateFullDetails());
        Console.WriteLine("");
        Console.WriteLine(reception1.GenerateShortDescription());
        Console.WriteLine("");

        Address outdoorAddress = new Address("3937 Eagle Drive", "Lehi", "Utah", "United States");
        Outdoor outdoorEvent = new Outdoor("Swimming", "A swimming and kayaking party in the lake", "07/07/2024", "4:30pm", outdoorAddress, "The weather will be hot and sunny so bring sunscreen!");

        Console.WriteLine(outdoorEvent.StandardMessage());
        Console.WriteLine("");
        Console.WriteLine(outdoorEvent.GenerateFullDetails());
        Console.WriteLine("");
        Console.WriteLine(outdoorEvent.GenerateShortDescription());
        Console.WriteLine("");
    }
}