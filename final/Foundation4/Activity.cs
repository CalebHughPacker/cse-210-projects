using System;   

public abstract class Activity
{
    private string _date;
    private int _length; //in minutes
    private double _distance;
    private double _speed;
    private double _pace;
    private string _filename = "./fitnessrecords.txt";

    public Activity(int length)
    {
        DateTime dateTime = DateTime.Today;
        _date = dateTime.ToString("dd MMM yyyy");
        _length = length;
        _distance = Distance;
        _speed = Speed;
        _pace = Pace;
    }

    protected string Date
    {
        get {return _date;}
        set {_date = value;}
    }

     protected int Length
    {
        get {return _length;}
        set {_length = value;}
    }

    protected double Distance
    {
        get {return _distance;}
        set {_distance = value;}
    }

    protected double Speed
    {
        get {return _speed;}
        set {_speed = value;}
    }

    protected double Pace
    {
        get {return _pace;}
        set {_pace = value;}
    }

    protected string Filename
    {
        get {return _filename;}
        set {_filename = value;}
    }

    protected abstract double GetDistance();//Overridden in Swimming child class to instead ask for laps
    
    
    protected double GetSpeed() 
    {
        try
        {
            return Math.Round(_distance/_length * 60, 3);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("No distance recorded");
            return 0.0;
        }
    }

    protected double GetPace()
    {
        try
        {
            return Math.Round(60 / _speed, 3);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("No speed recorded");
            return 0.0;
        }
    }

    public string GetSummary()
    {
        try
        {
            return $"{_date:dd-MM-yyyy} {GetType().Name} ({_length} min)- Distance {_distance} miles, Speed {_speed} mph, Pace {_pace} min per mile";
        }
        catch (ArgumentNullException)
        {
            return "Not enough data provided to create a summary";
        }
    }

    public abstract void Record();
}