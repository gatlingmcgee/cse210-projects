using System;

// A derived class for eternal goals
class EternalGoal : Goal
{
    // A constructor that calls the base constructor
    public EternalGoal(string name, int points) : base(name, points)
    {
    }

    // An override method to record an event for the goal
    public override void RecordEvent()
    {
        // Add points to the score
        Program.score += Points;
    }

    // An override method to check if the goal is completed
    public override bool IsCompleted()
    {
        // Return false since the goal is never completed
        return false;
    }

    // An override method to display the goal status
    public override void DisplayStatus()
    {
        // Display the name and points of the goal
        Console.WriteLine(Name + " (" + Points + " points)");

        // Display the completion status of the goal
        Console.WriteLine("[ ] Ongoing");
    }
}