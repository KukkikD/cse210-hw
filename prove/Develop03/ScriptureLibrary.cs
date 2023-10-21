using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class ScriptureLibrary
{
    private List<Scripture> scriptures = new List<Scripture>();
    private Random random = new Random();

    public void AddScripture(Scripture scripture)
    {
        scriptures.Add(scripture);
    }

    public Scripture GetRandomScripture()
    {
        if (scriptures.Count == 0)
        {
            Console.WriteLine("No scriptures in the library.");
            return null;
        }

        int randomIndex = random.Next(0, scriptures.Count);
        return scriptures[randomIndex];
    }
}