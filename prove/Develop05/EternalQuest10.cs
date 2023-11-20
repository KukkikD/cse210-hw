using System;
using System.Collections.Generic;
using System.IO;

public class EternalQuest
{
    private List<Goal> goals;
    private int score = 0;

    public EternalQuest()
    {
        goals = new List<Goal>();
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(Goal goal)
    {
        goal.MarkComplete();
    }

    public int DisplayUserScore()
    {
        int userScore = 0;
        foreach (var goal in goals)
        {
            userScore += goal.CalculatePoints();
        }
        return userScore;
    }

    public void DisplayGoals()
    {
        foreach (var goal in goals)
        {
            goal.DisplayStatus();
        }
    }

    public void SaveUserGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (var goal in goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadUserGoals(string filename)
    {
        goals.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (var line in lines)
        {
            string[] parts = line.Split(":");
            string goalType = parts[0];
            string _description = parts[1];
            int goalValue = int.Parse(parts[2]);

            Goal goal;

            switch (goalType)
            {
                case "SimpleGoal":
                    goal = new SimpleGoal(goalType, _description, int.Parse(parts[4]));
                    break;
                case "EternalGoal":
                    goal = new EternalGoal(goalType, _description, int.Parse(parts[4]));
                    break;
                case "ChecklistGoal":
                    goal = new ChecklistGoal(goalType, _description, int.Parse(parts[4]), int.Parse(parts[5]));
                    break;
                default:
                    goal = new Goal(goalType, _description, goalValue);
                    break;
            }

            goal.SetValuesFromRepresentation(line);
            goals.Add(goal);
        }
    }

    public void RecordGoals()
    {
        // Implement logic to record goals
        // This method can be further extended based on the specific recording logic
        // For example, you can display the list of goals and let the user choose which one to record.
        // After recording, you can call the RecordEvent method on the chosen goal.
        // Here's a simplified version:
        Console.WriteLine("Select a goal to record:");
        DisplayGoals();
        Console.Write("Enter the index of the goal: ");
        if (int.TryParse(Console.ReadLine(), out int selectedIndex) && selectedIndex >= 0 && selectedIndex < goals.Count)
        {
            RecordEvent(goals[selectedIndex]);
        }
        else
        {
            Console.WriteLine("Invalid index. Recording failed.");
        }
    }
    public int GetScore()
    {
        return score;
    }

    internal void SaveUserGoals(object filename)
    {
        throw new NotImplementedException();
    }
}
