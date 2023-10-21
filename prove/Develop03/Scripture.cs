using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class Scripture
{
    private string reference;
    private string text;
    private List<string> words;
    private int hiddenWordIndex;

    public Scripture(string reference, string text)
    {
        this.reference = reference;
        this.text = text;
        this.words = text.Split(' ').ToList();
        this.hiddenWordIndex = 0; // Start with the first word
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(reference);

        // Replace words with "___" for all words up to hiddenWordIndex
        for (int i = 0; i < words.Count; i++)
        {
            if (i < hiddenWordIndex)
                Console.Write("___ ");
            else
                Console.Write(words[i] + " ");
        }
        Console.WriteLine(); // Move to the next line
    }

    public void HideNextWord()
    {
        if (hiddenWordIndex < words.Count)
        {
            hiddenWordIndex++;
            Display();
        }
    }

    public bool AllWordsHidden()
    {
        return hiddenWordIndex == words.Count;
    }
}