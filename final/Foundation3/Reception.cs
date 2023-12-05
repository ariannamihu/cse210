using System;

public class Reception : Event
{
    private string _email = "";

    public Reception(string name, string description, string date, string time, Address address, string email)
        : base(name, description, date, time, address)
    {
        _email = email;
    }

    public string GenerateFullDetails()
    {
        return $"Reception Event \nTitle: {_title} \n{_description} \n{_date}, {_time} \n{_address.ReturnAddress()} \nEmail RSVP to {_email}";
    }

    public string GenerateShortDescription()
    {
        return $"Reception Event \nTitle: {_title} \n{_date}";
    }
}