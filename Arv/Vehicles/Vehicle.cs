using Arv.Extensions;
using Arv.Enums;

namespace Arv.Vehicles;
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
        this.Size = new Size(rand.Double(4, 6), rand.Double(1.8, 2.2), rand.Double(1.5, 1.9));
    }
    public override string ToString()
    {
        return $"A {this.Color} {this.Brand}";
    }
}
