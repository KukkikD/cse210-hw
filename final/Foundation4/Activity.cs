using System;
using System.Collections.Generic;

// Base Activity class
public class Activity
{
    protected DateTime _date;
    protected int _lengthMinutes;

    public Activity(DateTime date, int lengthMinutes)
    {
        this._date = date;
        this._lengthMinutes = lengthMinutes;
    }

    // Virtual method to get distance (to be overridden in derived classes)
    public virtual double GetDistance()
    {
        return 0;
    }

    // Virtual method to get speed (to be overridden in derived classes)
    public virtual double GetSpeed()
    {
        return 0;
    }

    // Virtual method to get pace (to be overridden in derived classes)
    public virtual double GetPace()
    {
        return 0;
    }

    // Method to get a summary string
    public string GetSummary()
    {
        return $"{_date.ToShortDateString()} {GetType().Name} ({_lengthMinutes} min): {GetDetailedSummary()}";
    }

    // Virtual method to get detailed summary (to be overridden in derived classes)
    protected virtual string GetDetailedSummary()
    {
        return "";
    }
}