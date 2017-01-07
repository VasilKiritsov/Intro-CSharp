using System;

class sumParse
{
	static void Main()
	{
		int a,b,c,d,e;
		bool parseSuccesed = false;
		do
		{
			Console.WriteLine("PLease enter number \"a\" : ");
			parseSuccesed = int.TryParse(Console.ReadLine(), out a);
			Console.WriteLine(parseSuccesed);
		} while (!parseSuccesed);
		do
		{
			Console.WriteLine ("Please enter number \"b\" : ");
			parseSuccesed = int.TryParse(Console.ReadLine(), out b);
			Console.WriteLine(parseSuccesed);
		} while (!parseSuccesed);
		do
		{
			Console.WriteLine("Please enter number \"c\" : ");
			parseSuccesed = int.TryParse(Console.ReadLine(),out c);
			Console.WriteLine(parseSuccesed);
		} while (!parseSuccesed);
		do
		{
			Console.WriteLine("Please enter number \"d\" : ");
			parseSuccesed = int.TryParse(Console.ReadLine(), out d);
			Console.WriteLine(parseSuccesed);
		} while (!parseSuccesed);
		do
		{
			Console.WriteLine("Please enter number \"e\" : ");
			parseSuccesed = int.TryParse(Console.ReadLine(), out e);
			Console.WriteLine(parseSuccesed);
		} while (!parseSuccesed);
		int sum = a+b+c+d+e;
		Console.WriteLine("Sum of \"a+b+c+d+e\" is : " + sum);
	}
}