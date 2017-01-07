using System;

class binary
{
	static void Main()
	{
		Console.WriteLine("Enter number \"a\" : ");
		int a = int.Parse(Console.ReadLine());
		string binary = Convert.ToString(a,2);
		Console.WriteLine("Binary a is {0}.",binary);
	}
}