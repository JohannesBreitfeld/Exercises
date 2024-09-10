//e1(); //1. Bokstav för bokstav - fram till space
//e2(); //2. Bokstav fär bokstav - radbyte på space
//e3(); //3. Bokstav för bokstav - varannan stjärna
//e4(); //4. Bokstav för bokstav - gröna o, röda l
//e5(); //5. Bokstav för bokstav - dubbla med grön färg
//e6(); //6. Bokstav för bokstav - grön substring
//e7(); //7. Bokstav för bokstav - grön substring 2
//e8(); //8. Bokstav för bokstav - grön substring 3
//e9(); //9. Bokstavspyramid
//e10(); //10. Ordpyramid
//e11(); //11. Ordpyramid 2
//e12(); //12. Rödmarkerade ord
//e13(); //13. Rödmarkerade bokstäver
//e14(); //14. Rödmarkerade bokstäver 2
//e15(); //15. Rödmarkerade bokstäver 3
static void e1()
{
	var myString = "Hello World!";
	for (int i = 0; i < myString.Length; i++)
	{
		if (myString[i] == ' ')
		{
			break;
		}
		else
		{
			Console.Write(myString[i]);
		}
	}
}
static void e2()
{
	var myString = "This is just some other text";
	for (int i = 0; i < myString.Length; i++)
	{
		if (myString[i] == ' ')
		{
			Console.WriteLine();
		}
		else
		{
			Console.Write(myString[i]);
		}
	}
}
static void e3()
{
	var myString = "Detta är uppgift 3";
	for (int i = 0; i < myString.Length; i++)
	{
		Console.Write(i % 2 == 0 ? '*' : myString[i]);
	}
}
static void e4()
{
	var myString = "Hello World!";
	for (int i = 0; i < myString.Length; i++)
	{
		if (char.ToUpper(myString[i]) == char.ToUpper('o'))
		{
			Console.ForegroundColor = ConsoleColor.Green;
		}
		else if (char.ToUpper(myString[i]) == char.ToUpper('l'))
		{
			Console.ForegroundColor = ConsoleColor.Red;
		}
		else
		{
			Console.ForegroundColor = ConsoleColor.Gray;
		}

		Console.Write(myString[i]);
	}
}
static void e5()
{
	var myString = "Hello World!";
	ConsoleColor defaultColor = ConsoleColor.Gray;

	for (int i = 0; i < myString.Length; i++)
	{
		bool isDuplicate = false;

		if (i > 0 && char.ToLower(myString[i]) == char.ToLower(myString[i - 1]))
		{
			isDuplicate = true;
		}
		if (i < myString.Length - 1 && char.ToLower(myString[i]) == char.ToLower(myString[i + 1]))
		{
			isDuplicate = true;
		}

		Console.ForegroundColor = isDuplicate ? ConsoleColor.Green : defaultColor;
		Console.Write(myString[i]);
	}

	Console.ForegroundColor = defaultColor;
}
static void e6()
{
	var myString = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
	for (int i = 0; i < myString.Length; i++)
	{
		bool isDuplicate = false;

		if (i > 0 && char.ToLower(myString[i]) == 'o' && char.ToLower(myString[i - 1]) == 'o')
		{
			isDuplicate = true;
		}
		if (i < myString.Length - 1 && char.ToLower(myString[i]) == 'o' && char.ToLower(myString[i + 1]) == 'o')
		{
			isDuplicate = true;
		}

		Console.ForegroundColor = isDuplicate ? ConsoleColor.Green : ConsoleColor.Gray;
		Console.Write(myString[i]);
	}
	Console.ForegroundColor = ConsoleColor.Gray;
}
static void e7()
{
	var myString = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
	var stringToControl = "chuck";
	var indexMarker = 0;

	for (int i = 0; i < myString.Length; i++)
	{

		var controlString = "";
		if (i <= myString.Length - stringToControl.Length)
		{
			for (int j = 0; j < stringToControl.Length; j++)
			{
				controlString += myString[i + j];
			}
		}
		if (controlString == stringToControl)
		{
			indexMarker = stringToControl.Length;
		}

		Console.ForegroundColor = indexMarker > 0 ? ConsoleColor.Green : ConsoleColor.Gray;

		Console.Write(myString[i]);

		if (indexMarker > 0)
		{
			indexMarker--;
		}
	}
}
static void e8()
{
	var myString = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
	Console.WriteLine(myString);
	Console.WriteLine("Skriv in de bokstäver eller ord du vill ha grönmarkerade:");
	var stringToControl = Console.ReadLine();

	int stringToControlLength = stringToControl.Length;

	for (int i = 0; i < myString.Length; i++)
	{
		if (i <= myString.Length - stringToControlLength && myString.Substring(i, stringToControlLength) == stringToControl)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			for (int j = 0; j < stringToControlLength; j++)
			{
				Console.Write(myString[i + j]);
			}
			i += stringToControlLength - 1;
		}
		else
		{
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.Write(myString[i]);
		}
	}

	Console.ResetColor();
}
static void e9()
{
	var myString = "Hello World!";


	for (int i = 0; i < myString.Length; i++)
	{
		for (int j = 0; j <= i; j++)
		{
			Console.Write(myString[i]);

		}
		Console.WriteLine();
	}
}
static void e10()
{
	var myString = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
	string[] words = myString.Split(' ');

	for (int i = 0; i < words.Length; i++)
	{
		for (int j = 0; j <= i; j++)
		{
			Console.Write($"{words[i]} ");
		}
		Console.WriteLine();
	}
}
static void e11()
{
	var myString = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
	string[] words = myString.Split(' ');

	for (int i = 0; i < words.Length; i++)
	{
		for (int j = 0; j <= i; j++)
		{
			Console.Write(words[j] + ' ');
		}
		Console.WriteLine();
	}
}
static void e12()
{
	var myString = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
	string[] words = myString.Split(' ');

	for (int i = 0; i < words.Length; i++)
	{
		for (int j = 0; j < words.Length; j++)
		{
			Console.ForegroundColor = j == i ? ConsoleColor.Red : ConsoleColor.Gray;
			Console.Write(words[j] + ' ');
		}
		Console.WriteLine();
	}
	Console.ForegroundColor = ConsoleColor.Gray; // Ändra tillbaka färgen
}
static void e13()
{
	var myString = "abcdefghijklmnopqrstuvwxyz";
	var controlLength = 5;

	for (int i = 0; i < myString.Length - controlLength; i++)
	{
		for (int j = 0; j < myString.Length; j++)
		{
			Console.ForegroundColor = (i + controlLength >= j && i - 1! < j) ? ConsoleColor.Red : ConsoleColor.Gray;
			Console.Write(myString[j]);
		}
		Console.WriteLine();
	}
	Console.ForegroundColor = ConsoleColor.Gray;
}
static void e14()
{
	var myString = Console.ReadLine();
	var firstChar = myString[0];
	Console.ForegroundColor = ConsoleColor.Red;

	for (int i = 0; i < myString.Length; i++)
	{
		if (i != 0 && myString[i] == firstChar)
		{
			Console.ForegroundColor = ConsoleColor.Gray;
		}
		Console.Write(myString[i]);
	}
}
static void e15()
{
	var myString = "ajdfhvajhdfd";

	for (int i = 0; i < myString.Length; i++)
	{
		var isRed = false;
		char startStopChar = myString[i];
		bool beenRed = false;

		for (int j = 0; j < myString.Length; j++)
		{
			if (myString[j] == startStopChar && isRed == false && j! > i - 1 && beenRed == false)
			{
				isRed = true;
				beenRed = true;
			}
			else if (myString[j] == startStopChar && isRed == true)
			{
				isRed = false;
			}

			Console.ForegroundColor = (isRed == true) ? ConsoleColor.Red : ConsoleColor.Gray;
			Console.Write(myString[j]);

		}
		Console.WriteLine();
	}
	Console.ForegroundColor = ConsoleColor.Gray;
}