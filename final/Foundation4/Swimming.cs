using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

// Derived class for Swimming
public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int lengthMinutes, int laps)
        : base(date, lengthMinutes)
    {
        this._laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0; // Convert laps to kilometers
    }

    public override double GetSpeed()
    {
        if (_lengthMinutes == 0)
        {
            return 0;
        }

        return GetDistance() / (_lengthMinutes / 60.0);
    }

    public override double GetPace()
    {
        if (GetDistance() == 0)
        {
            return 0;
        }

        return _lengthMinutes / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Swimming, Laps: {_laps}";
    }

    protected override string GetDetailedSummary()
    {
        return $"Distance: {GetDistance():F1} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F1} min per km";
    }
}