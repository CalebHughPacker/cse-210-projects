using System;

public class OutdoorGathering : Event
{
    private string _forecast;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string forecast):base(title, description, date, time, address)
    {
        _forecast = forecast;
        EventType = "Outdoor Gathering";
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nForecast: {_forecast}";
    }
}