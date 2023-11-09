using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
class SimpleGoal : Goal
{
    public SimpleGoal(string description) : base(description) { }

    public override void RecordEvent()
    {
        base.RecordEvent();
    }

    public override int GetValue()
    {
        return isCompleted ? 1000 : 0;
    }
}













// class SimpleGoal : Goal
// {
//     public SimpleGoal(string description) : base(description) { }

//     public override void RecordEvent()
//     {
//         base.RecordEvent();
//     }

//     public override int GetValue()
//     {
//         return isCompleted ? 5 : 0;
//     }
// }















// // Simple Goal class
// public class SimpleGoal : Goal
// {
//     public SimpleGoal(string name, int value)
//     {
//         Name = name;
//         Value = value;
//     }

//     public override string GetStatus()
//     {
//         return IsCompleted ? "[X] Completed" : "[ ] Not Completed";
//     }
// }