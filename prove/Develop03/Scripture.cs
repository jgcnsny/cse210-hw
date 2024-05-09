using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        _words =  text.Split(" ").Select(word => new Word(word)).ToList();
    }

    public void HiddenRandomWords(int numberToHide)
    {
        var randomWord = new Random();
        for(int i = 0; i < numberToHide; i++)
        {
            int index = randomWord.Next(_words.Count);
            _words[index].Hide();
        }
    }

    public string GetDisplayText()
    {
        string scripture = $"{_reference.GetDisplayText() }" + string.Join(" ",_words.Select(word => word.GetDisplayText()));
        return scripture;
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}