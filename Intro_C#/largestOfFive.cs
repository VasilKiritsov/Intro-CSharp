using System;

class largestOfFive
{
	static void Main()
	{
		Console.WriteLine("Please enter parameter \"a\" : ");
		int a = int.Parse(Console.ReadLine());
		Console.WriteLine("Please enter parameter \"b\" : ");
		int b = int.Parse(Console.ReadLine());
		Console.WriteLine("Please enter parameter \"c\" : ");
		int c = int.Parse(Console.ReadLine());
		Console.WriteLine("Please enter parameter \"d\" : ");
		int d = int.Parse(Console.ReadLine());
		Console.WriteLine("Please enter parameter \"e\" : ");
		int e = int.Parse(Console.ReadLine());
		if ((a>b)&&(a>c)&&(a>d)&&(a>e))
		{
			Console.WriteLine("Largest number is a={0}",a);
		}
		else if ((b>a)&&(b>c)&&(b>d)&&(b>e))
		{
			Console.WriteLine("Largest number is b={0}",b);
		}
		else if ((c>a)&&(c>b)&&(c>d)&&(c>e))
		{
			Console.WriteLine("Largest number is c={0}",c);
		}
		else if ((d>a)&&(d>b)&&(d>c)&&(d>e))
		{
			Console.WriteLine("Largest number is d={0}",d);
		}
		else if ((e>a)&&(e>b)&&(e>c)&&(e>d))
		{
			Console.WriteLine("Largest number is e={0}",e);
		}
		else
		{
			Console.WriteLine("Don`t have largest number, because a=b=c=d=e={0}",a);
		}
	}
}