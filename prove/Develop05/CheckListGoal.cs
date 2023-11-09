using System;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;

    public ChecklistGoal(string description, int targetCount) : base(description)
    {
        this.targetCount = targetCount;
        this.currentCount = 0;
    }

    public override void RecordEvent()
    {
        currentCount++;
        if (currentCount >= targetCount)
        {
            isCompleted = true;
        }
    }

    public override int GetValue()
    {
        return isCompleted ? 500 : 50;
    }

    public override string GetStatus()
    {
        return $"Completed {currentCount}/{targetCount} times";
    }
}




















// class ChecklistGoal : Goal
// {
//     private int targetCount;
//     private int currentCount;

//     public ChecklistGoal(string description, int targetCount) : base(description)
//     {
//         this.targetCount = targetCount;
//         this.currentCount = 0;
//     }

//     public override void RecordEvent()
//     {
//         currentCount++;
//         if (currentCount >= targetCount)
//         {
//             isCompleted = true;
//         }
//     }

//     public override int GetValue()
//     {
//         return isCompleted ? 10 : 0;
//     }

//     public override string GetStatus()
//     {
//         return $"{currentCount}/{targetCount} completed";
//     }
// }












// // Checklist Goal class
// public class ChecklistGoal : Goal
// {
//     private int CompletedCount { get; set; }
//     private int RequiredCount { get; set; }

//     public ChecklistGoal(string name, int value, int requiredCount)
//     {
//         Name = name;
//         Value = value;
//         RequiredCount = requiredCount;
//     }

//     public override void RecordEvent()
//     {
//         CompletedCount++;
//         Console.WriteLine($"Event recorded for {Name}. You gained {Value} points.");
//         if (CompletedCount == RequiredCount)
//         {
//             Console.WriteLine($"You completed {Name}! You gained an extra bonus.");
//             IsCompleted = true;
//         }
//     }

//     public override string GetStatus()
//     {
//         return $"Completed {CompletedCount}/{RequiredCount} times";
//     }
// }