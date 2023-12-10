using System;

public class OutdoorEvent : Event
{
    public OutdoorEvent(string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
    {
    }

    public override string GetFullDetails()
    {
        string weather = GetWeatherForecast();
        return $"{base.GetFullDetails()}\nWeather: {weather}";
    }

    protected override string GetEventType()
    {
        return "Outdoor Gathering";
    }

    private string GetWeatherForecast()
    {
        return "Cloudy and a high of 46°F";
    }
}
