using System;

class swapAB
{
	static void Main()
	{
		Console.WriteLine("Enter number \"a\" : ");
		int a = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter number \"b\" : ");
		int b = int.Parse(Console.ReadLine());
		if (a > b)
		{
			int c = a;
			a=b;
			b=c;
			Console.WriteLine("\"a\" must be smaller then \"b\", so : ");
			Console.WriteLine("a = b" + " and b = a");
			Console.WriteLine("a={0}" + " " + "b={1}",b,a);
		}
	}
}
