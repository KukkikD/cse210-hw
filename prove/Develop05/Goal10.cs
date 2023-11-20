using System;

public class Goal
{
    // Common attributes for all goal types
    protected string goalType;
    protected string _description;
    protected int goalValue;
    protected bool completionStatus;
    protected int completionCount;
    private string type;
    private string description;
    private int basePoints;

    // Constructor to initialize common attributes
    public Goal(string type, string description, int value)
    {
        goalType = type;
        _description = description;
        goalValue = value;
        completionStatus = false;
        completionCount = 0;
    }

    // Method to mark the goal as complete
    public void MarkComplete()
    {
        completionStatus = true;
        completionCount++;
    }

    public virtual int CalculatePoints()
    {
        return completionStatus ? goalValue : 0;
    }

    public static Goal CreateNewGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of Goal would you like to create? ");
        string goalTypeChoice = Console.ReadLine();

        switch (goalTypeChoice)
        {
            case "1":
                // Create and return a new Simple Goal
                Console.Write("What is the title of the goal? ");
                string title = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                int basePoints = int.Parse(Console.ReadLine());
                return new SimpleGoal(title, description, basePoints);
            case "2":
                // Create and return a new Eternal Goal
                Console.Write("What is the title of the goal? ");
                string eternalTitle = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string eternalDescription = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                int eternalPoints = int.Parse(Console.ReadLine());
                return new EternalGoal(eternalTitle, eternalDescription, eternalPoints);
            case "3":
                // Create and return a new Checklist Goal
                Console.Write("What is the title of the goal? ");
                string checklistTitle = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string checklistDescription = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                int checklistPoints = int.Parse(Console.ReadLine());
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("How is the bonus for accomplishing it that many times? ");
                int targetBonus = int.Parse(Console.ReadLine());
                return new ChecklistGoal(checklistTitle, checklistDescription, checklistPoints, targetCount);
            default:
                Console.WriteLine("Invalid choice. Returning null.");
                return null;
        }
    }

    public virtual string GetStringRepresentation()
    {
        return $"{type}:{description}:{basePoints}:{completionStatus}:{completionCount}";
    }

    public virtual void SetValuesFromRepresentation(string representation)
    {
        string[] parts = representation.Split(":");
        type = parts[0];
        description = parts[1];
        basePoints = int.Parse(parts[2]);
        completionStatus = bool.Parse(parts[3]);
        completionCount = int.Parse(parts[4]);
    }

    public virtual void DisplayStatus()
    {
        Console.WriteLine($"{(completionStatus ? "[X]" : "[ ]")} {goalType} ({_description}) {completionCount}");

    }
}