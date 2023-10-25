using System;
using System.Collections.Generic;
using System.Linq;


// Reference class represents the reference of the scripture (e.g., "John 3:16")
class Reference
{
    public string Text { get; }

    // Constructor for a single verse
    public Reference(string book, int chapter, int verse)
    {
        Text = $"{book} {chapter}:{verse}";
    }

    // Constructor for a verse range
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        Text = $"{book} {chapter}:{startVerse}-{endVerse}";
    }
}
