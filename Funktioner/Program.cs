//e1(); //1. Slå ihop för- och efternamn - skriv ut
//e2(); //2. Slå ihop för- och efternamn - returnera
//e3(); //3. Kolla om stängen är längre än ett givet antal tecken
//e4(); //4. Omvandla Celsius till Fahrenheit
//e5(); //5. Lägg in bindesträck mellan tecken i en sträng
//e6(); //6. Egen version av String.Join();
//e7(); //7. Beräkna medelvärde av int-array
//e8(); //8. Siffror till text
//e9(); //9. Heltal till text
//e10(); //10. Hitta index för alla förekomster av ett givet tecken
//e11(); //11. Kasta tärning
//e12(); //12. Rita en box
//e13(); //13. Flytta runt ett @ med piltangenterna
e14(); //14. Masken


static void e1()
{
    static void PrintName(string firstName, string lastName)
    {
        Console.WriteLine($"{firstName} {lastName}");
    }
    PrintName("Johannes", "Breitfeld");
}
static void e2()
{
    static string PrintName(string firstName, string lastName)
    {
        return $"{firstName} {lastName}";
    }
    Console.WriteLine(PrintName("Johannes", "Breitfeld"));
}
static void e3()
{
    static bool IsLongerThan(string word, int number)
    {
        return number > word.Length ? true : false;
    }
}
static void e4()
{
    static double CelsiusToFahrenheit(double celsius)
    {
        return celsius * 1.8 + 32;
    }
}
static void e5()
{
    static string AddHyphenToString(string word)
    {
        var newWord = "";
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == ' ' || i == 0)
            {
                newWord += word[i];
            }
            else if (word[i - 1] == ' ')
            {
                newWord += word[i];
            }
            else
            {
                newWord += $"-{word[i]}";
            }
        }
        return newWord;
    }
    var x = AddHyphenToString("Johannes Breitfeld");
    Console.WriteLine(x);
}
static void e6()
{
    static string MyJoin(string delimiter, params string[] strings)
    {
        string newString = "";
        for (int i = 0; i < strings.Length; i++)
        {
            newString += (i == 0) ? strings[i] : $"{delimiter}{strings[i]}";
        }
        return newString;
    }
}
static void e7()
{
    static double GetAverage(params int[] numbers)
    {
        double sum = 0;
        var counter = 0;
        foreach (var number in numbers)
        {
            sum += number;
            counter++;
        }
        return sum / counter;
    }
}
static void e8()
{
    static string[] NumbersToWords(int integer)
    {
        string[] integersAsStrings = new string[] { "noll", "ett", "två", "tre,", "fyra", "fem", "sex", "sju", "åtta", "nio" };
        string asString = integer.ToString();
        string[] stringArray = new string[asString.Length];

        for (int i = 0; i < asString.Length; i++)
        {
            stringArray[i] = integersAsStrings[int.Parse(asString[i].ToString())];
        }

        return stringArray;
    }
}
static void e9()
{
    static string IntegerToText(ushort integer)
    {
        if (integer == 0)
        {
            return "";
        }
        else if (integer > 0 && integer <= 19)
        {
            var arr = new string[] { "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio", "tio",
                "elva", "tolv", "tretton", "fjorton", "femton", "sexton", "sjutton", "arton", "nitton" };
            return arr[integer - 1] + " ";
        }
        else if (integer >= 20 && integer <= 99)
        {
            var arr = new string[] { "tjugo", "trettio", "fyrtio", "femtio", "sextio", "sjuttio", "åttio", "nittio" };
            return arr[integer / 10 - 2] + " " + IntegerToText((ushort)(integer % 10));
        }
        else if (integer >= 100 && integer <= 199)
        {
            return "ett hundra " + IntegerToText((ushort)(integer % 100));
        }
        else if (integer >= 200 && integer <= 999)
        {
            return IntegerToText((ushort)(integer / 100)) + "hundra " + IntegerToText((ushort)(integer % 100));
        }
        else if (integer >= 1000 && integer <= 1999)
        {
            return "ett tusen " + IntegerToText((ushort)(integer % 1000));
        }
        else
        {
            return IntegerToText((ushort)(integer / 1000)) + "tusen " + IntegerToText((ushort)(integer % 1000));
        }
    }
}
static void e10()
{
    var myString = "Hello World!";
    foreach (var item in IndexesOf(myString, 'o'))
    {
        Console.Write($"{item}, ");
    }

    static int[] IndexesOf(string text, char c)
    {
        int[] indexArray = new int[0];

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == c)
            {
                int[] newIndexArray = new int[indexArray.Length + 1];
                for (int j = 0; j < indexArray.Length; j++)
                {
                    newIndexArray[j] = indexArray[j];
                }
                newIndexArray[newIndexArray.Length - 1] = i;
                indexArray = newIndexArray;
            }
        }
        return indexArray;
    }
}
static void e11()
{
    var results = ThrowDice(6);
    foreach (var result in results)
    {
        Console.Write($"{result}, ");
    }

    static int[] ThrowDice(int numberOfThrows)
    {
        Random rand = new Random();
        int[] results = new int[0];

        for (int i = 0; i < numberOfThrows; i++)
        {
            int diceThrow = rand.Next(1, 7);

            int[] tempArray = new int[results.Length + 1];
            for (int j = 0; j < results.Length; j++)
            {
                tempArray[j] = results[j];
            }
            tempArray[tempArray.Length - 1] = diceThrow;
            results = tempArray;
        }
        return results;
    }
}
static void e12()
{
    Console.WriteLine("Skriv in höjd:");
    var height = int.Parse(Console.ReadLine());
    Console.WriteLine("Skriv in bredd:");
    var width = int.Parse(Console.ReadLine());
    Drawbox(height, width);

    static void Drawbox(int height, int width)
    {
        for (int i = 1; i <= height; i++)
        {
            for (int j = 1; j <= width; j++)
            {
                if (i == 1 || i == height)
                {
                    Console.Write("#");
                }
                else
                {
                    if (j == 1 || j == width)
                        Console.Write("#");
                    else
                    {
                        Console.Write("-");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
static void e13()
{
    Drawbox(20, 20);
    UserInput();

    static void Drawbox(int row, int column)
    {
        char[,] boardArray = new char[row, column];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                if (i == 0 || i == row-1)
                {
                    Console.Write('#');
                }
                else if (j == 0 || j == column-1)
                    Console.Write('#'); 
                else
                {
                    Console.Write('-');
                }
            }
        }
        Console.WriteLine();
    }
    static void UserInput()
    {
        ConsoleKeyInfo consoleKeyInfo;
        int col = 10, row = 10;
        Console.SetCursorPosition(col, row);
        Console.Write("@");
        while (true)
        {
            consoleKeyInfo = Console.ReadKey(true);
            Console.SetCursorPosition(col, row);
            Console.Write("-");
            switch (consoleKeyInfo.Key)
            {
                case ConsoleKey.LeftArrow:
                    if (col > 1) --col;
                    break;
                case ConsoleKey.UpArrow:
                    if (row > 1) --row;
                    break;
                case ConsoleKey.DownArrow:
                    if (row < 18) ++row;
                    break;
                case ConsoleKey.RightArrow:
                    if (col < 18) ++col;
                    break;

            }
            Console.SetCursorPosition(col, row);
            Console.Write("@");
        }
    }
}

static void e14()
{
    char[,] newBoard = AddObstaclesToBoard(Drawbox(20, 40), 5);
    PrintBoard(newBoard);
    Run(newBoard);

    static char[,] Drawbox(int row, int column)
    {
        char[,] boardArray = new char[row, column];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                if (i == 0 || i == row - 1)
                {
                    boardArray[i, j] = '#';
                }
                else if (j == 0 || j == column - 1)
                {
                    boardArray[i, j] = '#';
                }
                else
                {
                    boardArray[i, j] = '-';
                }
            }
        }
        return boardArray;
    }
    static void Run(char[,] board)
{
        ConsoleKeyInfo consoleKeyInfo;
        int boardWidth = board.GetLength(1);
        int boardHeight = board.GetLength(0);
        int col = board.GetLength(1)/2; 
        int row = board.GetLength(0) /2;
        Console.SetCursorPosition(col, row);
        Console.Write("@");
        while (true)
        {
            consoleKeyInfo = Console.ReadKey(true);
            Console.SetCursorPosition(col, row);
            Console.Write("-");
            switch (consoleKeyInfo.Key)
            {
                case ConsoleKey.LeftArrow:
                    if (board[row, col-1] != '#') --col;
                    break;
                case ConsoleKey.UpArrow:
                    if (board[row-1, col] != '#') --row;
                    break;
                case ConsoleKey.DownArrow:
                    if (board[row+1, col] != '#') ++row;
                    break;
                case ConsoleKey.RightArrow:
                    if (board[row, col+1] != '#') ++col;
                    break;

            }
            Console.SetCursorPosition(col, row);
            Console.Write("@");
        }
}
    static char[,] AddObstaclesToBoard(char[,] board, int NrOfRandomObstales)
    {
        Random rand = new Random();
        int row = board.GetLength(0);
        int col = board.GetLength(1);
        
        for (int i = 0; i < NrOfRandomObstales; i++)
        {
            board[rand.Next(1, row - 2), rand.Next(1, col - 2)] = '#';
        }
        return board;
    }
    static void PrintBoard(char[,] board)
    {
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                Console.Write(board[i, j]);
            }
            Console.WriteLine();
        }
    }
}
