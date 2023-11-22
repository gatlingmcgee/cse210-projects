using System;

public abstract class Goal
{
    protected string theName;
    protected string theDescription;
    protected int thePoints;
    protected bool goalCompleted;

    public string GetName()
    {
        return theName;
    }

    protected Goal(string name, string description, int points, bool isCompleted = false)
    {
        theName = name;
        theDescription = description;
        thePoints = points;
        goalCompleted = false;
    }

    public Goal(string name, string description, int points, int times, int bonus, int timesDone = 0)
    {
        theName = name;
        theDescription = description;
        thePoints = points;
    }

    public virtual string GetString()
    {
        return $"{theName} {theDescription} -- {thePoints} points";
    }

    public virtual int RegisterGoal()
    {
        goalCompleted = true;
        return thePoints;
    }

    public virtual string ToSavedString()
    {
        return $"{this.GetType().Name},{theName},{theDescription},{thePoints},{goalCompleted}";
    }
}