using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create an address
        Address eventAddress = new Address("4217 W Seattle St", "Broken Arrow", "OK", "USA");

        // Create events
        // Event lectureEvent = new LectureEvent("Lean Manufacturing", "Come learn what LEAN means!", new DateTime(2023, 11, 10, 14, 30, 0), eventAddress, "Sean Sonderegger", 100);
        Event receptionEvent = new ReceptionEvent("Safty First", "An opportunity to catch up on safty.", new DateTime(2023, 12, 5, 18, 0, 0), eventAddress, "Scott Fox");
        // Event outdoorEvent = new OutdoorEvent("Quarterly Report", "Come see how the company is doing!", new DateTime(2023, 7, 15, 12, 0, 0), eventAddress, "Louie Sanz");

        // Display marketing messages for each event
        Console.Clear();
        // DisplayEventDetails(lectureEvent);
        DisplayEventDetails(receptionEvent);
        // DisplayEventDetails(outdoorEvent);
    }

    static void DisplayEventDetails(Event theEvent)
    {
        Console.WriteLine("Standard details:");
        Console.WriteLine(theEvent.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full details:");
        Console.WriteLine(theEvent.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short description:");
        Console.WriteLine(theEvent.GetShortDescription());
        Console.WriteLine();
    }
}








