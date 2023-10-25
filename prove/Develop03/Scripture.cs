using System;
using System.Collections.Generic;
using System.Linq;

// Scripture class represents the full scripture with words and reference
class Scripture
{
    private readonly Reference reference;
    private readonly List<Word> words;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    // Add the HideRandomWord method back to the Scripture class
    public void HideRandomWord()
    {
        var random = new Random();
        int index;
        do
        {
            index = random.Next(words.Count);
        } while (words[index].Hidden);

        words[index].Hide();
    }

    public bool AllWordsHidden()
    {
        return words.All(word => word.Hidden);
    }

    public string GetVisibleText()
    {
        return $"{reference.Text} {string.Join(" ", words.Select(w => w.Hidden ? "___" : w.Text))}";
    }
}
