using System;

class floatSum
{
	static void Main()
	{
		Console.WriteLine("Enter last number : ");
		int lenght = int.Parse(Console.ReadLine());
		double sum = 1.0;
		for (int i=2;i<=lenght;i++)
		{
			sum += (1.0/i);
			Console.WriteLine("{0:f3}", sum);
		}
	}
}
