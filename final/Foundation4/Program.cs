using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
       // Create a list to store activities
        List<Activity> activities = new List<Activity>();

        while (true)
        {
            Console.WriteLine("Main Menu:");
            Console.WriteLine("1. Select Activity");
            Console.WriteLine("2. Save Activities");
            Console.WriteLine("3. Load Activities");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice (1-4): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    SelectActivitySubMenu(activities);
                    break;

                case "2":
                    SaveActivitiesToFile("activities.txt", activities);
                    Console.WriteLine("Activities saved to file.\n");
                    break;

                case "3":
                    LoadActivitiesFromFile("activities.txt", activities);
                    Console.WriteLine("Activities loaded from file.\n");
                    ViewActivitySummaries(activities); // Display loaded activities
                    break;

                case "4":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    SaveActivitiesToFile("activities.txt", activities); // Save activities before exiting
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    break;
            }

            Thread.Sleep(1000);
        }
    }

    static void SelectActivitySubMenu(List<Activity> activities)
    {
        while (true)
        {
            Console.WriteLine("Activity Menu:");
            Console.WriteLine("1. Running");
            Console.WriteLine("2. Swimming");
            Console.WriteLine("3. Cycling");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice (1-4): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    LogRunningActivity(activities);
                    break;

                case "2":
                    LogSwimmingActivity(activities);
                    break;

                case "3":
                    LogStationaryBicycleActivity(activities);
                    break;

                case "4":
                    Console.WriteLine("Returning to main menu.");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    break;
            }

            // Introduce a delay of 1000 milliseconds (1 second)
            Thread.Sleep(1000);
        }
    }


    static void SaveActivitiesToFile(string fileName, List<Activity> activities)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var activity in activities)
            {
                writer.WriteLine(activity.GetSummary());
            }
        }
    }

    static void LoadActivitiesFromFile(string fileName, List<Activity> activities)
    {
        activities.Clear(); // Clear existing activities before loading

        if (File.Exists(fileName))
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    // Add logic to parse the line and create Activity objects if needed
                    // For simplicity, assuming each line in the file is a summary string
                    // and creating a new Running activity with default values
                    activities.Add(new Running(DateTime.Now, 0, 0));
                }
            }
        }
    }

    // Function to log a running activity
    static void LogRunningActivity(List<Activity> activities)
    {
        Console.Write("Enter the date (MM/DD/YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter the length in minutes: ");
        int lengthMinutes = int.Parse(Console.ReadLine());

        Console.Write("Enter the distance in miles: ");
        double distance = double.Parse(Console.ReadLine());

        Running runningActivity = new Running(date, lengthMinutes, distance);
        activities.Add(runningActivity);

        Console.WriteLine("Running activity logged successfully!\n");
    }

    // Function to log a stationary bicycle activity
    static void LogStationaryBicycleActivity(List<Activity> activities)
    {
        Console.Write("Enter the date (MM/DD/YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter the length in minutes: ");
        int lengthMinutes = int.Parse(Console.ReadLine());

        Console.Write("Enter the speed in kph: ");
        double speed = double.Parse(Console.ReadLine());

        StationaryBicycle bicycleActivity = new StationaryBicycle(date, lengthMinutes, speed);
        activities.Add(bicycleActivity);

        Console.WriteLine("Stationary Bicycle activity logged successfully!\n");
    }

    // Function to log a swimming activity
    static void LogSwimmingActivity(List<Activity> activities)
    {
        Console.Write("Enter the date (MM/DD/YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter the length in minutes: ");
        int lengthMinutes = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of laps: ");
        int laps = int.Parse(Console.ReadLine());

        Swimming swimmingActivity = new Swimming(date, lengthMinutes, laps);
        activities.Add(swimmingActivity);

        Console.WriteLine("Swimming activity logged successfully!\n");
    }

    // Function to view summaries of all logged activities
    static void ViewActivitySummaries(List<Activity> activities)
    {
        if (activities.Count == 0)
        {
            Console.WriteLine("No activities logged yet.\n");
            return;
        }

        Console.WriteLine("Activity Summaries:");

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

        Console.WriteLine();
    }
}