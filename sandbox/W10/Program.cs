using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        EternalQuest quest = new EternalQuest();

        

        while (true)
        {
            Console.WriteLine($"You have {quest.GetScore()} points");
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Create new Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Goals");
            Console.WriteLine("6. Quit");

            Console.Write("Enter your choice (1-6): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Goal newGoal = Goal.CreateGoalFromUserInput();
                    quest.CreateGoal(newGoal);
                    break;
                case "2":
                    quest.DisplayGoals();
                    break;
                case "3":
                    // Save functionality can be added here
                    Console.WriteLine("Goals saved successfully!");
                    break;
                case "4":
                    // Load functionality can be added here
                    Console.WriteLine("Goals loaded successfully!");
                    break;
                case "5":
                    Console.Write("Enter the goal name to record: ");
                    string goalToRecord = Console.ReadLine();
                    quest.RecordEvent(goalToRecord);
                    Console.WriteLine("Goal recorded!");
                    break;
                case "6":
                    // Exit the program
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                    break;
            }
        }
    }
}