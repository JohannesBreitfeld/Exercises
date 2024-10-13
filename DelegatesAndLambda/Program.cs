//E1(); //1. Deklarera en egen delegat-typ
//E2(); //2. Använd generiskt delegat
//E3(); //3. Metod som tar delegat som inparameter
//E4(); //4. Skriv ut summan av två värden
//E5(); //5. Returnera summan av två värden
//E6(); //6. Lambda som argument
//E7(); //7. Modifiera utskrift med lambdauttryck
//E8(); //8. Filtrera array (utskrift)
//E9(); //9. Filtrera array (till ny array)

void DelegateAsparameter(Func<string, string, string> MyDelegate)
{
    Console.WriteLine(MyDelegate("Anna", "Ahl"));
    Console.WriteLine(MyDelegate("Bettan", "Bruhn"));
    Console.WriteLine(MyDelegate("Calle", "Carlsson"));
}
static string TwoLines(string firstName, string lastName)
{
    return $"firstName: {firstName}\nlastName: {lastName}";
}

static string FullName(string firstName, string lastName)
{
    return $"{firstName} {lastName}";
}



static void E1()
{
    StringDelegate myDelegate = FullName;
    Console.WriteLine($"Delegat: {myDelegate("Johannes", "Breitfeld")}");
}

static void E2()
{
    Func<string, string, string> MyFunc = FullName;
    Console.WriteLine($"Func: {MyFunc("Johannes", "Breitfeld")}");
}

void E3()
{
    Console.WriteLine("************************");
    DelegateAsparameter(FullName);
    Console.WriteLine("************************");
    DelegateAsparameter(TwoLines);
}

static void E4()
{
    Action<int, int> Sum = (a, b) => Console.WriteLine(a + b);
    Sum(4, 7);
}

static void E5()
{
    Func<int, int, int> ReturnSum = (a, b) => a + b;
    Console.WriteLine(ReturnSum(8, 5));
}

void E6()
{
    DelegateAsparameter((a, b) => $"firstName has {a.Length} letters, lastName has {b.Length} letters");
}

static void E7()
{
    string[] cities = new string[] { "London", "Paris", "Madrid", "Oslo", "Rom" };

    PrintStringArray(cities, (text) => text.ToUpper());
    PrintStringArray(cities, (text) => text.Substring(0,3));
    PrintStringArray(cities, (text) => $"{text.Length}");


    static void PrintStringArray(string[] cities, Func<string, string> modifier)
    {
        foreach (var city in cities)
        {
            Console.WriteLine($"{modifier(city)}");
        }
    }
}

static void E8()
{
    int[] integers = new[] { 1, -4, 8, 15, -22, 20, 18, -7, 12, 122 };

    IntArray(integers, (n) => n < 0);
    Console.WriteLine("******************");
    IntArray(integers, (n) => n >= 10 && n <= 20);
    Console.WriteLine("**********************");
    IntArray(integers, (n) => n % 2 == 0);

    static void IntArray(int[] array, Func<int, bool> predicate)
    {    
        foreach (var item in array)
        {
            if (predicate(item)) Console.WriteLine(item);
        }
    }
}

static void E9()
{
    int[] integers = new[] { 1, -4, 8, 15, -22, 20, 18, -7, 12, 122 };

    int[] array1 = IntArray(integers, (n) => n < 0);
    foreach (var item in array1)
    {
        Console.WriteLine(item);
    }
    
    Console.WriteLine("******************");
    int[] array2 = IntArray(integers, (n) => n >= 10 && n <= 20);
    foreach (var item in array2)
    {
        Console.WriteLine(item);
    }

    Console.WriteLine("**********************");
    int[] array3 = IntArray(integers, (n) => n % 2 == 0);
    foreach (var item in array3)
    {
        Console.WriteLine(item);
    }

    static int[] IntArray(int[] array, Func<int, bool> predicate)
    {
        int[] returnArray = new int[0];

        foreach (var item in array)
        {
            if (predicate(item))
            {
                int[] tempArray = new int[returnArray.Length + 1];
                for (int i = 0; i < returnArray.Length; i++)
                {
                    tempArray[i] = returnArray[i];
                }
                tempArray[returnArray.Length] = item;
                returnArray = tempArray;
            }
        }
        return returnArray;
    }
}


delegate string StringDelegate(string a, string b);