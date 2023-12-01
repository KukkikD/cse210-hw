using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store videos
        List<Video> videos = new List<Video>();

        // Create and add videos to the list
        Video video1 = new Video("Introduction to C#", "John Doe", 300);
        video1._comments.Add(new Comment("User1", "Great video!"));
        video1._comments.Add(new Comment("User2", "Thanks for sharing."));

        Video video2 = new Video("Object-Oriented Programming Basics", "Jane Smith", 450);
        video2._comments.Add(new Comment("User3", "Very informative."));
        video2._comments.Add(new Comment("User4", "Looking forward to more videos."));

        videos.Add(video1);
        videos.Add(video2);

        // Display information about each video and its comments
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._lengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (var comment in video._comments)
            {
                Console.WriteLine($"- {comment._commenterName}: {comment._text}");
            }

            Console.WriteLine();
        }
    }
}