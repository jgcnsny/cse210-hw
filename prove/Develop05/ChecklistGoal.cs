using System;

public class CheckListGoals : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public CheckListGoals(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }
    public override int RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            if (_amountCompleted == _target)
            {
                return _points + _bonus;
            }
            return _points;
        }
        return 0;
    }

    public override bool isComplete()
    {
        return  _amountCompleted >= _target;
    }

     public override string GetDetailsString()
    {
        return $" {_shortName} ({_description})--Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
       return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_target}|{_amountCompleted}|{_bonus}";
    }
}