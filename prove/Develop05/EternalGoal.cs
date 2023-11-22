using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override string GetString()
    {
        return $"[ ] {theName} ({theDescription})";
    }

    public override int RegisterGoal()
    {
        return goalCompleted ? 0 : thePoints;
    }

    public override string ToSavedString()
    {
        return $"{this.GetType().Name},{theName},{theDescription},{thePoints},{goalCompleted}";
    }
}
