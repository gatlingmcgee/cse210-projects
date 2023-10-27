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
    private string chapter;
    private string verse;

    public Reference(string books, string chapters, string verses)
    {
        book = books;
        chapter = chapters;
        verse = verses;
    }

    public Reference(string books, string chapters, string verses, string endVerse)
    {
        book = books;
        chapter = chapters;
        verse = $"{verses}-{endVerse}";
    }

    public string GetReference()
    {
        return $"{book} {chapter}: {verse}";
    }
}

