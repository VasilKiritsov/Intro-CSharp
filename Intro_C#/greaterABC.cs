using System;

class greaterABC
{
	static void Main()
	{
		int a,b,c;
		Console.WriteLine("Enter number \"a\" : ");
		bool result = int.TryParse(Console.ReadLine(), out a);
		Console.WriteLine("Enter number \"b\" : ");
		bool result1 = int.TryParse(Console.ReadLine(), out b);
		Console.WriteLine("Enter number \"c\" : ");
		bool result2 = int.TryParse(Console.ReadLine(), out c);
		if ((a>b)&&(a>c))
		{
			Console.WriteLine("a is greater then b and c.");
		}
		else if ((b>a)&&(b>c))
		{
			Console.WriteLine("b is greater then a and c.");
		}
		else if ((c>a)&&(c>b))
		{
			Console.WriteLine("c is greater then a and b.");
		}
		else
		{
			Console.WriteLine(" a = b = c");
		}
		
	}
}