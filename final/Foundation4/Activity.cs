using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

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
    public virtual string GetSummary()
    {
        return $"{_date.ToShortDateString()} {_lengthMinutes} min";
    }

    // Virtual method to get detailed summary (to be overridden in derived classes)
    protected virtual string GetDetailedSummary()
    {
        return "";
    }

    // Factory method to create an activity object from a summary string
    public static Activity CreateActivityFromSummary(string summary)
    {
        // The logic to parse the summary and create the appropriate Activity instance
        // Implement this based on the actual format of the GetSummary method
        // Return the created Activity object, or null if parsing fails
        return null;
    }
}