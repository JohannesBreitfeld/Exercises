//e1(); //1. En bokstav på varje rad.
//e2(); //2. Siffror till text.
//e3(); //3. Baklänges.
//e4(); //4. Dölj vokaler
//e5(); //5. Palindrom
//e6(); //6. Miniräknare
//e7(); //7. Omvänd ordning
//e8(); //8. Fördröjd utskrift
//e9(); //9. Bokstavspyramid
//e10(); //10. Färgade bokstäver
//e11(); //11. Start och stop
//e12(); //12. Växla färg
static void e1()
{
    Console.WriteLine("Skriv in något:");
    var userInput = Console.ReadLine();

    for (int i = 0; i < userInput.Length; i++)
    {
        Console.WriteLine(userInput[i]);
    }

}
static void e2()
{
    string[] tal = new string[] { "noll", "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio" };
    Console.WriteLine("Skriv in ett numeriskt tal mellan 0 och 9:");
    var input = int.Parse(Console.ReadLine());
    Console.WriteLine(tal[input]);
}
static void e3()
{
    Console.WriteLine("Skriv in meningen du vill ha baklänges:");
    var input = Console.ReadLine();

    for (int i = input.Length - 1; i >= 0; i--)
    {
        Console.Write(input[i]);
    }
}
static void e4()
{
    Console.WriteLine("Skriv in en mening:");
    var input = Console.ReadLine();
    var vokaler = new char[] { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö' };

    for (int i = 0; i < input.Length; i++)
    {
        if (vokaler.Contains(input[i]))
        {
            Console.Write('*');
        }
        else
        {
            Console.Write(input[i]);
        }
    }
}
static void e5()
{
    Console.WriteLine("Skriv in ett ord:");
    string input = Console.ReadLine();
    string inputNoWhitespace = input.Replace(" ", "");

    if (inputNoWhitespace.SequenceEqual(inputNoWhitespace.Reverse()))
    {
        Console.WriteLine($"{input} är en palindrom");
    }
    else
    {
        Console.WriteLine($"{input} är inte en palindrom");
    }
}
static void e6()
{
    Console.WriteLine("Vad vill du räkna ut?");
    string input = Console.ReadLine();

    if (input.Contains("+"))
    {
        var numbers = input.Split("+");
        var result = double.Parse(numbers[0]) + double.Parse(numbers[1]);
        Console.WriteLine($"{numbers[0]} + {numbers[1]} = {result}");
    }
    else if (input.Contains("-"))
    {
        var numbers = input.Split("-");
        var result = double.Parse(numbers[0]) - double.Parse(numbers[1]);
        Console.WriteLine($"{numbers[0]} - {numbers[1]} = {result}");
    }
    else if (input.Contains("*"))
    {
        var numbers = input.Split("*");
        var result = double.Parse(numbers[0]) * double.Parse(numbers[1]);
        Console.WriteLine($"{numbers[0]} * {numbers[1]} = {result}");
    }
    else if (input.Contains("/"))
    {
        var numbers = input.Split("/");
        var result = double.Parse(numbers[0]) / double.Parse(numbers[1]);
        Console.WriteLine($"{numbers[0]} / {numbers[1]} = {result}");
    }
    else
    {
        Console.WriteLine("Felaktig input");
        e6();
    }
}
static void e7()
{
    string[] words = new string[7];
    string[] numbers = new string[] { "första", "andra", "tredje", "fjärde", "femte", "sjätte", "sjunde" };
    int counter = 0;

    while (counter < 7)
    {
        Console.WriteLine($"Skriv in {numbers[counter]} ordet:");
        words[counter] = Console.ReadLine();
        counter++;
    }
    for (int i = 6; i >= 0; i--)
    {
        Console.WriteLine(words[i]);
    }
}
static void e8()
{

    List<string> words = new List<string>();
    while (true)
    {
        Console.WriteLine("Skriv ett ord, eller Q för att avsluta:");
        string input = Console.ReadLine();
        words.Add(input);

        if (input == "q" || input == "Q") break;

        if (words.Count < 10)
        {
            Console.WriteLine("Du har inte skrivit tio ord ännu!");
        }
        else
        {
            Console.WriteLine(words[words.Count - 10]);
        }
        Console.WriteLine();
    }
}
static void e9()
{
    string helloWorld = "Hello World";

    for (int i = 0; i <= helloWorld.Length; i++)
    {
        Console.WriteLine(helloWorld[0..i]);
    }
}
static void e10()
{
    Console.WriteLine("Skriv en mening:");
    var inputString = Console.ReadLine();
    Console.WriteLine("Välj vilken bokstav som ska rödmarkeras:");
    var coloredVariable = Console.ReadLine()[0];

    foreach (var variable in inputString)
    {
        Console.ForegroundColor = (char.ToLower(variable) == char.ToLower(coloredVariable)
            ? ConsoleColor.Red
            : ConsoleColor.Gray);

        Console.Write(variable);
    }
}
static void e11()
{
    Console.WriteLine("Mata in en text:");
    var text = Console.ReadLine();
    Console.WriteLine("Välj startindex");
    var startIndex = int.Parse(Console.ReadLine());
    Console.WriteLine("Välj stoptindex");
    var stopIndex = int.Parse(Console.ReadLine());

    if (startIndex < 0 || startIndex > text.Length - 1 || stopIndex < 0 || stopIndex > text.Length - 1)
    {
        Console.WriteLine("Fel, fel, fel!");
    }
    else
    {
        for (int i = 0; i < text.Length; i++)
        {
            if (i >= startIndex && i <= stopIndex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.Write(text[i]);
        }
    }
}
static void e12()
{
    bool colored = false;
    Console.WriteLine("Mata in text:");
    var text = Console.ReadLine();
    Console.WriteLine("Välj en bokstav");
    char bokstav = Console.ReadLine()[0];

    for (int i = 0; i < text.Length - 1; i++)
    {
        if (text[i] == bokstav)
        {
            if (!colored)
            {
                colored = true;
            }
            else
            {
                colored = false;
            }
        }
        if (colored)
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        Console.Write(text[i]);
    }
    Console.ForegroundColor = ConsoleColor.Gray;
}