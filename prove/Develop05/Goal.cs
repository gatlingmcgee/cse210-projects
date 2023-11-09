using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
abstract class Goal
{
    protected string description;
    protected bool isCompleted;

    public Goal(string description)
    {
        this.description = description;
        this.isCompleted = false;
    }

    public virtual void RecordEvent()
    {
        isCompleted = true;
    }

    public virtual int GetValue()
    {
        return isCompleted ? 1 : 0;
    }

    public virtual string GetStatus()
    {
        return isCompleted ? "[X]" : "[ ]";
    }

    public string Description { get { return description; } }
}


















// class Goal
// {
//     protected string description;
//     protected bool isCompleted;

//     public Goal(string description)
//     {
//         this.description = description;
//         this.isCompleted = false;
//     }

//     public virtual void RecordEvent()
//     {
//         isCompleted = true;
//     }

//     public virtual int GetValue()
//     {
//         return isCompleted ? 1 : 0;
//     }

//     public virtual string GetStatus()
//     {
//         return isCompleted ? "Completed" : "Not Completed";
//     }

//     public string Description { get { return description; } }
// }
















// // Base class for all types of goals
// public abstract class Goal
// {
//     protected string Name { get; set; }
//     protected int Value { get; set; }
//     protected bool IsCompleted { get; set; }

//     public virtual void Complete()
//     {
//         IsCompleted = true;
//     }

//     public virtual void RecordEvent()
//     {
//         Console.WriteLine($"Event recorded for {Name}. You gained {Value} points.");
//     }

//     public abstract string GetStatus();
// }