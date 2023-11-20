using System;
using System.ComponentModel;
using System.Reflection;


// Derived class representing a checklist goal
public class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;

    public ChecklistGoal(string name, string description, int value, int targetCount, int targetBonus) : base(name, description, value)
    {
        this.targetCount = targetCount;
        this.currentCount = 0;
    }

    public new void RecordEvent()
    {
        base.RecordEvent();
        currentCount++;

        if (currentCount == targetCount)
        {
            _value += 500; // Bonus for completing the checklist
        }

        Console.WriteLine($"Checklist goal recorded ({currentCount}/{targetCount})!");
    }
    
}
