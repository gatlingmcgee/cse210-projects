using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program 
{
    static void Main(string[] args) {
        string txt = "Enter scripture here.";
        Reference reference = new Reference("Book", 55, 7);
        Scripture scripture = new Scripture(reference, txt);

        while(true)
        {
            Console.Clear();
            scripture.DisplayScripture();
            Console.WriteLine();

            Console.Write("Press enter or type quit to end program.");
            string input = Console.ReadLine();

            if (input == "quit")
            {
                break;
            }
            else
            {
                if (scripture.IsCompletelyhidden() == true)
                {
                    break;
                }
                else
                {
                    scripture>HiddenWords();
                }
            }
        }
    }
}












class Program
{
    static void Main()
    {
        Scripture scripture = new Scripture("Proverbs 3:5-6", "5. Trust in the Lord with all thine heart; and lean not unto thine own understanding. 6. In all thy ways aacknowledge him, and he shall be direct in all thy paths.");

        Console.Clear();
        scripture.DisplayScripture();

        while (true)
        {
            Console.WriteLine("Press enter to hide a word or type quit to exit:");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }
            else
            {
                Console.Clear();
                scripture.HideWord();
                scripture.DisplayScripture();

                if (scripture.AllWordsHidden())
                {
                    Console.WriteLine("Congratulations, you have memorized the scripture!");
                    break;
                }
            }
        }
    }
}