using Arv.Enums;

namespace Arv.Vehicles;

internal class Car : Vehicle
{
    public string Model { get; set; }

    public Car(Brand brand, string model, Color color) : base(brand, color)
    {
        Model = model;
    }
    public override string ToString()
    {
        return $"A {this.Color} {this.Size.Length:0.##} meter long {this.Model} from {this.Brand}";
    }
}



