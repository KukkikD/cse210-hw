using System;
using System.IO;
using System.Collections.Generic;

// Class representing the main Eternal Quest program
public class EternalQuest
{
    private List<Goal> goals = new List<Goal>();
    private int score = 0;

    public void CreateGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        Goal goal = goals.Find(g => g.ToString() == goalName);

        if (goal != null)
        {
            goal.RecordEvent();
            score += goal.GetValue();
        }
        else
        {
            Console.WriteLine("Goal not found");
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Current Goals:");
        foreach (var goal in goals)
        {
            goal.Display();
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Current Score: {score} points");
    }

    // Save and load functionality can be added here

    public int GetScore()
    {
        return score;
    }
}