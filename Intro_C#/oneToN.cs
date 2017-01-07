using System;

class oneToN
{
	static void Main()
	{
		Console.WriteLine("Please insert number \"n\" : ");
		int n = int.Parse(Console.ReadLine());
		for (int i=1;i<n;i++)
		{
			Console.WriteLine("From 1 to n : {0}",i);
		}
	}
}