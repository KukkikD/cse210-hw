using System;

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
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        string prompt = promptGenerator.GeneratePrompt();
                        Console.WriteLine($"Prompt: {prompt}");
                        Console.Write("Enter your response: ");
                        string response = Console.ReadLine();
                        journal.AddEntry($"{prompt}: {response}");
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
                        Console.WriteLine("Exiting program.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}
