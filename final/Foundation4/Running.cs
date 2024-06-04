using System;

public class Running : Activity
{
    public Running(int length, double distance) : base(length)
    {
        Distance = distance;
        Speed = GetSpeed();
        Pace = GetPace();
    }
    protected override double GetDistance()
    {
        return Distance;
    } 

    public override void Record()
    {   
        using (StreamWriter outputFile = new StreamWriter(Filename, true))
        {
            outputFile.WriteLine($"Running: {Date} - {Length} min - {Distance} mi");
        }
    }
}