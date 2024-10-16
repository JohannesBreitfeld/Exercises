//1. Anonyma datatyper
var people = new[] {
    new { LastName = "Eriksson",  FirstName = "Anders", Age = 39, Height = 1.84, Weight = 90 },
    new { LastName = "Palm", FirstName = "Lisa",  Age = 40, Height = 1.62, Weight = 45},
    new { LastName = "Andersson",  FirstName = "Per",  Age = 31, Height = 1.92, Weight = 104},
    new { LastName = "Lundberg",  FirstName = "Anna",  Age = 66, Height = 1.72, Weight = 60 },
    new { LastName = "Eriksson",  FirstName = "Camilla",  Age = 65, Height = 1.65, Weight = 75},
    new { LastName = "Andersson",  FirstName = "Lars",  Age = 12, Height = 1.65, Weight = 55},
    new { LastName = "Spjut",  FirstName = "Jessica",  Age = 39, Height = 1.75, Weight = 62},
    new { LastName = "Klasson",  FirstName = "Jörgen",  Age = 83, Height = 1.70, Weight = 75},
    new { LastName = "Svensson",  FirstName = "Sven",  Age = 23, Height = 1.87, Weight = 75},
    new { LastName = "Svensson",  FirstName = "Anna",  Age = 53, Height = 1.55, Weight = 43},
    new { LastName = "Svensson",  FirstName = "Berit",  Age = 83, Height = 1.67, Weight = 75},
    new { LastName = "Svensson",  FirstName = "Carl",  Age = 41, Height = 1.88, Weight = 77},
    new { LastName = "Svensson",  FirstName = "Daniel",  Age = 19, Height = 1.80, Weight = 74},
};

//2. Filtrera på ålder
var peopleBetween20And40 = people
    .Where(p => p.Age >= 20 && p.Age <= 40)
    .ToList();

var query2 = (from p in people where p.Age >= 20 && p.Age <= 40 select p).ToList();

//query2.ForEach(p => Console.WriteLine($"{p.FirstName} {p.LastName} - {p.Age} år"));


//3. Är någon av personerna mellan 20 och 40 över 190cm lång.
var method3 = peopleBetween20And40.Any(p => p.Height > 1.90);

var query3 = (from p in query2 where p.Height > 1.9 select p).Any();


//4. Filtrera på namn
var peopleLongerFirstname = people
    .Where(p => p.FirstName.Length > p.LastName.Length)
    .Select(p => new { FirstName = p.FirstName, LastName = p.LastName })
    .ToList();

var query4 = (from p in people
              where p.FirstName.Length > p.LastName.Length
              select new { Firstname = p.FirstName, Lastname = p.LastName })
              .ToList();

//query4.ForEach(p => Console.WriteLine($"{p.Firstname} {p.Lastname}"));

//5. Hela namnet tillsammans med BMI
var peopleBMI = people
    .Select(p => new { Name = $"{p.FirstName} {p.LastName}", BMI = p.Weight / Math.Pow(p.Height, 2) })
    .ToList();

var query5 = (from p in people
              select new { Name = $"{p.FirstName} {p.LastName}", BMI = p.Weight / Math.Pow(p.Height, 2) })
              .ToList();

//query5.ForEach(p => Console.WriteLine($"{p.Name}, BMI: {p.BMI:f2}"));

//6. Filtrera på BMI
var peopleBMI20to25 = peopleBMI.Where(p => p.BMI < 20 || p.BMI > 25).ToList();

var query6 = from p in peopleBMI
             where p.BMI < 20 || p.BMI > 25
             select p;

//.ForEach(p => Console.WriteLine($"{p.Name}, Bmi: {p.BMI:f2}"));

//7. Filtrera originallistan på BMI
var firstListToBMI = people
    .Where(p => (p.Weight / Math.Pow(p.Height, 2)) < 20 || (p.Weight / Math.Pow(p.Height, 2)) > 25)
    .ToList();

var query7 = from p in people
             where (p.Weight / Math.Pow(p.Height, 2)) < 20 || (p.Weight / Math.Pow(p.Height, 2)) > 25
             select p;

//firstListToBMI.ForEach(p => Console.WriteLine($"{p.FirstName} {p.LastName}")); 

//8. Username tillsammans med category
var usernameCategory = people
    .Select(p => new { Username = $"{p.FirstName}{p.Age}", Category = (p.Age < 18) ? "Child" : "Adult" })
    .ToList();

var query8 = (from p in people
              select new { Username = $"{p.FirstName}{p.Age}", Category = (p.Age < 18) ? "Child" : "Adult" })
              .ToList();

//query8.ForEach(p => Console.WriteLine($"Username: {p.Username}".PadRight(30)  + $"Category {p.Category}"));

//10. Sortera efter längd
var peopleByHeight = people.OrderBy(p => p.Height);

//foreach (var p in peopleByHeight)
//{
//    Console.WriteLine($"{p.FirstName} {p.LastName} Längd: {p.Height:f2}");
//}

//11. Sortera äldst till yngst
var peopleByAge = people.OrderByDescending(p => p.Age);

//foreach (var p in peopleByAge)
//{
//    Console.WriteLine($"{p.FirstName} {p.LastName} Ålder: {p.Age} år");
//}

//12. Sortera i första och andra hand
var orderPeople = people.OrderBy(p => p.LastName).ThenByDescending(p => p.FirstName);

//foreach (var p in orderPeople)
//{
//    Console.WriteLine($"{p.FirstName} {p.LastName} - {p.Age} år");
//}

//13. LINQ vs PLINQ
long sum = Enumerable.Range(1, 1000_000_000)
    .Where(n => n % 3 == 00 || n % 5 == 0)
    .Aggregate((x, y) => x+y);
Console.WriteLine(sum); //13000ms vs 2233ms