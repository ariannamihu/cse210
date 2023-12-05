using System;

public class Outdoor : Event
{
    private string _weatherStatement = "";

    public Outdoor(string name, string description, string date, string time, Address address, string weather)
        : base(name, description, date, time, address)
    {
        _weatherStatement = weather;
    }

    public string GenerateFullDetails()
    {
        return $"Outdoor Event \nTitle: {_title} \n{_description} \n{_date}, {_time} \n{_address.ReturnAddress()} \nWeather Statement: {_weatherStatement}";
    }

    public string GenerateShortDescription()
    {
        return $"Outdoor Event \nTitle: {_title} \n{_date}";
    }
}