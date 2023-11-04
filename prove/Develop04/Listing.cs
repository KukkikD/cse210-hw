using System;
using System.Threading;

// Listing Activity class
class ListingActivity : Activity
{
    private string[] prompts = {
        "-- Who are people that you appreciate? --",
        "-- What are your personal strengths? --",
        "-- Who are people that you have helped this week? --",
        "-- When have you felt inspired recently? --",
        "-- Who are some of your personal heroes? --"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }
    public override void StartActivity(int duration)
    {
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine("List as many responses you can do to the following propt:");
        Console.WriteLine(prompt);
        // Countdown before questions
        Console.Write("You may begin in  ");
        for (int j = 4; j > 0; j--)
        {
            Console.Write(j);
            Thread.Sleep(1000);
            Console.Write("\b \b \b \b");
        }

        Console.WriteLine();
        
        int itemCount = 0;
        while (duration > 0)
        {
            Console.Write($"> ");
            string item = Console.ReadLine(); 
            
            if (string.IsNullOrWhiteSpace(item))
                break;

            itemCount++;
            duration--;
        }

        Console.WriteLine($"Your list {itemCount} items:");
        Thread.Sleep(2000);
    }
}
