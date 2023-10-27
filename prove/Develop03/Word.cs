using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// A class to represent a word in the scripture
public class Word 
{
    private string word;
    private bool hidden;

    public Word(string text) 
    {
        if (string.IsNullOrEmpty(text))
        {
            throw new ArgumentException("text cannot be empty", nameof(text));
        }
        word = text;
        hidden = false;
    }
    public string GetWords() 
    {
        // string renderedWord = word;

        if (hidden == false)
        {
            return word;
        }
        else
        {
            string renderedWord = string.Concat(Enumerable.Repeat("_", word.Length));
            return renderedWord;
        }
    }
    public void Hide() 
    {
        hidden = true;
    }
    public void show() 
    {
        hidden = false;
    }
    public bool IsHidden() 
    {
        if (hidden == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}