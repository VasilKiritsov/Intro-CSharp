using System;

class numColums

{
	static void Main()
	{
		Console.WriteLine("Enter simple number \"a\" :");
		int a = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter positive real number \"b\" :");
		double b = double.Parse(Console.ReadLine());
		Console.WriteLine("Enter negative real number \"c\" :");
		double c = double.Parse(Console.ReadLine());
		Console.WriteLine("{0,-10:x}{1,-10:f2}{2,-10:f2} ",a,b,c);
		Console.WriteLine("{0,-10:x}{1,-10:f2}{2,-10:f2} ",a,b,c);
		Console.WriteLine("{0,-10:x}{1,-10:f2}{2,-10:f2} ",a,b,c);
		Console.WriteLine("{0,10:x}{1,10:f3}{2,10:f4} ",a,b,c);
	}
}
