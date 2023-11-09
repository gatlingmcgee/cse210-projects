using System;

// A derived class for checklist goals
class ChecklistGoal : Goal
{
    // A private member variable to store the target number of times to complete the goal
    private int target;

    // A private member variable to store the current number of times the goal is completed
    private int count;

    // A private member variable to store the bonus points for completing the goal
    private int bonus;

    // A constructor that calls the base constructor and initializes the target, count and bonus
    public ChecklistGoal(string name, int points, int target, int bonus) : base(name, points)
    {
        this.target = target;
        this.count = 0;
        this.bonus = bonus;
    }

    // An override method to record an event for the goal
    public override void RecordEvent()
    {
        // If the goal is not completed, increment the count and add points
        if (!IsCompleted())
        {
            count++;
            Program.score += Points;

            // If the goal is completed, add the bonus points
            if (IsCompleted())
            {
                Program.score += bonus;
            }
        }
    }

    // An override method to check if the goal is completed
    public override bool IsCompleted()
    {
        // Return true if the count is equal to or greater than the target
        return count >= target;
    }

    // An override method to display the goal status
    public override void DisplayStatus()
    {
        // Display the name, points, target and bonus of the goal
        Console.WriteLine(Name + " (" + Points + " points each, " + target + " times, " + bonus + " bonus points)");

        // Display the completion status of the goal
        if (IsCompleted())
        {
            Console.WriteLine("[X] Completed " + count + "/" + target + " times");
        }
        else
        {
            Console.WriteLine("[ ] Completed " + count + "/" + target + " times");
        }
    }
}