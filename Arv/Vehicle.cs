using Enums;
internal class Vehicle
{
    public Brand Brand { get; set; }
    public Color Color { get; set; }
    public Size Size { get; set; }
    public Vehicle(Brand brand, Color color) : this(brand)
    {
        this.Color = color;
    }
    public Vehicle(Brand brand)
    {
        Random rand = new Random();
        
        this.Brand = brand;
        this.Color = Color.Black;
        this.Size = new Size(
            4 + rand.NextDouble() * (6 - 4),
            1.8 + rand.NextDouble() * (2.2 - 1.8),
            1.5 + rand.NextDouble() * (1.9 - 1.5));
    }
    public override string ToString()
    {
        return $"A {this.Color} {this.Brand}";
    }
}
