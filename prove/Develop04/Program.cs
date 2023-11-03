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
                    Console.WriteLine("Welcome to the Breathing activity");
                    Thread.Sleep(500);
                    BreathingActivity breathingActivity = new BreathingActivity();
                    Thread.Sleep(1000);
                    breathingActivity.Start(0); // Start with a duration of 0, user will input the duration
                    breathingActivity.End(0);
                    break;
            

                case "2":
                    Console.Write("Enter the duration in seconds: ");
                    int duration2 = int.Parse(Console.ReadLine());
                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    reflectionActivity.Start(duration2);
                    reflectionActivity.End(duration2);
                    break;

                case "3":
                    Console.Write("Enter the duration in seconds: ");
                    int duration3 = int.Parse(Console.ReadLine());
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Start(duration3);
                    listingActivity.End(duration3);
                    break;

                case "4":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }
}