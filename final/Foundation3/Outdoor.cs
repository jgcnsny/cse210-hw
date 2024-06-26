using System;



public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public override string GetFullDetails()
    {
        
        return $"Type: Outdoor {base.GetFullDetails()}\nWeather: {_weather}";
    }

    public override string GetShortDescription()
    {
        return $"Outdoor - {base.GetShortDescription()}";
    }
}