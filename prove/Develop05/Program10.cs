using System;
using System.Collections.Generic;

class Program
{
    private static string filename;

    static void Main()
    {
        EternalQuest quest = new EternalQuest();

        

        while (true)
        {
            Console.WriteLine($"You have {quest.DisplayUserScore()} points");
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Create new Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Goals");
            Console.WriteLine("6. Quit");

            Console.Write("Enter your choice (1-6): ");
            string choice = Console.ReadLine();

            object userScore = null;
            switch (choice)
            {
                case "1":
                    Goal newGoal = Goal.CreateNewGoal();
                    quest.AddGoal(newGoal);
                    break;
                case "2":
                    quest.DisplayGoals();
                    break;
                case "3":
                    // Save functionality can be added here
                    quest.SaveUserGoals(filename);
                    
                    break;
                case "4":
                    // Load functionality can be added here
                    Console.WriteLine("What is the filename for the Goal file?");
                    quest.LoadUserGoals(filename);
                    break;
                case "5":
                    Console.Write("Enter the goal name to record: ");
                    string goalToRecord = Console.ReadLine();
                    quest.RecordGoals();
                    Console.WriteLine($"Congratulations! You have earn {userScore} pionts!");
                    Console.WriteLine ($"Now You have {userScore} pionts!");
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