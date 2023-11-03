using System;
using System.Threading;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nMindfulness Activities Menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Select an activity from the Menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Welcome to the Breathing activity");
                    Thread.Sleep(500);
                    BreathingActivity breathingActivity = new BreathingActivity();
                    Thread.Sleep(1000);
                    breathingActivity.Start(0); // Start with a duration of 0, user will input the duration
                    breathingActivity.End(0);
                    break;
            

                case "2":
                    Console.Write("Enter the duration in seconds: ");
                    int duration2 = int.Parse(Console.ReadLine());
                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    reflectionActivity.Start(duration2);
                    reflectionActivity.End(duration2);
                    break;

                case "3":
                    Console.Write("Enter the duration in seconds: ");
                    int duration3 = int.Parse(Console.ReadLine());
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Start(duration3);
                    listingActivity.End(duration3);
                    break;

                case "4":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }
}
// Base Activity class
class Activity
{
    public string Name { get; protected set; }
    public string Description { get; protected set; }

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public virtual void Start(int duration)
    {
        
        Console.WriteLine(Description);
        Thread.Sleep(1000);
        Console.Write($"How long, in seconds, would you like for your session? ");
        duration = int.Parse(Console.ReadLine());
        Console.Write("Get ready");

        DateTime StartTime = DateTime.Now;
        DateTime EndTime = StartTime.AddSeconds(3);
        while (DateTime.Now < EndTime)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }

        Console.WriteLine();
        StartActivity(duration);
    }

    public virtual void End(int duration)
    {
        Console.WriteLine($"Good job! You've completed the {Name} activity.");
        List<String> aninationStrings = new List<string>(1);
        aninationStrings.Add("|");
        aninationStrings.Add("/");
        aninationStrings.Add("-");
        aninationStrings.Add("\\");
        aninationStrings.Add("-");
        aninationStrings.Add("|");
        aninationStrings.Add("/");
        aninationStrings.Add("-");
        aninationStrings.Add("\\");
        aninationStrings.Add("-");
      

        foreach(String S in aninationStrings)
        {
            Console.Write(S);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
        
    }

    public virtual void StartActivity(int duration)
    {
        // This method should be overridden by subclasses to implement the specific activity.
    }
}
// Breathing Activity class
class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly.\nClear your mind and focus on your breathing.")
    {
     }

    public override void StartActivity(int duration)
{
    for (int i = duration; i > 0; --i)
    {
        // Stretch Challenge Animation for breathing in
        List<String> animationBreathIn = new List<string>
        {
            "(^ 3 ^))",
            "(^  3  ))",
            "(^ . ^))",
            "(^ .  ))",
            "(^ . ^))"
        };

        int animationIndexIn = 0;

        // Countdown and animation for "Breathe in" on the same line
        for (int j = 5; j > 0; --j)
        {
            Console.Write($"{j} {animationBreathIn[animationIndexIn]}  "); // Add spaces to overwrite the entire animation
            animationIndexIn = (animationIndexIn + 1) % animationBreathIn.Count;
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b"); // Move the cursor back to the start of the line
        }

        Console.WriteLine(); // Move to the next line after "Breathe in"
        Console.Write("Breathe out ");

        // Stretch Challenge Animation for breathing out
        List<String> animationBreathOut = new List<string>
        {
            "(^ 1 ^))",
            "(^  1  ))",
            "(^ . ^))",
            "(^ .  ))",
            "(^ . ^))"
        };

        int animationIndexOut = 0;

        // Countdown and animation for "Breathe out" on the same line
        for (int k = 5; k > 0; --k)
        {
            Console.Write($"{k} {animationBreathOut[animationIndexOut]}  "); // Add spaces to overwrite the entire animation
            animationIndexOut = (animationIndexOut + 1) % animationBreathOut.Count;
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b"); // Move the cursor back to the start of the line
        }

        Console.WriteLine(); // Move to the next line after "Breathe out"
    }
}
}
