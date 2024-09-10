//e1(); //1. Skriv talen 20 till 30
//e2(); //2. Jämna tal
//e3(); //3. Var tredje "Hej"
//e4(); //4. Gångertabell
//e5(); //5. Summa
//e6(); //6. Riskorn på schackbräde
//e7(); //7. Fylld box
//e8(); //8. Randig box
//e9(); //9. Rutig box
//e10(); //10. Ihålig box
//e11(); //11. Siffer pyramid
//e12(); //12. Nio Sifferpyramider
//e13(); //13. Primtal
//e14(); //14. Spel - Gissa tal
//e15(); //15. Sten, Sax eller påse

static void e1()
{
    for (int i = 20; i <= 30; i++)
    {
        Console.WriteLine(i);
    }
}
static void e2()
{
    for (int i = 0; i <= 30; i += 2)
    {
        Console.WriteLine(i);
    }
}
static void e3()
{
    for (int i = 0; i <= 30; i++)
    {
        if (i % 3 == 0)
        {
            Console.WriteLine("Hej!");
        }
        else Console.WriteLine(i);
    }
}
static void e4()
{
    Console.WriteLine("Skriv in ett tal:");
    var tal = Console.ReadLine();
    var parsed = int.TryParse(tal, out int talParsed);

    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{i}*{talParsed} = {i * talParsed}");
    }
}
static void e5()
{
    int summa = 0;
    for (int i = 1; i <= 1000; i++)
    {
        summa += i;
    }
    Console.WriteLine(summa);
}
static void e6()
{
    ulong riskorn = 1;
    for (int i = 1; i <= 64; i++)
    {
        riskorn *= 2;
        Console.WriteLine($"Ruta {i}: {riskorn}");
    }
}
static void e7()
{
    Console.WriteLine("Skriv in höjd:");
    var height = Console.ReadLine();
    var heightParsed = int.Parse(height);
    Console.WriteLine("Skriv in bredd:");
    var width = Console.ReadLine();
    var widthParsed = int.Parse(width);

    for (int i = 1; i <= heightParsed; i++)
    {
        for (int j = 1; j <= widthParsed; j++)
        {
            Console.Write("X");
        }
        Console.WriteLine();
    }
}
static void e8()
{
    Console.WriteLine("Skriv in höjd:");
    var height = Console.ReadLine();
    var heightParsed = int.Parse(height);
    Console.WriteLine("Skriv in bredd:");
    var width = Console.ReadLine();
    var widthParsed = int.Parse(width);

    for (int i = 1; i <= heightParsed; i++)
    {
        for (int j = 1; j <= widthParsed; j++)
        {
            if (j % 2 == 0) Console.Write("X");
            else Console.Write("O");
        }
        Console.WriteLine();
    }
}
static void e9()
{
    Console.WriteLine("Skriv in höjd:");
    var height = Console.ReadLine();
    var heightParsed = int.Parse(height);
    Console.WriteLine("Skriv in bredd:");
    var width = Console.ReadLine();
    var widthParsed = int.Parse(width);

    for (int i = 1; i <= heightParsed; i++)
    {
        for (int j = 1; j <= widthParsed; j++)
        {
            if (i % 2 == 0)
            {
                if (j % 2 == 0) Console.Write("X");
                else Console.Write("O");
            }
            else
            {
                if (j % 2 != 0) Console.Write("X");
                else Console.Write("O");
            }
        }
        Console.WriteLine();
    }
}
static void e10()
{
    Console.WriteLine("Skriv in höjd:");
    var height = Console.ReadLine();
    var heightParsed = int.Parse(height);
    Console.WriteLine("Skriv in bredd:");
    var width = Console.ReadLine();
    var widthParsed = int.Parse(width);

    for (int i = 1; i <= heightParsed; i++)
    {
        for (int j = 1; j <= widthParsed; j++)
        {
            if (i == 1 || i == heightParsed)
            {
                Console.Write("X");
            }
            else
            {
                if (j == 1 || j == widthParsed)
                    Console.Write("X");
                else
                {
                    Console.Write(" ");
                }
            }
        }
        Console.WriteLine();
    }
}
static void e11()
{
    for (int i = 1; i < 10; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write(j);
        }
        Console.WriteLine();
    }
}
static void e12()
{
    for (int i = 1; i < 10; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            for (int k = 1; k <= j; k++)
            {
                Console.Write(k);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
static void e13()
{
    var counter = 0;
    for (int i = 1; i < 99999999; i++)
    {
        var primtal = true;

        for (int j = 2; j <= i / 2; j++)
        {
            if (i % j == 0)
            {
                primtal = false;
                break;
            }
        }
        if (primtal == true && i != 1)
        {
            Console.Write(i + " ");
            counter++;
        }
        if (counter == 20) break;
    }
}
static void e14()
{
    var correctanswer = false;
    var numberOfGuesses = 0;
    Random random = new Random();
    var secretNumber = random.Next(1, 101);

    while (!correctanswer)
    {
        bool parsedCorrectly = false;
        int guessParsed;
        do
        {
            Console.WriteLine("Gissa på ett tall mellan 1 och 100");
            var guess = Console.ReadLine();
            parsedCorrectly = int.TryParse(guess, out guessParsed);
        } while (!parsedCorrectly);
        if (guessParsed < secretNumber)
        {
            Console.WriteLine("Du har gissat för lågt. Gissa igen!");
            numberOfGuesses++;
        }
        else if (guessParsed > secretNumber)
        {
            Console.WriteLine("Du har gissat för högt. Gissa igen!");
            numberOfGuesses++;
        }
        else
        {
            Console.WriteLine($"Du har gissat rätt! Du behövde {numberOfGuesses} försök.");
            correctanswer = true;
        }
    }
}
static void e15()
{
    int userScore = 0;
    int computerScore = 0;

    while (true)
    {
        Console.WriteLine("Väljer du sten, sax eller påse?");
        var input = Console.ReadLine();

        if (input == "")
        {
            break;
        }

        var userChoice = input.ToLower();

        Random rand = new Random();
        var computerChoice = rand.Next(1, 4);

        if (computerChoice == 1)
        {
            if (userChoice == "sten")
            {
                Console.WriteLine("Datorn väljer sten.");
                Console.WriteLine("Det blir oavgjort.");
            }
            else if (userChoice == "påse")
            {
                Console.WriteLine("Datorn väljer påse.");
                Console.WriteLine("Det blir oavgjort.");

            }
            else if (userChoice == "sax")
            {
                Console.WriteLine("Datorn väljer sax.");
                Console.WriteLine("Det blir oavgjort.");
            }
        }
        else if (computerChoice == 2)
        {
            if (userChoice == "sten")
            {
                Console.WriteLine("Datorn väljer påse.");
                Console.WriteLine("Du förlorar, påse slår sten.");
                computerScore++;
                Console.WriteLine($"Datorn har {computerScore} poäng och du har {userScore} poäng.");
                Console.WriteLine();
                Console.WriteLine("***********************");
            }
            else if (userChoice == "påse")
            {
                Console.WriteLine("Datorn väljer sax");
                Console.WriteLine("Du förlorar, sax slår påse.");
                computerScore++;
                Console.WriteLine($"Datorn har {computerScore} poäng och du har {userScore} poäng.");
                Console.WriteLine();
                Console.WriteLine("***********************");
            }
            else if (userChoice == "sax")
            {
                Console.WriteLine("Datorn väljer sten");
                Console.WriteLine("Du förlorar, sten slår sax");
                computerScore++;
                Console.WriteLine($"Datorn har {computerScore} poäng och du har {userScore} poäng.");
                Console.WriteLine();
                Console.WriteLine("***********************");
            }
        }
        else if (computerChoice == 3)
        {
            if (userChoice == "sten")
            {
                Console.WriteLine("Datorn väljer sax");
                Console.WriteLine("Du vinner, sten slår sax!");
                userScore++;
                Console.WriteLine($"Datorn har {computerScore} poäng och du har {userScore} poäng.");
                Console.WriteLine();
                Console.WriteLine("***********************");
            }
            else if (userChoice == "påse")
            {
                Console.WriteLine("Datorn väljer sten");
                Console.WriteLine("Du vinner, påse slår sten!");
                userScore++;
                Console.WriteLine($"Datorn har {computerScore} poäng och du har {userScore} poäng.");
                Console.WriteLine();
                Console.WriteLine("***********************");
            }
            else if (userChoice == "sax")
            {
                Console.WriteLine("Datorn väljer påse");
                Console.WriteLine("Du vinner, sax slår påse!");
                userScore++;
                Console.WriteLine($"Datorn har {computerScore} poäng och du har {userScore} poäng.");
                Console.WriteLine();
                Console.WriteLine("***********************");
            }  
        }
        else
        {
            Console.WriteLine("Du måste välja mellan sten, sax eller påse!");
        }
    }
}

