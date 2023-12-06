using System;
using System.Collections.Generic;

// Derived class for Stationary Bicycles
public class StationaryBicycle : Activity
{
    private double _speed;

    public StationaryBicycle(DateTime date, int lengthMinutes, double speed)
        : base(date, lengthMinutes)
    {
        this._speed = speed;
    }

    // Override method to get speed for stationary bicycles
    public override double GetSpeed()
    {
        return _speed;
    }

    // Override method to get pace for stationary bicycles
    public override double GetPace()
    {
        return 60 / _speed;
    }

    // Override method to get detailed summary for stationary bicycles
    protected override string GetDetailedSummary()
    {
        return $"Speed: {_speed:F1} kph, Pace: {GetPace():F1} min per km";
    }
}