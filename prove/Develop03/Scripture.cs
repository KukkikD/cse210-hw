using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class Scripture
{
    public string Reference { get; }
    public string Text { get; }

    public Scripture(string reference, string text)
    {
        Reference = reference;
        Text = text;
    }
}