using System;

class maxAB
{
	static void Main()
	{
		Console.WriteLine("Please enter number \"a\" : ");
		int a = int.Parse(Console.ReadLine());
		Console.WriteLine("Please enter number \"b\" : ");
		int b = int.Parse(Console.ReadLine());
		Console.WriteLine("Greater between \"a\" and \"b\" is : " + Math.Max(a,b));
	}
}