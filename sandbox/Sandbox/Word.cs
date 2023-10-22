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

    public Word(string text) 
    {
        if (string.IsNullOrEmpty(text))
        {
            throw new ArgumentException("text cannot be empty", nameof(text));
        }
        _word = text;
        _hidden = false;
    }

    public string GetRenderedWord() 
    {
        string renderedWord = _word;

        if (_hidden == false)
        {
            return renderedWord;
        }
        else
        {
            renderedWord = string.Concat(Enumerable.Repeat("_", _word.length));
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