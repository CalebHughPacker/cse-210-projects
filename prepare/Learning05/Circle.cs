using System;

public class Circle : Shape
{
    private double _radius; 
    public Circle(string color, double radius) : base(color)
    {
        Radius = radius;
    }

    public double Radius
    {
        get { return _radius; }
        set { _radius = value; }
    }

    public override double GetArea()
    {
        return Radius*Radius*Math.PI;
    }
}