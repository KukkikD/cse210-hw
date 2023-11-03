using System;
using System.Threading;


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
            Thread.Sleep(300);
            Console.Write("\b \b");
        }
        
    }

    public virtual void StartActivity(int duration)
    {
        // This method should be overridden by subclasses to implement the specific activity.
    }
}

