using System;
using System.Collections.Generic;
using System.Linq;

// Word class represents individual words in the scripture
class Word
{
    public string Text { get; }
    public bool Hidden { get; private set; }

    public Word(string text)
    {
        Text = text;
        Hidden = false;
    }

    public void Hide()
    {
        Hidden = true;
    }
}
