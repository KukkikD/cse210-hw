using System;
using System.Collections.Generic;
using System.IO;

// Main program class
// Challenge: Address common barriers to journaling.
// Allow users to set a daily reminder to write in their journal.
class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        string fileName = "journal.txt";

        while (true)
        {
            Console.WriteLine("Journal Program Menu:");
            Console.WriteLine("1. Write a new journal entry");
            Console.WriteLine("2. Display journal entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Set daily reminder"); //challenge here
            Console.WriteLine("6. Exit");

            Console.Write("Enter your choice: ");
            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        string prompt = promptGenerator.GeneratePrompt();
                        Console.WriteLine($"{prompt}");
                        Console.Write("Enter your response: ");
                        string response = Console.ReadLine();
                        DateTime date = DateTime.Now; // Assuming you want to use the current date and time
                        journal.AddEntry($"{date:MM/dd/yyyy} - Prompt : {prompt}", response);
                        break;
                    case 2:
                        journal.DisplayEntries();
                        break;
                    case 3:
                        journal.SaveToFile(fileName);
                        break;
                    case 4:
                        journal.LoadFromFile(fileName);
                        break;
                    case 5:
                        Console.Write("Set daily reminder time (HH:mm): ");
                        string reminderTime = Console.ReadLine();
                        if (DateTime.TryParseExact(reminderTime, "HH:mm", null, System.Globalization.DateTimeStyles.None, out DateTime dailyReminder))
                        {
                            // Set a daily reminder logic here.
                            Console.WriteLine($"Daily reminder set for {dailyReminder.ToShortTimeString()}.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid time format. Please use HH:mm format.");
                        }
                        break;
                    case 6:
                        Console.WriteLine("Exiting program.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {  // Challenge :  if user not put the number 1-6 
                Console.WriteLine("Invalid input. Please enter a valid number.");

            }
        }
    }
}

