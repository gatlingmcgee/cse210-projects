using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

public class Program
{
    public static void Main()
    {
        GoalManager goalManager = new GoalManager();

        SimpleGoal simpleGoal = new SimpleGoal("Run a marathon");
        EternalGoal eternalGoal = new EternalGoal("Read scriptures");
        ChecklistGoal checklistGoal = new ChecklistGoal("Attend temple", 10);

        goalManager.AddGoal(simpleGoal);
        goalManager.AddGoal(eternalGoal);
        goalManager.AddGoal(checklistGoal);

        goalManager.RecordEvent(0);
        goalManager.RecordEvent(1);
        goalManager.RecordEvent(2);
        goalManager.RecordEvent(2);
        goalManager.RecordEvent(2);

        goalManager.DisplayGoals();
        goalManager.DisplayScore();

        // Save and load goals
        goalManager.SaveGoals("goals.dat");
        goalManager.LoadGoals("goals.dat");

        Console.WriteLine("\nGoals after loading:");
        goalManager.DisplayGoals();
        goalManager.DisplayScore();
    }
}















// public class Program
// {
//     public static void Main()
//     {
//         GoalManager goalManager = new GoalManager();

//         SimpleGoal simpleGoal = new SimpleGoal("Complete a simple goal");
//         EternalGoal eternalGoal = new EternalGoal("Record an eternal goal");
//         ChecklistGoal checklistGoal = new ChecklistGoal("Complete checklist goal", 3);

//         goalManager.AddGoal(simpleGoal);
//         goalManager.AddGoal(eternalGoal);
//         goalManager.AddGoal(checklistGoal);

//         goalManager.RecordEvent(0);
//         goalManager.RecordEvent(1);
//         goalManager.RecordEvent(2);
//         goalManager.RecordEvent(2);
//         goalManager.RecordEvent(2);

//         goalManager.DisplayGoals();
//         goalManager.DisplayScore();
//     }
// }





// class Program
// {
//     static void Main()
//     {
//         User user = new User();
//         user.AddGoal(new SimpleGoal("Run a Marathon", 1000));
//         user.AddGoal(new EternalGoal("Read Scriptures", 100));
//         user.AddGoal(new ChecklistGoal("Attend Temple", 50, 10));

//         user.DisplayGoals();

//         user.RecordEvent(0);
//         user.RecordEvent(1);
//         user.RecordEvent(2);
//         user.RecordEvent(2);
//         user.RecordEvent(2);
//         user.RecordEvent(2);
//         user.RecordEvent(2);
//         user.RecordEvent(2);
//         user.RecordEvent(2);
//         user.RecordEvent(2);
//         user.RecordEvent(2);

//         user.DisplayGoals();

//         user.SaveGoals("goals.txt");

//         User loadedUser = new User();
//         loadedUser.LoadGoals("goals.txt");

//         loadedUser.DisplayGoals();
//     }
// }