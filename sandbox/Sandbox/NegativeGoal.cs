using System;

public class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, int points)
        : base(name, description, points)
    {
        theName = name;
        theDescription = description;
        thePoints = points - points;        
    }
 
    public override string GetString()
    {
        return $"[X] {theName} ({theDescription})";
    }
 
    public override int RegisterGoal()
    {
        return goalCompleted ? 0 : -thePoints; // Deduct points for negative goals
    }
 
    public override string ToSavedString()
    {
        return $"{this.GetType().Name},{theName},{theDescription},{thePoints},{goalCompleted}";
    }
}