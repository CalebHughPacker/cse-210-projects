using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal (string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false;
        IsCompleted = _isComplete;
    }

    public bool IsCompleted 
    {
        get {return _isComplete;}
        set {_isComplete = value;}
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal: {Name}, {Description}, {Points}, {_isComplete}";
    }
}