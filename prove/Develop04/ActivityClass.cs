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
        Console.WriteLine("Well done!");
        List<String> animationStrings = new List<string>(1);
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("-");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("-");
      

        foreach (String S in animationStrings)
        {
            Console.Write(S);
            Thread.Sleep(300);
            Console.Write("\b \b");
        }
        
        Console.WriteLine($"You've completed the {Name} activity.");

        foreach (String S in animationStrings)
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

