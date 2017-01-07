using System;

class boolPinV
{
	static void Main()
	{
		Console.WriteLine("Please enter number \"v\" : ");
		int v = int.Parse(Console.ReadLine());
		Console.WriteLine("Please enter a bit position \"p\" : ");
		int p = int.Parse(Console.ReadLine());
		int i = 1;
		int mask = i<<p;
		int result = v & mask;
		if (result !=0)
		{
			Console.WriteLine(true);
		}
		else
		{
			Console.WriteLine(false);
		}
	}
}