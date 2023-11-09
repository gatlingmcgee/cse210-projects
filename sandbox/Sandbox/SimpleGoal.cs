using System;

// A derived class for simple goals
class SimpleGoal : Goal
{
    // A private member variable to store the completion status of the goal
    private bool completed;

    // A constructor that calls the base constructor and initializes the completion status
    public SimpleGoal(string name, int points) : base(name, points)
    {
        completed = false;
    }

    // An override method to record an event for the goal
    public override void RecordEvent()
    {
        // If the goal is not completed, mark it as completed and add points
        if (!completed)
        {
            completed = true;
            Program.score += Points;
        }
    }

    // An override method to check if the goal is completed
    public override bool IsCompleted()
    {
        return completed;
    }

    // An override method to display the goal status
    public override void DisplayStatus()
    {
        // Display the name and points of the goal
        Console.WriteLine(Name + " (" + Points + " points)");

        // Display the completion status of the goal
        if (completed)
        {
            Console.WriteLine("[X] Completed");
        }
        else
        {
            Console.WriteLine("[ ] Not completed");
        }
    }
}