using System;
using System.Collections.Generic;

// Comment class to store information about comments
public class Comment
{
    public string _commenterName;
    public string _text;

    // Constructor to initialize Comment object with name and text
    public Comment(string commenterName, string text)
    {
        _commenterName = commenterName;
        _text = text;
    }
}
