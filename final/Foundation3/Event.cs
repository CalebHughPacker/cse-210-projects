using System;
using System.Collections.Specialized;
using System.Dynamic;

public abstract class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    private string _eventType;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _eventType = EventType;
    }

    protected string EventType
    {
        get {return _eventType;}
        set {_eventType = value;}
    }


    public string GetStandardDetails()
    {
        return $"{_title} - {_description}\n{_time} | {_date}\n{_address.GetAddressString()}";
    }

    public abstract string GetFullDetails();

    public string GetShortDescription()
    {
        return $"{_eventType}: {_title} - {_date}";
    }

}