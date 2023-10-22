using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program 
{
    static void Main(string[] args) 
    {
        string txt = "For God so loved the world he gave his only begoton son.";
        Reference reference = new Reference("John", 3, 16);
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
                    scripture.HiddenWords();
                }
            }
        }
    }
}




