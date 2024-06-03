using System;


public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string GetFullDetails()
    {
        
        return $"Type: Lecture {base.GetFullDetails()}\nSpeaker: {_speaker}\n{_capacity}";
    }

    public override string GetShortDescription()
    {
        return $"Lecture - {base.GetShortDescription()}";
    }
}