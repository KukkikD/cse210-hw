using System;

public class Entry
{
    public string Content { get; set; }

    public Entry(string content)
    {
        Content = content;
    }

    public void DisplayContent()
    {
        Console.WriteLine(Content);
    }
}
