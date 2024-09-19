//E1
Console.WriteLine("1. Person med property FirstName.");
Person myPerson = new Person();
myPerson.FirstName = "Peppa";
Console.WriteLine(myPerson.FirstName);
Console.WriteLine();
Console.WriteLine("*************************************");

//E2
Console.WriteLine("2. Autoproperty LastName");
myPerson.LastName = "Pig";
Console.WriteLine(myPerson.LastName);
Console.WriteLine();
Console.WriteLine("*************************************");

//E3
Console.WriteLine("3. Read-only property FullName");
Console.WriteLine(myPerson.FullName);
Console.WriteLine();
Console.WriteLine("***************************************");

//E4
Console.WriteLine("4. Stegräknare");
StepCounter myStepCounter = new();
Console.WriteLine(myStepCounter.Steps);
for (int i = 0; i < 1000; i++)
{
    myStepCounter.Step();
}
Console.WriteLine(myStepCounter.Steps);
myStepCounter.Reset();
Console.WriteLine(myStepCounter.Steps);

//E5
Console.WriteLine("5. Bil");
Car myCar1 = new Car("Nissan Navara", 1000000, "Black");
Car myCar2 = new();
myCar2.Model = "Toyota Hilux";
myCar2.Price = 200000;
myCar2.Color = "Army green";
myCar2.HalfPrice();
Console.WriteLine($"myCar1.Model = {myCar1.Model}");
Console.WriteLine($"myCar1.Price = {myCar1.Price}");
Console.WriteLine($"myCar1.Color = {myCar1.Color}");
Console.WriteLine($"myCar2.Model = {myCar2.Model}");
Console.WriteLine($"myCar2.Price = {myCar2.Price}");
Console.WriteLine($"myCar2.Color = {myCar2.Color}");
Console.WriteLine();
Console.WriteLine("*******************************");

//E6
Console.WriteLine("6. Vattenglas");
WaterGlass Glass = new();
Glass.EmptyGlass();
Glass.FillGlass();
Glass.BreakGlass();
Glass.FillGlass();
Console.WriteLine();
Console.WriteLine("**********************************");

//E7
Console.WriteLine("Röd & Blå");
RedAndBlue RedBlue = new();
Console.WriteLine($"Red = {RedBlue.Red} Blue = {RedBlue.Blue}");
RedBlue.Red = 31.7;
Console.WriteLine($"Red = {RedBlue.Red} Blue = {RedBlue.Blue}");
RedBlue.Blue = 110;
Console.WriteLine($"Red = {RedBlue.Red} Blue = {RedBlue.Blue}");
RedBlue.Blue = -12;
Console.WriteLine($"Red = {RedBlue.Red} Blue = {RedBlue.Blue}");
RedBlue.Blue = 50;
Console.WriteLine($"Red = {RedBlue.Red} Blue = {RedBlue.Blue}");
Console.WriteLine();
Console.WriteLine("***************************************");

//E8
Console.WriteLine("8. Bil 2");
Car2[] myCarArray = new Car2[1000];

for (int i = 0; i < myCarArray.Length; i++)
{
	myCarArray[i] = new Car2();
}

Console.WriteLine(GetTotalLengthOfGreenCars(myCarArray));
static int GetTotalLengthOfGreenCars(Car2[] cars)
{
	int totalLength = 0;
	foreach (var car in cars)
	{
		if (car.Color == ConsoleColor.Green)
		{
			totalLength += car.Length;
		}
	}
	return totalLength;
}

Console.WriteLine();
Console.WriteLine("************************************");

//E9
Console.WriteLine("9. Lägg till en statisk metod");
Car2 myCar = new();
Console.WriteLine($"Color: {myCar.Color} Length: {myCar.Length}");

Car2[] carArray = Car2.GetTenCarsSameColor(myCar);
foreach (var car in carArray)
{
    Console.WriteLine($"Color: {car.Color} - Length: {car.Length}");
}

//10;
Car2App App = new();
App.Run();