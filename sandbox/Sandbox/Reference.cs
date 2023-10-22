using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// A class to represent a scripture reference
public class Reference 
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;


    public Reference(string book, int chapter, int verse) 
    {
    _book = book;
    _chapter = chapter;
    _startVerse = verse;
    _endVerse = -1;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse) 
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public string GetRenderedReference() 
    {
        string renderedReference;

        if (_endVerse == 0)
        {
            renderedReference = $"{_book} {_chapter}:{_startVerse}";
            return renderedReference;
        }
        else
        {
            renderedReference = $"{_book} {_chapter}:{_startVerse}-{endVerse}";
            return renderedReference;
        }
    }    
}

