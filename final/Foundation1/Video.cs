using System;
using System.Collections.Generic;

// Video class to store information about videos
public class Video
{
    public string _title;
    public string _author;
    public int _lengthInSeconds;
    public List<Comment> _comments;

    // Constructor to initialize Video object with title, author, and length
    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _comments = new List<Comment>();
    }

    // Method to return the number of comments
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }
}
