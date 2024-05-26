using System;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string Name 
    {
        get {return _shortName;}
        set {_shortName = value;}
    }
    public string Description
    {
        get {return _description;}
        set {_description = value;}
    }
    public string Points 
    {
        get {return _points;}
        set {_points = value;}
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString(int i)
    {
        string x = "";
        
        if (IsComplete())
        {
            x = "X";
        }

        return $"{i}. [{x}] {_shortName} ({_description})";
        
    }

    public abstract string GetStringRepresentation();
}