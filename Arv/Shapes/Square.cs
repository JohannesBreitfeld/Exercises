namespace Arv.Shapes;
internal class Square : Shape
{
    public Square(double side)
    {
        GeometricDimension = side;
    }
    public Square(double side, ConsoleColor color) : this(side)
    {
        this.color = color;
    }
    public override double Area => GeometricDimension * GeometricDimension;
    public override double Circumference => GeometricDimension * 4;

    public override string ToString()
    {
        return $"A square with side {GeometricDimension}";
    }
}