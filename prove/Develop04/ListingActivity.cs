using System;
using System.Collections.Generic;

// sub class
public class ListingActivity : Activity
{
    private List<string> _promptList = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        
    }

        private string DisplayPrompt()
        {
            Random random = new Random();
            int randomIndex = random.Next(0, _promptList.Count);
            string randomPrompt = _promptList[randomIndex];
            return randomPrompt;        
        }

        
        public void RunListingActivity()

        {
            GetStartingMessage();
            Console.WriteLine();            
            Console.WriteLine("List as many responses you can to the following prompt:");
            Console.WriteLine($"--- {DisplayPrompt()} ---");
            Console.WriteLine();
            Console.Write("You may begin in: ");  
            RunCounter(5);    
            Console.WriteLine();

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);

            int i = 0;

            while (DateTime.Now < endTime)
            {
                Console.Write(">");
                string input = Console.ReadLine();

                i++;

                if (i >= _duration)
                {
                    break;
                }
                
            }   
            Console.WriteLine($"You listed {i} items!");
            DisplayFinishingMessage();   
            Console.Clear();                          
        }
    }

