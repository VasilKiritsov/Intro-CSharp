using System;

class aAndb
{
	static void Main()
	{
		Console.WriteLine("a=7");
		Console.WriteLine("b=8");
		int a = 7;
		int b = 8;
		int c = a;
		a = b;
		b = c;
		Console.WriteLine("a= {0}", a);
		Console.WriteLine("b= {0}", b);
	}
}