using System;


// sub class
public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        
    }

    private void ShowBreathInMessage(int seconds)
    {
        Console.WriteLine();
        Console.Write("Breathe in...");
        RunCounter(seconds);
    }

    private void ShowBreathOutMessage(int seconds)
    {
        Console.WriteLine();
        Console.Write("Now breathe out...");
        RunCounter(seconds);
    }

    public void RunBreathingActivity()
    {
        GetStartingMessage();
        Console.WriteLine();
        ShowBreathInMessage(2);
        ShowBreathOutMessage(3);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            ShowBreathInMessage(4);
            ShowBreathOutMessage(6);
            Console.WriteLine();

            i++;

            if (i >= _duration)
            {
                i = 0;
            }
        }
        DisplayFinishingMessage();
    }
}

