using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// A class to represent a scripture reference
public class Reference
{
    private string book;
    private int chapter;
    private int startVerse;
    private int endVerse;
    
    public string Book
    {
        get { return book; }
        set { book = value; }
    }
    public int Chapter
    {
        get { return chapter; }
        set { chapter = value; }
    }
    public int StartVerse
    {
        get { return startVerse; }
        set { startVerse = value; }
    }
    public int EndVerse
    {
        get { return endVerse; }
        set { endVerse = value; }
    }
    public Reference(string book, int chapter, int verse)
    {
        this.book = book;
        this.chapter = chapter;
        this.startVerse = verse;
        this.endVerse = verse;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        this.book = book;
        this.chapter = chapter;
        this.startVerse = startVerse;
        this.endVerse = endVerse;
    }
    public string GetRenderedReference()
    {
        string renderedReference;
        if (startVerse == endVerse)
        {
            renderedReference = $"{book} {chapter}:{startVerse}";
            return renderedReference;
        }
        else
        {
            renderedReference = $"{book} {chapter}:{startVerse}-{endVerse}";
            return renderedReference;
        }
    }
}

