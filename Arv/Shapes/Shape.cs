using System.Runtime.CompilerServices;

namespace Arv.Shapes;
public abstract class Shape
{
    protected ConsoleColor color;
    protected double GeometricDimension;
    public abstract double Area { get; }
    public abstract double Circumference { get; }
    public void Print()
    {
        if (this is Circle circle)
        {
            Console.WriteLine($"A circle with radius {circle.GeometricDimension:f2} has an area of {circle.Area:f2} and a circumference of {circle.Circumference:f2}");
        }
        else if (this is Square square)
        {
            Console.WriteLine($"A square with side {square.GeometricDimension:f2} has an area of {square.Area:f2} and a circumference of {square.Circumference:f2}");
        }
    }
    //public static void PrintAll(Shape[] shapes)
    //{
    //    for (int i = 0; i < shapes.Length; i++)
    //    {
    //        if (shapes[i] is Circle)
    //        {
    //            Console.ForegroundColor = ConsoleColor.Red;
    //            shapes[i].Print();
    //        }
    //        else if (shapes[i] is Square)
    //        {
    //            Console.ForegroundColor = ConsoleColor.Green;
    //            shapes[i].Print();
    //        }
    //    }
    //    Console.ForegroundColor = ConsoleColor.Gray;
    //}
    public static void PrintAll(Shape[] shapes)
    {
        for (int i = 0; i < shapes.Length; i++)
        {
        
                Console.ForegroundColor = shapes[i].color;
                shapes[i].Print();
        }
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    public static void PrintCircles(Shape[] shapes)
    {
        for (int i = 0; i < shapes.Length; i++)
        {
            if (shapes[i] is Circle)
            {
                shapes[i].Print();
            }
        }
    }
}
