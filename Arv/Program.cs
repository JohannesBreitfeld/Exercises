using Arv.Enums;
using Arv.Vehicles;
using Arv.Shapes;

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
//6. Cricle som ärver från Shape
var circle = new Circle(5);
Console.WriteLine(circle);
Console.WriteLine($"Area: {circle.Area:f2}");
Console.WriteLine($"Circumference: {circle.Circumference:f2}");

Console.WriteLine();
Console.WriteLine("**********************************************************");

//7. Square ärver också från Shape
var square = new Square(5);
Console.WriteLine(square);
Console.WriteLine($"Area: {square.Area:f2}");
Console.WriteLine($"Circumference: {square.Circumference:f2}");

//8. Lägg till Print() i Shape
var square2 = new Square(3.2);
square2.Print();

var circle2 = new Circle(4.5);
circle2.Print();
Console.WriteLine();
Console.WriteLine("**********************************************");
//9. En array av cirklar och kvadrater
Shape[] shapes = new Shape[10];
Random rand = new Random();

//for (int i = 0; i < shapes.Length; i++)
//{
//    shapes[i] = (rand.Next(1, 3) == 2) ? new Circle(rand.Next(1, 10)) : new Square(rand.Next(1, 10));
//}
//Console.WriteLine();
//Console.WriteLine("***************************************************");

//10. Statiska printmetoder
//Shape.PrintAll(shapes);
//Console.WriteLine();
//Shape.PrintCircles(shapes);

//11. Lägg till färger i PrintAll()
//12. Random färger
for (int i = 0; i < shapes.Length; i++)
{
    shapes[i] = (rand.Next(1, 3) == 2) ? new Circle(rand.Next(1, 10), (ConsoleColor)rand.Next(1,16)) : new Square(rand.Next(1, 10), (ConsoleColor)rand.Next(1, 16));
}

Shape.PrintAll(shapes);