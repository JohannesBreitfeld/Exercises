namespace Arv.Shapes;
internal class Circle : Shape
{
    public Circle(double radius)
    {
        GeometricDimension = radius;
    }
    public Circle(double radius, ConsoleColor color) : this(radius)
    {
        this.color = color;
    }
    public override double Area => Math.PI * Math.Pow(GeometricDimension, 2);
    public override double Circumference => Math.PI * (GeometricDimension * 2);

    public override string ToString()
    {
        return $"A circle with radius {GeometricDimension}";
    }
}