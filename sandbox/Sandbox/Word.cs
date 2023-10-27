using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// A class to represent a word in the scripture
public class Word 
{
    private string _word;
    private bool _hidden;
    public Word(string scrip) 
    {
        if (string.IsNullOrEmpty(scrip))
        {
            throw new ArgumentException("scrip cannot be empty", nameof(scrip));
        }
        _word = scrip;
        _hidden = false;
    }
    public string GetWord() 
    {
        if (_hidden == false)
        {
            return _word;
        }
        else
        {
            string renderedWord = string.Concat(Enumerable.Repeat("_", _word.Length));
            return renderedWord;
        }
    }
    public void Hide() 
    {
        _hidden = true;
    }
    public void show() 
    {
        _hidden = false;
    }
    public bool IsHidden() 
    {
        if (_hidden == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}