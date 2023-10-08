using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Develop02;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void DisplayEntries()
    {
        foreach (Entry ent in _entries)
        {
            Console.WriteLine(ent.Displaystring());
        }
    }
    public void SaveToFile(string filename)
    {
   
        using (StreamWriter outputfile = new StreamWriter(filename))
        foreach (Entry ent in _entries)
        {
            outputfile.WriteLine(ent.Displaystring());
        }
    }

    public void LoadJournal(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            Console.WriteLine(parts[0]);
        }
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
}