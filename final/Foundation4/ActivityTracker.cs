using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

// ActivityTracker class
public class ActivityTracker
{
    private List<Activity> _activities = new List<Activity>();

    public void AddActivity(Activity activity)
    {
        _activities.Add(activity);
    }

    public void DisplayActivities()
    {
        foreach (var activity in _activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine($"Distance: {activity.GetDistance():F1} km, Speed: {activity.GetSpeed():F1} kph, Pace: {activity.GetPace():F1} min per km");
        }
    }

    public void SaveActivitiesToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var activity in _activities)
            {
                writer.WriteLine(activity.GetSummary());
            }
        }
        Console.WriteLine("Activities saved to file.");
    }

    public void LoadActivitiesFromFile(string fileName)
    {
        _activities.Clear(); // Clear existing activities before loading from file

        try
        {
            if (File.Exists(fileName))
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        // Assuming the saved format matches the GetSummary format
                        Activity newActivity = Activity.CreateActivityFromSummary(line);
                        if (newActivity != null)
                        {
                            AddActivity(newActivity);
                        }
                    }
                }
                Console.WriteLine("Activities loaded successfully.");
            }
            else
            {
                Console.WriteLine($"File not found: {fileName}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading activities: {ex.Message}");
        }
    }
}
