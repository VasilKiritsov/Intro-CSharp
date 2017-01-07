using System;

class positionPinN
{
	static void Main()
	{
		Console.WriteLine("Please enter number \"n\" : ");
		int n = int.Parse(Console.ReadLine());
		Console.WriteLine("Please enter a bit position \"p\" : ");
		int p = int.Parse(Console.ReadLine());
		int i = 1;
		int mask = i<<p;
		Console.WriteLine((n & mask) !=0 ? 1 : 0);
	}
}