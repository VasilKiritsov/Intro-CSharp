using System;

class bgNum
{
	static void Main()
	{
		Console.WriteLine("Please enter number \"a\" : ");
		int a = int.Parse(Console.ReadLine());
		switch (a)
		{
			case 0 : Console.WriteLine("Номера е нула.");break;
			case 1 : Console.WriteLine("Номера е едно.");break;
			case 2 : Console.WriteLine("Номера е две.");break;
			case 3 : Console.WriteLine("Номера е три.");break;
			case 4 : Console.WriteLine("Номера е четири.");break;
			case 5 : Console.WriteLine("Номера е пет.");break;
			case 6 : Console.WriteLine("Номера е шест.");break;
			case 7 : Console.WriteLine("Номера е седем.");break;
			case 8 : Console.WriteLine("Номера е осем.");break;
			case 9 : Console.WriteLine("Номера е девет.");break;
			default:
				Console.WriteLine("Номера е по-голям от девет."); break;
		}
	}
}