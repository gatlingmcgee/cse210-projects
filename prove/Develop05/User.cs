using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int score = 0;

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            goals[goalIndex].RecordEvent();
            score += goals[goalIndex].GetValue();
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Description} - {goals[i].GetStatus()}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Score: {score}");
    }

    public void SaveGoals(string fileName)
    {
        using (FileStream fs = new FileStream(fileName, FileMode.Create))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, goals);
        }
    }

    public void LoadGoals(string fileName)
    {
        using (FileStream fs = new FileStream(fileName, FileMode.Open))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            goals = (List<Goal>)formatter.Deserialize(fs);
        }
    }
}
















// class GoalManager
// {
//     private List<Goal> goals = new List<Goal>();
//     private int score = 0;

//     public void AddGoal(Goal goal)
//     {
//         goals.Add(goal);
//     }

//     public void RecordEvent(int goalIndex)
//     {
//         if (goalIndex >= 0 && goalIndex < goals.Count)
//         {
//             goals[goalIndex].RecordEvent();
//             score += goals[goalIndex].GetValue();
//         }
//     }

//     public void DisplayGoals()
//     {
//         Console.WriteLine("Goals:");
//         for (int i = 0; i < goals.Count; i++)
//         {
//             Console.WriteLine($"{i + 1}. {goals[i].Description} - {goals[i].GetStatus()}");
//         }
//     }

//     public void DisplayScore()
//     {
//         Console.WriteLine($"Score: {score}");
//     }
// }






// // User class to manage goals and score
// public class User
// {
//     private List<Goal> Goals { get; set; } = new List<Goal>();
//     private int Score { get; set; } = 0;

//     public void AddGoal(Goal goal)
//     {
//         Goals.Add(goal);
//     }

//     public void RecordEvent(int goalIndex)
//     {
//         Goals[goalIndex].RecordEvent();
//         Score += Goals[goalIndex].Value;
//     }

//     public void DisplayGoals()
//     {
//         for (int i = 0; i < Goals.Count; i++)
//         {
//             Console.WriteLine($"{i + 1}. {Goals[i].Name}: {Goals[i].GetStatus()}");
//         }
//         Console.WriteLine($"Score: {Score}");
//     }

//     public void SaveGoals(string filePath)
//     {
//         using (StreamWriter writer = new StreamWriter(filePath))
//         {
//             foreach (var goal in Goals)
//             {
//                 writer.WriteLine($"{goal.GetType().Name}|{goal.Name}|{goal.Value}|{goal.IsCompleted}");
//             }
//             writer.WriteLine($"Score|{Score}");
//         }
//     }

//     public void LoadGoals(string filePath)
//     {
//         Goals.Clear();
//         Score = 0;
//         using (StreamReader reader = new StreamReader(filePath))
//         {
//             string line;
//             while ((line = reader.ReadLine()) != null)
//             {
//                 string[] parts = line.Split('|');
//                 if (parts[0] == "SimpleGoal")
//                     Goals.Add(new SimpleGoal(parts[1], int.Parse(parts[2])) { IsCompleted = bool.Parse(parts[3]) });
//                 else if (parts[0] == "EternalGoal")
//                     Goals.Add(new EternalGoal(parts[1], int.Parse(parts[2])) { IsCompleted = bool.Parse(parts[3]) });
//                 else if (parts[0] == "ChecklistGoal")
//                     Goals.Add(new ChecklistGoal(parts[1], int.Parse(parts[2]), int.Parse(parts[3])) { IsCompleted = bool.Parse(parts[4]) });
//                 else if (parts[0] == "Score")
//                     Score = int.Parse(parts[1]);
//             }
//         }
//     }
// }