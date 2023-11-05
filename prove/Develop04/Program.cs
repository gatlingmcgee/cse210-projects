using System;

class Program
{
    static void Main(string[] args)

    {
        while (true)
        {
            Console.Clear();             
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");        
            string input = Console.ReadLine();

            if (input == "1")
            {
                BreathingActivity acvtivity1 = new BreathingActivity();
                acvtivity1.RunBreathingActivity();
            }
            else if (input == "2")
            {
                ReflectingActivity activity2 = new ReflectingActivity();
                activity2.RunReflectingActivity();
            }
            else if (input == "3")
            {
                ListingActivity activity3 = new ListingActivity();
                activity3.RunListingActivity();
            }    
            else if (input == "4")
            {
                Console.WriteLine("Thank you for using Mindfulness Program!");
                break;
            }
        }
    }
}
