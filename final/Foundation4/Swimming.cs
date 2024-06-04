using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, double minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 * 0.62 / 1000;

       // return _laps * 0.03106855;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _minutes) * 60;
    }

    public override double GetPace()
    {
        return  60 / GetSpeed();
    }
    public override string GetSummary()
    {
        return $"{_date} Swimming ({_minutes} min) - Distance: {GetDistance():F3} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min per miles";
    }
}
