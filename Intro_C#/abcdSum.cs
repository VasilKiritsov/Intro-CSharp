using System;

class abcdSum

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
		int sum = a+b+c+d;
		Console.WriteLine("Sum \"a+b+c+d\" is : " + sum);
	}
}