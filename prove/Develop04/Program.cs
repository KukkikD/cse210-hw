using System;
using System.Threading;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nMindfulness Activities Menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Select an activity from the Menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Welcome to the Breathing activity.");
                    Thread.Sleep(500);
                    BreathingActivity breathingActivity = new BreathingActivity();
                    Thread.Sleep(1000);
                    breathingActivity.Start(0); // Start with a duration of 0, user will input the duration
                    breathingActivity.End(0);
                    break;
            

                case "2":
                    Console.WriteLine("Welcome to the Reflection activity.");
                    Thread.Sleep(500);
                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    Thread.Sleep(1000);
                    reflectionActivity.Start(0);
                    reflectionActivity.End(0);
                    break;

                case "3":
                    Console.WriteLine("Welcome to the Listing activity.");
                    Thread.Sleep(500);
                    ListingActivity listingActivity = new ListingActivity();
                    Thread.Sleep(1000);
                    listingActivity.Start(0);
                    listingActivity.End(0);
                    break;

                case "4":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    Environment.Exit(0);
                    break;

                default: // Stretch Challenge #1
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }
}