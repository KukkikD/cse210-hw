using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
class Program
{
    static void Main()
    {
        ScriptureLibrary library = new ScriptureLibrary();
        // Add your scriptures to the library here.
        LoadScripturesFromFile("scriptures.txt", library);

        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine("Press Enter to get a random scripture or type 'quit' to exit.");

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            Scripture selectedScripture = library.GetRandomScripture();

            if (selectedScripture != null)
            {
                Console.WriteLine($"Selected Scripture: {selectedScripture.Reference}");
                Console.WriteLine(selectedScripture.Text);
                Console.WriteLine("Press Enter to continue.");
                Console.ReadLine();
            }
        }
    }
    
    static void LoadScripturesFromFile(string filePath, ScriptureLibrary library)
    {
        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);

            for (int i = 0; i < lines.Length; i += 2)
            {
                string reference = lines[i];
                string text = lines[i + 1];
                library.AddScripture(new Scripture(reference, text));
            }
        }
        else
        {
            Console.WriteLine("Scripture file not found.");
        }
    }
}