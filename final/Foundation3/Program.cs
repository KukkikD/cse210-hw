using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address eventAddress = new Address("789 Park Ave", "Cityville", "NY", "USA");

        // Create events of each type
        Lecture lectureEvent = new Lecture("Programming Talk", "An informative programming lecture", DateTime.Now.AddDays(7), new TimeSpan(14, 0, 0), eventAddress, "John Doe", 50);

        Reception receptionEvent = new Reception("Networking Night", "A casual networking event", DateTime.Now.AddDays(14), new TimeSpan(18, 30, 0), eventAddress, "rsvp@example.com");

        OutdoorGathering outdoorEvent = new OutdoorGathering("Summer Picnic", "A fun outdoor picnic", DateTime.Now.AddDays(21), new TimeSpan(12, 0, 0), eventAddress, "Weather permitting");

        // Display information about each event
        DisplayEventDetails(lectureEvent);
        DisplayEventDetails(receptionEvent);
        DisplayEventDetails(outdoorEvent);
    }

    static void DisplayEventDetails(Event eventObj)
    {
        Console.WriteLine($"{eventObj.GenerateStandardDetails()}\n");
        Console.WriteLine($"{eventObj.GenerateFullDetails()}\n");
        Console.WriteLine($"{eventObj.GenerateShortDescription()}\n");
    }
}
    
