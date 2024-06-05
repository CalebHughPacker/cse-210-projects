using System;

public class Reception : Event
{
    private string _rsvp;

    public Reception(string title, string description, string date, string time, Address address, string rsvp):base(title, description, date, time, address)
    {
        _rsvp = rsvp;
        EventType = "Reception";
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nRSVP: {_rsvp}";
    }
}