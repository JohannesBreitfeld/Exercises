class Car2App
{
    const int MaxDistance = 10000;
    private Car2[] carArray = new Car2[10];

    public void Run()
    {
        for (int i = 0; i < carArray.Length; i++)
        {
            carArray[i] = new Car2 { Name = $"Car {i+1}" };
        }
        while (true)
        {
            Console.Clear();
            foreach (var car in carArray)
            {
                car.DriveForOneHour();
                Console.Write($"{car.Name}: ".PadRight(8));
                car.GetGraph();
                Console.Write($"{car.Distance} km".PadLeft(8));
                Console.WriteLine();
                if (car.Distance >= MaxDistance)
                {
                    Console.WriteLine($"{car.Name} has reached the goal!");
                    return;
                }
            }
            Thread.Sleep(1000);

        }
    }
}

