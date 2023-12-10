using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        RunningActivity runningActivity = new RunningActivity("6 December 2023", 45, 3.2);
        CyclingActivity cyclingActivity = new CyclingActivity("7 December 2023", 120, 19.5);
        SwimmingActivity swimmingActivity = new SwimmingActivity("8 December 2023", 25, 25);           

        List<Activity> activities = new List<Activity>
        {
            runningActivity, cyclingActivity, swimmingActivity
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
