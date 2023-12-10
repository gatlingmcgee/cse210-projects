using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lectureEvent = new Lecture("Lean Manufacturing", "Come learn what LEAN means!", "December 21st, 2023", "6:00 PM",
            new Address("28111 E 161st St S", "Coweta", "OK", "72365"), "Sean Sonderegger", 250);

        Reception receptionEvent = new Reception("Safty First", "An opportunity to catch up on safty.", "December 23st, 2023", "4:30 PM",
            new Address("1007 Blind Bay Road", "Blue River", "BC", "54326"), "rsvp@yahoo.com");

        OutdoorEvent outdoorEvent = new OutdoorEvent("Quarterly Report", "Come see how the company is doing!", "December 27st, 2023", "12:30 PM",
            new Address("28006 E. 61st", "Broken Arrow", "OK", "74014"));

        Console.WriteLine("*** LECTURE EVENT ***");
        Console.WriteLine("--- Standard Details ---\n" + lectureEvent.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("--- Full Details ---\n" + lectureEvent.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("--- Short Description ---\n" + lectureEvent.GetShortDescription());

        Console.WriteLine("\n*** RECEPTION EVENT ***");
        Console.WriteLine("--- Standard Details ---\n" + receptionEvent.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("--- Full Details ---\n" + receptionEvent.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("--- Short Description ---\n" + receptionEvent.GetShortDescription());

        Console.WriteLine("\n*** OUTDOOR EVENT ***");
        Console.WriteLine("--- Standard Details ---\n" + outdoorEvent.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("--- Full Details ---\n" + outdoorEvent.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("--- Short Description ---\n" + outdoorEvent.GetShortDescription());
        Console.WriteLine();
    }
}
