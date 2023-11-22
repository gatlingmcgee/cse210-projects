using System;

// Simple Goal class
public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points, bool isCompleted = false)
        : base(name, description, points)
    {
        goalCompleted = isCompleted;
    }

    public override string GetString()
    {
        string cross = goalCompleted ? "X" : " ";
        return $"[{cross}] {theName} ({theDescription})";
    }

    public override int RegisterGoal()
    {
        return goalCompleted ? 0 : base.RegisterGoal();
    }

    public override string ToSavedString()
    {
        return $"{this.GetType().Name},{theName},{theDescription},{thePoints},{goalCompleted}";
    }
}