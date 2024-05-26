using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public int AmountCompleted
    {
        get {return _amountCompleted;}
        set {_amountCompleted = value;}
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }

    public override string GetDetailsString(int i)
    {
        string x = "";
        
        if (IsComplete())
        {
            x = "X";
        }

        return $"{i}. [{x}] {Name} ({Description}) -- Currently Completed: {_amountCompleted}/{_target}"; 
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal: {Name}, {Description}, {Points}, {_target}, {_bonus}, {_amountCompleted}";
    }
}