using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
class EternalGoal : Goal
{
    public EternalGoal(string description) : base(description) { }

    public override int GetValue()
    {
        return 100;
    }
}
















// class EternalGoal : Goal
// {
//     public EternalGoal(string description) : base(description) { }

//     public override int GetValue()
//     {
//         return isCompleted ? 2 : 0;
//     }
// }













// // Eternal Goal class
// public class EternalGoal : Goal
// {
//     public EternalGoal(string name, int value)
//     {
//         Name = name;
//         Value = value;
//     }

//     public override void Complete()
//     {
//         Console.WriteLine($"You can't complete {Name}. You gained {Value} points.");
//     }

//     public override string GetStatus()
//     {
//         return "[ ] Not Completed";
//     }
// }