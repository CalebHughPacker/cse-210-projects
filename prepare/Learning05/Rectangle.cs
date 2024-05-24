using System;

public class Rectangle : Shape
{
    private double _length;
    private double _width; 
    public Rectangle(string color, double length, double width) : base(color)
    {
        Length = length;
        Width = width;
    }

    public double Length
    {
        get { return _length; }
        set { _length = value; }
    }
    public double Width
    {
        get { return _width; }
        set { _width = value; }
    }

    public override double GetArea()
    {
        return Length*Width;
    }
}