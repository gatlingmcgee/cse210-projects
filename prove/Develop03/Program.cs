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
        string scrip = "6. Wherefore, redemption cometh in and through the Holy Messiah; for he is full of grace and truth. Behold, he offereth himself a sacrifice for sin, to answer the ends of the law, unto all those who have a broken heart and a contrite spirit; and unto none else can the ends of the law be answered.";
        Reference reference = new Reference("2 Nephi", "2", "6-7");
        Scripture scripture = new Scripture(reference, scrip);

        while(true)
        {
            Console.Clear();
            scripture.DisplayScripture();
            Console.WriteLine();
            Console.Write("Please press enter until scripture is hidden or type quit to end program.");
            string input = Console.ReadLine();

            if (input == "quit")
            {
                break;
            }
            else
            {
                if (scripture.IsHidden() == true)
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




