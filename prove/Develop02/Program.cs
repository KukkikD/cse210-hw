using System;
using System.Collections.Generic;
using System.IO;

// Entry class to represent individual journal entries
class Entry
{
    public string Content { get; set; }

    public Entry(string content)
    {
        Content = content;
    }

    public void DisplayContent()
    {
        Console.WriteLine(Content);
    }
}

// Journal class to manage journal entries
class Journal
{
    private List<Entry> entries = new List<Entry>();

        // Method to add a new journal entry
    public void AddEntry(string entryContent)
    {
        Entry entry = new Entry(entryContent);
        entries.Add(entry);
    }

    // Method to display all journal entries
    public void DisplayEntries()
    {
        Console.WriteLine("Journal Entries:");
        foreach (var entry in entries)
        {
            entry.DisplayContent();
        }
    }

    // Method to save journal entries to a file
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

    // Method to load journal entries from a file
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
        }
        else
        {
            Console.WriteLine("File not found. Please check the file path.");
        }
    }
}

// PromptGenerator class to generate writing prompts
class PromptGenerator
{
    private List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

   // Method to generate a random writing prompt
    public string GeneratePrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}

// Main program class
class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        string fileName = "journal.txt";

        while (true)
        {
             // Display the program menu
            Console.WriteLine("Journal Program Menu:");
            Console.WriteLine("1. Write a new journal entry");
            Console.WriteLine("2. Display journal entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        // Generate a writing prompt, collect a response, and add it as a new journal entry
                        string prompt = promptGenerator.GeneratePrompt();
                        Console.WriteLine($"Prompt: {prompt}");
                        Console.Write("Enter your response: ");
                        string response = Console.ReadLine();
                        journal.AddEntry($"{prompt}: {response}");
                        break;
                    case 2: // Display all journal entries
                        journal.DisplayEntries();
                        break;
                    case 3: // Save journal entries to a file
                        journal.SaveToFile(fileName);
                        break;
                    case 4: // Load journal entries from a file
                        journal.LoadFromFile(fileName);
                        break;
                    case 5: // Exit the program
                        Console.WriteLine("Exiting program.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else //if user not put the number 1-5 
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}