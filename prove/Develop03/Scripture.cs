using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        _words = new List<Word>();

        string[] wordArray = text.Split(' ');

        foreach (string wordText in wordArray)
        {
            Word word = new Word(wordText);
            _words.Add(word);
        }
    }

    public void HiddenRandomWords(int numberToHide)
    {
        Random random = new Random();
        List<Word> visibleWords = new List<Word>();

        foreach (Word word in _words)
        {
            if (!word.GetDisplayText().Contains("_____"))
            {
                visibleWords.Add(word);
            }
        }

        if (visibleWords.Count <= numberToHide)
        {
            foreach (Word word in visibleWords)
            {
                word.Hide();
            }
        }
        else
        {
            List<Word> wordsToHide = new List<Word>();

            while (wordsToHide.Count < numberToHide)
            {
                int index = random.Next(0, visibleWords.Count);
                Word word = visibleWords[index];

                if (!wordsToHide.Contains(word))
                {
                    wordsToHide.Add(word);
                    word.Hide();
                }
            }
        }
    }

    public string GetDisplayText()
    {
        string scripture = _reference.GetDisplayText() + " ";

        foreach (Word word in _words)
        {
            scripture += word.GetDisplayText() + " ";
        }

        return scripture;
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}