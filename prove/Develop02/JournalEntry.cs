public class JournalEntry
{
    public string _date { get; set; }
    public string _prompt { get; set; }
    public string _response { get; set; }

    public JournalEntry()
    {
        
    }

    public JournalEntry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    public override string ToString()
    {
        return $"{_date}: {_prompt}\n{_response}\n";
    }
}





