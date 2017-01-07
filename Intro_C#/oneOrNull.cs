using System;

class oneOrNull
{
	static void Main()
	{
		Console.WriteLine("Please enter number a : ");
		int a = int.Parse(Console.ReadLine());
		Console.WriteLine(((a&(1<<3))==0)? "Thrid figure is 0" : "Thrid figure is 1");
	}
}