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
                    journalSave.WriteLine(entry._imagePath);
                }
            }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();

        
            using (StreamReader loadJournal = new StreamReader(file))
            {
                while (!loadJournal.EndOfStream)
                {
                    string date = loadJournal.ReadLine();
                    string promptText = loadJournal.ReadLine();
                    string entryText = loadJournal.ReadLine();
                    string image = loadJournal.ReadLine();

                    Entry entry = new Entry();
                    entry._date = date;
                    entry._promptText = promptText;
                    entry._entryText = entryText;
                    entry._imagePath = image;

                    _entries.Add(entry);

                }
            }
    }
}