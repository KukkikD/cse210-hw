using System;
using System.Threading;

// Listing Activity class
class ListingActivity : Activity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are your personal strengths?",
        "Who are people that you have helped this week?",
        "When have you felt inspired recently?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the positive aspects of your life.")
    {
    }

    public override void Start(int duration)
    {
        base.Start(duration);
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(prompt);
        Thread.Sleep(3000);
        Console.WriteLine("Get ready to start listing...");
        Thread.Sleep(1000);
        int itemCount = 0;

        while (duration > 0)
        {
            Console.Write("Enter an item (or press Enter to finish): ");
            string item = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(item))
                break;

            itemCount++;
            duration--;
        }

        Console.WriteLine($"Total items listed: {itemCount}");
        Thread.Sleep(2000);
    }
}
