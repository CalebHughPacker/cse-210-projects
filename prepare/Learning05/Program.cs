using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("Blue", 4));
        shapes.Add(new Rectangle("Red", 4, 3));
        shapes.Add(new Circle ("Green", 1));

        foreach (Shape shape in shapes)
        {
            Console.Write("Color: ");
            Console.WriteLine(shape.GetColor());
            Console.Write("Area: ");
            Console.WriteLine(shape.GetArea());
        }
    }
}