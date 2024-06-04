using System;

public class Swimming : Activity
{
    private int _laps;
    public Swimming(int length, int laps) : base(length)
    {
        _laps = laps;
        Distance = GetDistance();
        Speed = GetSpeed();
        Pace = GetPace();
    }

    protected override double GetDistance()
    {
        double lapsDouble = _laps;
        return Math.Round(lapsDouble * 50 / 1000 * 0.62, 3);
    }

    public override void Record()
    {   
        using (StreamWriter outputFile = new StreamWriter(Filename, true))
        {
            outputFile.WriteLine($"Swimming: {Date} - {Length} min - {_laps} laps");
        }
    }

    
    
}