using System;
using System.Drawing;

public abstract class Shape
{
    private string _color;

    public Shape(string color)
    {
        Color = color;
    }

    public string Color
    {
        get { return _color; }
        set { _color = value; }
    }

    public abstract double GetArea();

    public string GetColor()
    {
        return Color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }

}