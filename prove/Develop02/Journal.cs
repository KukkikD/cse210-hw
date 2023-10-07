using System;
using System.Collections.Generic;
using System.IO;

// Journal class to manage journal entries
public class Journal
{
   private List<Entry> entries = new List<Entry>();

    public void AddEntry(string entryContent, string response)
    {
        entries.Add(new Entry(entryContent, response));
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            entry.DisplayContent();
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Content}|{entry.Response}");
            }
        }
        Console.WriteLine("Journal saved to file.");
    }

    public void LoadFromFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            entries.Clear();
            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] parts = line.Split('|');
                    if (parts.Length == 2)
                    {
                        string entryContent = parts[0];
                        string response = parts[1];
                        AddEntry(entryContent, response);
                    }
                }
            }
            Console.WriteLine("Journal loaded from file:");
            DisplayEntries();
        }
        else
        {
            Console.WriteLine("File not found. Please check the file path.");
        }
    }
}
