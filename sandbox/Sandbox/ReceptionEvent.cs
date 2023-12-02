using System;

class ReceptionEvent : Event
{
    private string rsvpEmail;

    public ReceptionEvent(string title, string description, DateTime dateAndTime, Address address, string rsvpEmail) : base(title, description, dateAndTime, address)
    {
        this.rsvpEmail = rsvpEmail;
    }

    public new string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Reception\nRSVP Email: {rsvpEmail}";
    }

    public new string GetShortDescription()
    {
        return $"Type: Reception\nTitle: {base.GetShortDescription().Substring(6)}\nRSVP Email: {rsvpEmail}";
    }
}
