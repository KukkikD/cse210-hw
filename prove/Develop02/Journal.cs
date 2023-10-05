using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(string entryContent)
    {
        Entry entry = new Entry(entryContent);
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        Console.WriteLine("Journal Entries:");
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
                writer.WriteLine(entry.Content);
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
                    string entryContent = reader.ReadLine();
                    AddEntry(entryContent);
                }
            }
            Console.WriteLine("Journal loaded from file.");
            DisplayEntries(); // Display the loaded entries
        }
        else
        {
            Console.WriteLine("File not found. Please check the file path.");
        }
    }
}
