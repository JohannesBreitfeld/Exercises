using Enums;

//1. Skapa en klass för fordon
Vehicle myVehicle = new Vehicle(Brand.Ford);
Vehicle myVehicle2 = new Vehicle(Brand.Dodge, Color.Green);

Console.WriteLine($"myVehicle brand: {myVehicle.Brand} myVehicle color: {myVehicle.Color}");
Console.WriteLine($"myVehicle2 brand: {myVehicle2.Brand} myVehicle2 color: {myVehicle2.Color}");

Console.WriteLine();
Console.WriteLine("******************************************************");

//2. Lägg till override för ToString()
Console.WriteLine(myVehicle);

Console.WriteLine();
Console.WriteLine("********************************************************");

//3. Skapa en subklass för bilar
Car myCar = new Car(Brand.Nissan, "Navara", Color.Black);
Console.WriteLine(myCar);

Console.WriteLine();
Console.WriteLine("********************************************************");

//4. Skapa en struct för att spara längd, bredd och höjd
//5. Initiera i Vehicle, Skriv ut i Car
