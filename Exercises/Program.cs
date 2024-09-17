using BasicOOP;
//E1
Console.WriteLine("E1. Skriva ut namn på personer:");
Person Person1 = new Person() { firstName = "Albert", lastName = "Ask" };
Person Person2 = new Person() { firstName = "Bilbert", lastName = "Bask" };
Console.WriteLine($"{Person1.firstName} {Person1.lastName}");
Console.WriteLine($"{Person2.firstName} {Person2.lastName}");
Console.WriteLine();
Console.WriteLine("*****************************************");
//E2
Console.WriteLine("E2. Lägg till en metod som returnerar hela namnet:");
Console.WriteLine(Person1.GetFullName());
Console.WriteLine(Person2.GetFullName());
Console.WriteLine();
Console.WriteLine("*****************************************");
//E3
Console.WriteLine("E3. Lägg till en metod som returnerar namnet baklänges:");
Console.WriteLine(Person1.GetFullNameReversed());
Console.WriteLine(Person2.GetFullNameReversed());
Console.WriteLine();
Console.WriteLine("*****************************************");
//E4
Console.WriteLine("E.4 Overload av GetFullName med titel:");
Console.WriteLine(Person1.GetFullName("Dr"));
Console.WriteLine(Person2.GetFullName("Mrs"));
Console.WriteLine();
Console.WriteLine("*****************************************");
//E5 + E6
Console.WriteLine("E5. Lägg till så personer kan ha föräldrar:");
Console.WriteLine("E6. Skapa ett objekt som representerar dig och dina föräldrar:");
Person mySelf = new Person { firstName = "Greta", lastName = "Gris" };
Person father = new Person() { firstName = "Pappa", lastName = "Gris" };
Person mother = new Person() { firstName = "Mamma", lastName = "Gris" };
mySelf.mother = mother;
mySelf.father = father;
Console.WriteLine(mySelf.GetFullName());
Console.WriteLine(mySelf.mother.GetFullName());
Console.WriteLine(mySelf.father.GetFullName());
Console.WriteLine();
Console.WriteLine("*******************************************");
//E7
Console.WriteLine("E7. Hämta information om dig och dina föräldrar:");
mySelf.father = null;
Console.WriteLine(mySelf.GetSelfAndParents());
Console.WriteLine();
Console.WriteLine("**************************************************");
//E8
Console.WriteLine("E8. Privat fält, med metoder för att sätta värdet:");
mySelf.SetLength(1.82);
Console.WriteLine(mySelf.GetLength());
Console.WriteLine();
Console.WriteLine("************************************************");
//E9
Console.WriteLine("E9. Vikt och BMI:");
mySelf.SetWeight(90);
Console.WriteLine(mySelf.GetWeight());
Console.WriteLine(mySelf.GetBMI());
