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
        string scrip = "5. There is no such thing as immaterial matter. 6. All spirit is matter, but it is more fine or pure, and can only be dicerned by purer eyes.";
        Reference book = new Reference("D&C", 131, 5);
        Scripture scripture = new Scripture(book, scrip);
        while(true)
        {
            Console.Clear();
            scripture.DisplayScripture();
            Console.WriteLine();
            Console.Write("Please press enter or type quit to end program.");
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




