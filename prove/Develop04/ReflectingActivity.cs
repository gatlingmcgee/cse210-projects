using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// sub class
public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };


    private List<string> _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        private HashSet<string> _usedPrompts = new HashSet<string>();
        private HashSet<string> _usedQuestions = new HashSet<string>();

        public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
        {

        }
        private string DisplayPrompt()
        {
            Random random = new Random();
            int randomIndex = random.Next(0, _prompts.Count);
            string randomPrompt = _prompts[randomIndex];
            return randomPrompt;        
        }

        private string DisplayQuestion()
        {
            _questions = _questions.OrderBy(x => Guid.NewGuid()).ToList();

            foreach (var question in _questions)
            {
                if (!_usedQuestions.Contains(question))
                {
                    _usedQuestions.Add(question);
                    return question;
                }
            }
            return null;
        }

        public void RunReflectingActivity()
        {
            GetStartingMessage();
            Console.WriteLine();
            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine();
            Console.WriteLine($"--- {DisplayPrompt()} ---");
            Console.WriteLine();
            Console.WriteLine("When you have something in mind, press enter to continue.");
            Console.ReadLine();
            Console.WriteLine(); 
            Console.WriteLine("Now ponder on each of the following questions as they're related to this experience");
            Console.Write("You may begin in: ");  
            RunCounter(5);
            Console.Clear();

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);

            int i = 0;

            while (DateTime.Now < endTime)
            {

                Console.Write($"> {DisplayQuestion()} ");
                RunSpinner(10);
                Console.WriteLine();

                i++;

                if (i >= _duration)
                {
                    break;
                }
            }   
            DisplayFinishingMessage();   
            Console.Clear();                          
        }
}