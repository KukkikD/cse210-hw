using System;

// Base Event class
public class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private TimeSpan _time;
    private Address _address;

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        this._title = title;
        this._description = description;
        this._date = date;
        this._time = time;
        this._address = address;
    }

    // Method to generate standard details message
    public string GenerateStandardDetails()
    {
        return $"Standard details for {_title}:\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_time}\nAddress: {_address.GetFullAddress()}";
    }

    // Method to generate full details message
    public virtual string GenerateFullDetails()
    {
        return GenerateStandardDetails();
    }

    // Method to generate short description message
    public string GenerateShortDescription()
    {
        return $"Short description for {_title} ({GetType().Name}):\nDate: {_date.ToShortDateString()}";
    }
}
