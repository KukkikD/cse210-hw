using System;
using System.Collections.Generic;

// Derived class for Running
public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int lengthMinutes, double distance)
        : base(date, lengthMinutes)
    {
        this._distance = distance;
    }

    // Override method to get distance for running
    public override double GetDistance()
    {
        return _distance;
    }

    // Override method to get speed for running
    public override double GetSpeed()
    {
        return _distance / _lengthMinutes * 60;
    }

    // Override method to get pace for running
    public override double GetPace()
    {
        return _lengthMinutes / _distance;
    }

    // Override method to get detailed summary for running
    protected override string GetDetailedSummary()
    {
        return $"Distance {_distance:F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}
