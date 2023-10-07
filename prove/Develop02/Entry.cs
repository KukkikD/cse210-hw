using System;

// Entry class to represent individual journal entries
public class Entry
{
    public string Content { get; set; }
    public string Response { get; set; }

    public Entry(string content, string response)
    {
        Content = content;
        Response = response;
    }

    public void DisplayContent()
    {
        Console.WriteLine(Content);
        Console.WriteLine(Response);
    }
}