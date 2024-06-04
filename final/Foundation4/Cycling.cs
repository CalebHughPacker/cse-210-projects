using System;

public class Cycling : Activity
{
    public Cycling(int length, double speed) : base(length)
    {
        Speed = speed;
        Distance = GetDistance();
        Pace = GetPace();
    }

    protected override double GetDistance()
    {
        return Math.Round(Length * Speed / 60, 3);
    }

    public override void Record()
    {   
        using (StreamWriter outputFile = new StreamWriter(Filename, true))
        {
            outputFile.WriteLine($"Cycling: {Date} - {Length} min - {Speed} mph");
        }
    }

    
    
}