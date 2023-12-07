using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

// Derived class for Stationary Bicycles
public class StationaryBicycle : Activity
{
    private double _speed;

    public StationaryBicycle(DateTime date, int lengthMinutes, double speed)
        : base(date, lengthMinutes)
    {
        this._speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * (_lengthMinutes / 60.0);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        if (_speed == 0)
        {
            return 0;
        }

        return 1 / _speed * 60; // Pace in minutes per km
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Stationary Bicycle, Speed: {_speed:F1} kph";
    }

    protected override string GetDetailedSummary()
    {
        return $"Speed: {_speed:F1} kph, Pace: {GetPace():F1} min per km";
    }
}