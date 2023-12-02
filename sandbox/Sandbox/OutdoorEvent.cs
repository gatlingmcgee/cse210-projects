using System;

class OutdoorEvent : Event
{
    private string weatherForecast;

    public OutdoorEvent(string title, string description, DateTime dateAndTime, Address address, string weatherForecast) : base(title, description, dateAndTime, address)
    {
        this.weatherForecast = weatherForecast;
    }

    public new string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Outdoor Gathering\nWeather Forecast: {weatherForecast}";
    }

    public new string GetShortDescription()
    {
        return $"Type: Outdoor Gathering\nTitle: {base.GetShortDescription().Substring(6)}\nWeather Forecast: {weatherForecast}";
    }
}