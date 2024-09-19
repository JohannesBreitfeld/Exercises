class Car2
{
    public ConsoleColor Color { get; init; }
    public int Length { get; init; }
    public int Speed { get; init; }
    public int Distance { get; set; }
    public string Name { get; set; }

    public Car2()
    {
        Random rand = new();
        Color = (ConsoleColor)rand.Next(0, 16);
        Length = rand.Next(3, 6);
        Speed = rand.Next(60, 241);
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
    public void DriveForOneHour()
    {
        Distance += Speed;
    }
    public void GetGraph()
    {
        int position = Distance / 500;
        Console.ForegroundColor = ConsoleColor.Gray;
        for (int i = 0; i <= 21; i++)
        {
            if (i == 0 || i == 21) 
            {
                Console.Write('|'); 
            }
            if (i == position)
            {
                Console.ForegroundColor = this.Color;
                Console.Write('X');
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else if (i != 21)
            {
                Console.Write('-'); 
            }
        }
    }
}