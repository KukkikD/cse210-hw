using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

// Derived class for Running
public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int lengthMinutes, double distance)
        : base(date, lengthMinutes)
    {
        this._distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        if (_lengthMinutes == 0)
        {
            return 0;
        }

        return _distance / (_lengthMinutes / 60.0);
    }

    public override double GetPace()
    {
        if (GetSpeed() == 0)
        {
            return 0;
        }

        return 1 / GetSpeed() * 60; // Pace in minutes per mile
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Running, Distance: {_distance:F1} miles";
    }

    protected override string GetDetailedSummary()
    {
        return $"Distance: {_distance:F1} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F1} min per km";
    }
}