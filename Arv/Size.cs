public struct Size
{
    public double Length { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }
    public Size(double length, double width, double height)
    {
        Length = length;
        Width = width;
        Height = height;
    }
}