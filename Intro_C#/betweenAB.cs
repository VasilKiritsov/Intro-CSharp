using System;

class betweenAB
{
	static void Main()
	{
		int counter = 0;
		Console.WriteLine("Please enter number \"a\" : ");
		int a = int.Parse(Console.ReadLine());
		Console.WriteLine("Please enter number \"b\" : ");
		int b = int.Parse(Console.ReadLine());
		if (a>=b)
		{
			Console.WriteLine("Invalid number");
		}
		else
		{
			for (int i=a; i<=b;i++)
			{
				if (i%5==0) counter++;
			}
			Console.WriteLine("Numbers, with partition on 5, between \"a\" and \"b\" are : " + counter );
		}
	}
}
