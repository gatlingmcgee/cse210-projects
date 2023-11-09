using System;

// A base class for goals
abstract class Goal
{
    // A private member variable to store the name of the goal
    private string name;

    // A private member variable to store the points earned by the goal
    private int points;

    // A constructor that takes the name and points as parameters
    public Goal(string name, int points)
    {
        this.name = name;
        this.points = points;
    }

    // A public property to get the name of the goal
    public string Name
    {
        get { return name; }
    }

    // A public property to get the points earned by the goal
    public int Points
    {
        get { return points; }
    }

    // An abstract method to record an event for the goal
    public abstract void RecordEvent();

    // An abstract method to check if the goal is completed
    public abstract bool IsCompleted();

    // An abstract method to display the goal status
    public abstract void DisplayStatus();
}