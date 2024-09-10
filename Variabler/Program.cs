//e1(); //1. Hälsa på användaren
//e2(); //2. Multiplicer två tal
//e3(); //3. Verfifiera lösenord
//e4(); //4. Jämför tal
//e5(); //5. Dubblera och halvera tal
//e6(); //6. Miniräknare
//e7(); //7. Summa och medelvärde

static void e1()
{
    Console.WriteLine("Skriv ditt namn:");
    var name = Console.ReadLine();
    Console.WriteLine($"Hej {name}!");
}
static void e2()
{
    int tal1Parsed;
    int tal2Parsed;
    bool parsed;

    do
    {
        Console.WriteLine("skriv in det första talet:");
        var tal1 = Console.ReadLine();
        parsed = int.TryParse(tal1, out tal1Parsed);

    } while (!parsed);
    do
    {
        Console.WriteLine("skriv in det andra talet:");
        var tal2 = Console.ReadLine();
        parsed = int.TryParse(tal2, out tal2Parsed);

    } while (!parsed);

    Console.WriteLine($"{tal1Parsed} * {tal2Parsed} = {tal1Parsed * tal2Parsed}");
}
static void e3()
{
    var password = "ABC123";
    Console.WriteLine("Skriv in lösenordet:");
    var userinput = Console.ReadLine();
    var resultat = userinput != password ? "Fel lösenord" : "Rätt lösenord";
    Console.WriteLine(resultat);
}
static void e4()
{
    bool parsed;
    int talParsed;
    do
    {
        Console.WriteLine("Skriv in ett tal:");
        var tal = Console.ReadLine();
        parsed = int.TryParse(tal, out talParsed);
    } while (!parsed);

    if (talParsed < 100) Console.WriteLine("Talet är mindre än 100");
    else if (talParsed > 100) Console.WriteLine("Talet är över 100");
    else Console.WriteLine("Talet är lika med 100");
}
static void e5()
{
    Console.WriteLine("Skriv in ett tal:");
    var tal = Console.ReadLine();
    var talParsed = double.Parse(tal);

    Console.WriteLine($"{talParsed * 2} är dubbelt så mycket som {talParsed}");
    Console.WriteLine($"{talParsed / 2} är hälften av {talParsed}");
}
static void e6()
{
    Console.WriteLine("Första talet:");
    var tal1 = Console.ReadLine();
    var tal1Parsed = int.Parse(tal1);

    Console.WriteLine("Välj +, -, *, /");
    var operand = Console.ReadLine();

    Console.WriteLine("Andra talet:");
    var tal2 = Console.ReadLine();
    var tal2Parsed = int.Parse(tal2);

    switch (operand)
    {
        case "+":
            Console.WriteLine($"{tal1}{operand}{tal2} = {tal1Parsed + tal2Parsed}");
            break;
        case "-":
            Console.WriteLine($"{tal1}{operand}{tal2} = {tal1Parsed - tal2Parsed}");
            break;
        case "*":
            Console.WriteLine($"{tal1}{operand}{tal2} = {tal1Parsed * tal2Parsed}");
            break;
        case "/":
            Console.WriteLine($"{tal1}{operand}{tal2} = {tal1Parsed / tal2Parsed}");
            break;
        default:
            Console.WriteLine("Något gick snett");
            break;
    }
}
static void e7()
{
    double resultat = 0;
    bool parsed = false;
    var antalTal = 0;
    do
    {
        Console.WriteLine("Skriv in ett tal:");
        var tal = Console.ReadLine();
        parsed = double.TryParse(tal, out double talParsed);

        if (parsed)
        {
            antalTal++;
            resultat += talParsed;
            Console.WriteLine(resultat);
        }

    } while (parsed);

    Console.WriteLine($"Medlvärdet av talen är {resultat / antalTal}");
}