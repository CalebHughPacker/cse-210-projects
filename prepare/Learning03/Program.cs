using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fractionA = new();
        Console.WriteLine(fractionA.GetFractionString());
        Console.WriteLine(fractionA.GetDecimalValue());

        Fraction fractionB = new(5);
        Console.WriteLine(fractionB.GetFractionString());
        Console.WriteLine(fractionB.GetDecimalValue());

        Fraction fractionC = new(3, 4);
        Console.WriteLine(fractionC.GetFractionString());
        Console.WriteLine(fractionC.GetDecimalValue());

        Fraction fractionD = new(1, 3);
        Console.WriteLine(fractionD.GetFractionString());
        Console.WriteLine(fractionD.GetDecimalValue());
    }
}