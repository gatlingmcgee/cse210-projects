using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// A class to represent a scripture
public class Scripture
{
    private Reference _reference;
    private List<Word> _scripture = new List<Word>();

    public Scripture(Reference reference, string text) {
        -reference = reference;

        string[] words = text.Split(" ");

        foreach (string w in words) {
            Word word = new Word(w);
            _scripture.Add(word);
            
        }
    }


    public void DisplayScripture() {
        Console.WriteLine(_reference.GetRenderedReference());

        foreach (Word word in _scripture)
        {
            Console.Write(word.GetRenderedWord() + " ");
        }

        Console.WriteLine();
    }

    public void HiddenWords() {
        int number;

        for (int i = 0; i < 3; i++) {
            while(true)
            {
                Random rendomGenerator = new Random();
                number = rendomGenerator.Next(0, _scripture.Count);

                Word word = _scripture[number];

                if (word.IsHidden() == false)
                {
                    word.Hide();
                    break;
                }
            }
        }
    }

    public bool IsCompletelyhidden() {
        int count = 0;

        foreach (Word word in _scripture)
        {
            if (word.IsHidden() == true)
            {
                count++;
            }
        }

        if (count == _scripture.Count)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
}