using System;

class newLineInt
{
	static void Main()
	{
		int i=0;
		Console.WriteLine("enter \"n\" : ");
		int n = int.Parse(Console.ReadLine());
		for (i=0;i<=n;i++)
			Console.WriteLine("From \"0\" to \"n\" : " + i);
	}
}