using System;

// Checklist Goal class
public class ChecklistGoal : Goal
{
    protected int numberOfTimes;
    protected int bonusAmount;
    protected int completedTimes;

    public ChecklistGoal(string name, string description, int points, int times, int bonus, int timesDone = 0)
        : base(name, description, points, times, bonus, timesDone)
    {
        numberOfTimes = times;
        bonusAmount = bonus;
        completedTimes = timesDone;
    }

    public override string GetString()
    {
        string cross = completedTimes == numberOfTimes ? "X" : " ";
        return $"[{cross}] {theName} ({theDescription}) -- Currently complete: {completedTimes}/{numberOfTimes}";
    }

    public override int RegisterGoal()
    {
        completedTimes++;

        if (completedTimes == numberOfTimes)
        {
            goalCompleted = true;
            return thePoints + bonusAmount;
        }

        return thePoints;
    }

    public override string ToSavedString()
    {
        return $"{this.GetType().Name},{theName},{theDescription},{thePoints},{numberOfTimes},{bonusAmount},{completedTimes}";
    }
}