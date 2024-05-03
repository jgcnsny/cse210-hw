using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach(Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter journalSave = new StreamWriter(file))
            {
                foreach (Entry entry in _entries)
                {
                    journalSave.WriteLine(entry._date);
                    journalSave.WriteLine(entry._promptText);
                    journalSave.WriteLine(entry._entryText);
                }
            }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();

        string[] lines = File.ReadAllLines(file);

        foreach(string line in lines)
        {
            string[] parts = line.Split(",");

            string _date = parts[0];
            string _promptText = parts[1];
            string _entryText = parts[2];
        }
    }
}