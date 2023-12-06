using System;

// Derived class for Outdoor Gatherings
public class OutdoorGathering : Event
{
    private string _weatherStatement;

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weatherStatement)
        : base(title, description, date, time, address)
    {
        this._weatherStatement = weatherStatement;
    }

    // Override method to generate full details message for outdoor gatherings
    public override string GenerateFullDetails()
    {
        return $"{base.GenerateFullDetails()}\nType: Outdoor Gathering\nWeather: {_weatherStatement}";
    }
}