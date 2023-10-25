using System;
using System.Collections.Generic;
using System.Diagnostics; // Add this using directive for Stopwatch
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var scriptureText = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
        var scriptureReference = new Reference("John", 3, 16); // Single verse example
        // For verse range: var scriptureReference = new Reference("Proverbs", 3, 5, 6);

        var scripture = new Scripture(scriptureReference, scriptureText);

        Console.WriteLine("Scripture Passage: " + scripture.GetVisibleText());
        Console.WriteLine("\nWelcome to the Scripture Memorizer!");
        Console.WriteLine("Press Enter to hide a few words or type 'quit' to exit.");

        var stopwatch = new Stopwatch();
        stopwatch.Start(); // Start the timer

        while (!scripture.AllWordsHidden())
        {
            var input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWord();
            Console.Clear();
            Console.WriteLine("Scripture Passage: " + scripture.GetVisibleText());
            Console.WriteLine("\nPress Enter to hide a few words or type 'quit' to exit.");
        }

        stopwatch.Stop(); // Stop the timer

        Console.WriteLine("All words in the scripture are hidden. Memorization complete.");
        Console.WriteLine($"Time elapsed: {stopwatch.Elapsed.TotalSeconds} seconds");
    }
}