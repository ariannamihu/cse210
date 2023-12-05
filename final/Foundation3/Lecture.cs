using System;

public class Lecture : Event
{
    private string _speaker = "";
    private int _capacity = 0;

    public Lecture(string name, string description, string date, string time, Address address, string speaker, int capacity)
        : base(name, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GenerateFullDetails()
    {
        return $"Lecture Event \nTitle: {_title} \n{_description} \n{_date}, {_time} \n{_address.ReturnAddress()} \nSpeaker: {_speaker} \nCapacity: {_capacity}";
    }

    public string GenerateShortDescription()
    {
        return $"Lecture Event \nTitle: {_title} \n{_date}";
    }
}