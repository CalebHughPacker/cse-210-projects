using System;

public class Fraction
{
    private int _upper;
    private int _lower;

    public Fraction() 
    {
        _upper = 1;
        _lower = 1;
    }

    public Fraction(int top)
    {
        _upper = top;
        _lower = 1;
    }

    public Fraction(int top, int bottom)
    {
        _upper = top;
        _lower = bottom;
    }

    public int Upper
    {
        get { return _upper; }
        set { _upper = value; }
    }

    public int Lower
    {
        get { return _lower; }
        set { _lower = value; }
    }

    public string GetFractionString()
    {
        return $"{_upper}/{_lower} ";
    }

    public double GetDecimalValue()
    {
        return (double)_upper/_lower;
    }
}