using System;

class Event
{
    private string title;
    private string description;
    private DateTime dateAndTime;
    private Address address;

    public Event(string title, string description, DateTime dateAndTime, Address address)
    {
        this.title = title;
        this.description = description;
        this.dateAndTime = dateAndTime;
        this.address = address;
    }

    public string GetStandardDetails()
    {
        // string formattedDateTime = dateAndTime.ToString("yyyy-MM-dd HH:mm");
        
        return $"Title: {title}\nDescription: {description}\nDate and Time: {dateAndTime}\nAddress: {address}";
    }

    public string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public string GetShortDescription()
    {
        return $"Type: Generic Event\nTitle: {title}\nDate: {dateAndTime.Date}";
    }
}
