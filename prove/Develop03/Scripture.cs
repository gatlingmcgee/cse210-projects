using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// A class to represent a scripture
public class Scripture
{
    private Reference refer;
    private List<Word> scrip = new List<Word>();

    public Scripture(Reference reference, string script) 
    {
        refer = reference;
        string[] words = script.Split(" ");
        foreach (string w in words) 
        {
            Word word = new Word(w);
            scrip.Add(word);
            
        }
    }

    public void DisplayScripture() 
    {
        Console.WriteLine(refer.GetReference());
        foreach (Word word in scrip)
        {
            Console.Write(word.GetWords() + " ");
        }

        Console.WriteLine();
    }

    public void HiddenWords() 
    {
        int number;
        for (int i = 0; i < 3; i++) 
        {
            while(true)
            {
                Random randomGenerator = new Random();
                number = randomGenerator.Next(0, scrip.Count);
                Word word = scrip[number];
                if (word.IsHidden() == false)
                {
                    word.Hide();
                    break;
                }
            }
        }
    }

    public bool IsHidden() 
    {
        int count = 0;
        foreach (Word word in scrip)
        {
            if (word.IsHidden() == true)
            {
                count++;
            }
        }
        if (count == scrip.Count)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
}