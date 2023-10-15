using System;
using System.Text.Json;

class Journal 

{
    public List<JournalEntry> JournalEntriesList = new List<JournalEntry>();

    public void AddEntry (string prompt, string response)
    {
        string date = DateTime.Now.ToString("dd-MM-yyyy");
        JournalEntry entry = new JournalEntry(date, prompt, response);
        JournalEntriesList.Add (entry);
    }

    public void DisplayJournalEntriesList ()
    {
        foreach (var entry in JournalEntriesList)
        {
            Console.WriteLine (entry);
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file, true)) 
        {
            foreach (var entry in JournalEntriesList)
            {
                writer.WriteLine($" {entry._date}, {entry._prompt}, {entry._response}");
            }
        }
        Console.WriteLine("The journal entry has been saved.");
    }

    public void LoadFromFile(string file)
    {
        using (StreamReader reader = new StreamReader(file, true))
        {
            var line = reader.ReadLine();
            while(line!=null)
            {
                var splitLine = line.Split(",");
                var newEntry = new JournalEntry(splitLine[0], splitLine[1], splitLine[2]);
                JournalEntriesList.Add(newEntry);
                Console.WriteLine(line);
                line = reader.ReadLine();
            }
        }
    }

    public void SaveToJson(string file)
    {
        using (StreamWriter writer = new StreamWriter(file, true)) 
        {
            foreach (var entry in JournalEntriesList)
            {
                writer.WriteLine(JsonSerializer.Serialize(entry));
            }
        }
        Console.WriteLine("The journal entry has been saved to Json file.");
    }

    public void LoadFromJson(string file)
    {
        using (StreamReader reader = new StreamReader(file, true))
        {
            var line = reader.ReadLine();
            while(line!=null)
            {
                var newEntry = JsonSerializer.Deserialize<JournalEntry>(line);
                JournalEntriesList.Add(newEntry);
                Console.WriteLine(line);
                line = reader.ReadLine();
            }
        }
    }
}