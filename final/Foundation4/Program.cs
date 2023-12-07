using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        ActivityTracker activityTracker = new ActivityTracker();

        while (true)
        {
            Console.WriteLine("Main Menu:");
            Console.WriteLine("1. Add Activity");
            Console.WriteLine("2. Display Activities");
            Console.WriteLine("3. Save Activities to File");
            Console.WriteLine("4. Load Activities from File");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice (1-5): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Add Activity
                    // Prompt the user to enter details for the specific activity type
                    Console.WriteLine("Select Activity Type:");
                    Console.WriteLine("1. Running");
                    Console.WriteLine("2. Stationary Bicycle");
                    Console.WriteLine("3. Swimming");
                    Console.Write("Enter your choice (1-3): ");
                    string activityTypeChoice = Console.ReadLine();

                    // Add the selected activity to the tracker
                    Activity newActivity = CreateActivityFromUserInput(activityTypeChoice);
                    if (newActivity != null)
                    {
                        activityTracker.AddActivity(newActivity);
                        Console.WriteLine("Activity added successfully.");
                    }
                    break;

                case "2":
                    // Display Activities
                    activityTracker.DisplayActivities();
                    break;

                case "3":
                    // Save Activities to File
                    Console.Write("Enter the file name to save activities: ");
                    string saveFileName = Console.ReadLine();
                    activityTracker.SaveActivitiesToFile(saveFileName);
                    break;

                case "4":
                    // Load Activities from File
                    Console.Write("Enter the file name to load activities: ");
                    string loadFileName = Console.ReadLine();
                    activityTracker.LoadActivitiesFromFile(loadFileName);
                    break;

                case "5":
                    // Exit
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    // Function to create an activity based on user input
    static Activity CreateActivityFromUserInput(string activityTypeChoice)
    {
        switch (activityTypeChoice)
        {
            case "1":
                // Running
                return CreateRunningActivity();

            case "2":
                // Stationary Bicycle
                return CreateStationaryBicycleActivity();

            case "3":
                // Swimming
                return CreateSwimmingActivity();

            default:
                Console.WriteLine("Invalid activity type choice.");
                return null;
        }
    }

    // Function to create a Running activity based on user input
    static Activity CreateRunningActivity()
    {
        Console.Write("Enter the date (MM/DD/YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter the length in minutes: ");
        int lengthMinutes = int.Parse(Console.ReadLine());

        Console.Write("Enter the distance in miles: ");
        double distance = double.Parse(Console.ReadLine());

        return new Running(date, lengthMinutes, distance);
    }

    // Function to create a Stationary Bicycle activity based on user input
    static Activity CreateStationaryBicycleActivity()
    {
        Console.Write("Enter the date (MM/DD/YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter the length in minutes: ");
        int lengthMinutes = int.Parse(Console.ReadLine());

        Console.Write("Enter the speed in kph: ");
        double speed = double.Parse(Console.ReadLine());

        return new StationaryBicycle(date, lengthMinutes, speed);
    }

    // Function to create a Swimming activity based on user input
    static Activity CreateSwimmingActivity()
    {
        Console.Write("Enter the date (MM/DD/YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter the length in minutes: ");
        int lengthMinutes = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of laps: ");
        int laps = int.Parse(Console.ReadLine());

        return new Swimming(date, lengthMinutes, laps);
    }
}