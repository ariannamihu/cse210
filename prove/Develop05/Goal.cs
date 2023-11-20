using System;

public class Goal
{
    string _name = "";
    string _description = "";
    int _points = 0;
    

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    // public Goal(string savedString)
    // {

    // }

    public int RecordEvent()
    {
        return _points;
    }

    // public string ToSavedString()
    // {

    // }

    // public void SaveToFile(string file)
    // {
    //     using (StreamWriter writer = new StreamWriter(file, true)) 
    //     {
    //         foreach (var entry in JournalEntriesList)
    //         {
    //             writer.WriteLine($" {entry._date}, {entry._prompt}, {entry._response}");
    //         }
    //     }
    //     Console.WriteLine("The journal entry has been saved.");
    // }

    // public void LoadFromFile(string file)
    // {
    //     using (StreamReader reader = new StreamReader(file, true))
    //     {
    //         var line = reader.ReadLine();
    //         while(line!=null)
    //         {
    //             var splitLine = line.Split(",");
    //             var newEntry = new JournalEntry(splitLine[0], splitLine[1], splitLine[2]);
    //             JournalEntriesList.Add(newEntry);
    //             Console.WriteLine(line);
    //             line = reader.ReadLine();
    //         }
    //     }
    // }

    public override string ToString()
    {
        return $"{_name}|{_description}|{_points}";
    }


}