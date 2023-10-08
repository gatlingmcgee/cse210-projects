using System;
using System.Net.Quic;
using System.Runtime.InteropServices;
using System.Transactions;
using System.Collections.Generic;
using Develop02;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your journal!");

        PromptGenerator promptGenerator = new PromptGenerator();
        Entry entry = new Entry();
        Journal journal = new Journal();
        UpliftMessage message = new UpliftMessage();


        while (true)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");

            string option = Console.ReadLine();
            if (option == "1")
            {
                string prompt = promptGenerator.GetPrompt();
                Console.WriteLine(prompt);
                string response = Console.ReadLine();
                string date = DateTime.Now.ToString();
                entry = new Entry();

                entry._prompt = prompt;
                entry._answer = response;
                entry._date = date;

                journal.AddEntry(entry);
                Console.WriteLine();
        }
        else if (option == "2")
        {
            journal.DisplayEntries();
            Console.WriteLine();
        }
        else if (option == "3")
        {
            Console.WriteLine("What is the file name?");
            string filename = Console.ReadLine();
            journal.LoadJournal(filename);
        }
        else if (option == "4")
        {
            Console.WriteLine("What is the file name?");
            string filename = Console.ReadLine();            
            journal.SaveToFile(filename);
        }
        else if (option == "5")
        {
            break;
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Oops, please enter a valid number.");
            Console.WriteLine();
        }
    }
    Console.WriteLine();
    Console.WriteLine("Thanks, here is an uplifting quote for you!");
        string mes1 = message.GetPrompt();
        Console.WriteLine(mes1);
        Console.WriteLine();
    }
}
