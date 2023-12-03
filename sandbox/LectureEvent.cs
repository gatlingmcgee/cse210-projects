using System;

class LectureEvent : Event
{
    private string speaker;
    private int capacity;

    public LectureEvent(string title, string description, DateTime dateAndTime, Address address, string speaker, int capacity) : base(title, description, dateAndTime, address)
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    public new string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Lecture\nSpeaker: {speaker}\nCapacity: {capacity} seats";
    }

    public new string GetShortDescription()
    {
        return $"Type: Lecture\nTitle: {base.GetShortDescription().Substring(6)}\nSpeaker: {speaker}";
    }
}
