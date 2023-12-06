using System;
using System.Collections.Generic;

// Derived class for Swimming
public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int lengthMinutes, int laps)
        : base(date, lengthMinutes)
    {
        this._laps = laps;
    }

    // Override method to get distance for swimming
    public override double GetDistance()
    {
        return _laps * 50 / 1000; // Convert laps to kilometers
    }

    // Override method to get speed for swimming
    public override double GetSpeed()
    {
        return GetDistance() / _lengthMinutes * 60;
    }

    // Override method to get pace for swimming
    public override double GetPace()
    {
        return _lengthMinutes / GetDistance();
    }

    // Override method to get detailed summary for swimming
    protected override string GetDetailedSummary()
    {
        return $"Distance: {GetDistance():F1} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F1} min per km";
    }
}
