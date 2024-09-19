class Car2
{
    public ConsoleColor Color { get; init; }
    public int Length { get; init; }

    public Car2()
    {
        Random rand = new();
        Color = (ConsoleColor)rand.Next(0, 16);
        Length = rand.Next(3, 6);
    }
    private Car2(ConsoleColor color)
    {
        Random rand = new();
        Color = color;
        Length = rand.Next(3, 6);
    }

    public static Car2[] GetTenCarsSameColor(Car2 car)
    {
        Car2[] carArray = new Car2[10];
        for (int i = 0; i < carArray.Length; i++)
        {
            carArray[i] = new Car2(car.Color);
        }
        return carArray;
    }
}