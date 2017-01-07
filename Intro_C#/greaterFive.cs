using System;

class greaterFive
{
	static void Main()
	{
		Console.WriteLine("Please enter number \"a\" : ");
		int a = int.Parse(Console.ReadLine());
		Console.WriteLine("Please enter number \"b\" : ");
		int b = int.Parse(Console.ReadLine());
		Console.WriteLine("Please enter number \"c\" : ");
		int c = int.Parse(Console.ReadLine());
		Console.WriteLine("Please enter number \"d\" : ");
		int d = int.Parse(Console.ReadLine());
		Console.WriteLine("Please enter number \"e\" : ");
		int e = int.Parse(Console.ReadLine());
		if (a>b && a>c && a>d && a>e)
		{
			Console.WriteLine("Greatest number is : " + a);
		}
		else if (b>a && b>c && b>d && b>e)
		{
			Console.WriteLine("Greatest number is : " + b);
		}
		else if (c>a && c>b && c>d && c>e)
		{
			Console.WriteLine("Greatest number is : " + c);
		}
		else if (d>a && d>b && d>c && d>e)
		{
			Console.WriteLine("Greatest number is : " + d);
		}
		else if (e>a && e>b && e>c && e>d)
		{
			Console.WriteLine("Greatest number is : " + e);
		}
		else 
		{
			Console.WriteLine("Don`t have greatest number");
		}
	}
}