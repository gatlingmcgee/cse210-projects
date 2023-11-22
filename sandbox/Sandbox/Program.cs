using System;
using System.Collections.Generic;
using System.IO;
// For exceeding requirements I have added an option to be able to contemplate the day and deduct points if needed.
class Program
{
    static private List<Goal> theGoals = new List<Goal>();
    static void Main(string[] args)
    {
        int earnedPoints = 0;

        do
        {
            Console.WriteLine();
            Console.WriteLine($"You have {earnedPoints} points.");
            Console.WriteLine();
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Create New Goals");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record event");
            // Console.WriteLine("6. Subtract Points");
            Console.WriteLine("7. Quit");
            Console.Write("Select a choice from the menu: ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("1. Simple goal.");
                Console.WriteLine("2. Eternal goal.");
                Console.WriteLine("3. Checklist goal.");
                Console.WriteLine("4. Negetive goal.");
                Console.Write("What type of goal would you like to create? ");
                string goalTypeInput = Console.ReadLine();

                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();

                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                int points = int.Parse(Console.ReadLine());

                if (goalTypeInput == "1")
                {
                    theGoals.Add(new SimpleGoal(name, description, points));
                }

                if (goalTypeInput == "2")
                {
                    theGoals.Add(new EternalGoal(name, description, points));
                }

                if (goalTypeInput == "3")
                {
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int times = int.Parse(Console.ReadLine());

                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonus = int.Parse(Console.ReadLine());

                    theGoals.Add(new ChecklistGoal(name, description, points, times, bonus));
                }

                if (goalTypeInput == "4")
                {
                    theGoals.Add(new NegativeGoal(name, description, points));
                }


            }
            else if (input == "2")
            {
                Console.WriteLine();
                DisplayGoals();
            }
            else if (input == "3")
            {
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();

                using StreamWriter outputFile = new StreamWriter(filename);
                outputFile.WriteLine(earnedPoints);

                foreach (Goal goal in theGoals)
                {
                    outputFile.WriteLine(goal.ToSavedString());
                }
            }
            else if (input == "4")
            {
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();

                string[] lines = System.IO.File.ReadAllLines(filename);
                earnedPoints = int.Parse(lines[0]);
                theGoals.Clear();

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(",");

                    if (parts[0] == "SimpleGoal")
                    {
                        theGoals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
                    }
                    else if (parts[0] == "EternalGoal")
                    {
                        theGoals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                    }
                    else if (parts[0] == "ChecklistGoal")
                    {
                        theGoals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));
                    }
                }
            }
            else if (input == "5")
            {
               
                int counter = 1;
                Console.WriteLine("The goals are:");
                foreach (var goal in theGoals)
                {
                    Console.WriteLine($"{counter}. {goal.GetName()}");
                    counter = counter + 1;

                }
                Console.Write("Which goal did you accomplish? ");
                int goalIndex = int.Parse(Console.ReadLine());
                int points = theGoals[goalIndex - 1].RegisterGoal();
                earnedPoints += points;

                Console.WriteLine();

                Console.WriteLine($"Congratulations! You have earned {points} points!");

                Console.WriteLine($"You now have {earnedPoints} points.");
            }
            // else if (input == "6")
            // {
            //     Console.WriteLine("Contemplate the goals you have fallen short of today.");
            //     Console.Write("Enter the number of points to subtract from your points: ");
            //     int pointsToSubtract = int.Parse(Console.ReadLine());
            //     earnedPoints -= pointsToSubtract;
            //     Console.WriteLine($"Subtracted {pointsToSubtract} points. You now have {earnedPoints} points.");
            // }
            else if (input == "7")
            {
                break;
            }

        } while (true);
    }

    static void DisplayGoals()

    {
        int counter = 1;
        Console.WriteLine("The goals are:");
        foreach (var goal in theGoals)
        {
            Console.WriteLine($"{counter}. {goal.GetString()}");
            counter = counter + 1;

        }
        Console.WriteLine();
    }

}