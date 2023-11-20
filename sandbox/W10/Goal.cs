using System;
using System.IO;
using System.Collections.Generic;

// Base class representing a generic goal
public class Goal
{
    private string _name;

    private string _description;
    protected int _value;
    protected bool _isCompleted;

    public Goal(string name, String description, int value)
    {
        this._name = name;
        this._description = description;
        this._value = value;
        this._isCompleted = false;
    }

    public void RecordEvent()
    {
        _isCompleted = true;
    }

    public void Display()
    {
        Console.WriteLine($"{(_isCompleted ? "[X]" : "[ ]")} {_name} ({_description})");
    }

    public int GetValue()
    {
        return _isCompleted ? _value : 0;
    }

    public static Goal CreateGoalFromUserInput()
    {
        
        Console.WriteLine("Select the type of goal:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter your choice (1, 2, or 3): ");
        String choice = Console.ReadLine();

        switch (choice)
         {
        case "1":
            // Create and return a new Simple Goal
            Console.Write("What is the title of the goal? ");
            string title = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            if (int.TryParse(Console.ReadLine(), out int points))
            {
                return new SimpleGoal(title, description, points);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for points.");
                return null;
            }
        case "2":
            // Create and return a new Eternal Goal
            Console.Write("What is the title of the goal? ");
            string eternalTitle = Console.ReadLine();
            Console.Write("What is a short description of it? ");
             string eternalDescription = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            if (int.TryParse(Console.ReadLine(), out int eternalPoints))
            {
                return new EternalGoal(eternalTitle, eternalDescription, eternalPoints);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for points.");
                return null;
            }
        case "3":
            // Create and return a new Checklist Goal
            Console.Write("What is the title of the goal? ");
            string checklistTitle = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string checklistDescrition = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            if (int.TryParse(Console.ReadLine(), out int checklistPoints))
            {
                Console.Write("How many times dose this goal need to be accomplished for a bonus? ");
                if (int.TryParse(Console.ReadLine(), out int targetCount))
                Console.Write("How is the bonus for accomplishing it that many times? ");
                if (int.TryParse(Console.ReadLine(), out int targetBonus))
                {
                    return new ChecklistGoal(checklistTitle, checklistDescrition, checklistPoints, targetCount, targetBonus);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer for the target count.");
                    return null;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for points.");
                return null;
            }
        default:
            Console.WriteLine("Invalid choice. Returning null.");
            return null;
    }
}
}