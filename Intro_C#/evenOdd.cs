using System;

class evenOdd
{
	static void Main()
	{
		Console.WriteLine("Please enter number a :");
		int a = int.Parse(Console.ReadLine());
		double i = a%2;
		
		if (i==0)
		{
		Console.WriteLine("Number a is : even");
		}
		else
		{
		Console.WriteLine("Number a is : odd");
		}
	}
}