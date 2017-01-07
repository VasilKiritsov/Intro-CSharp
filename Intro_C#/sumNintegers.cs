using System;

class sumNintegers
{
	static void Main()
	{
		int a;
		int sum = 0;
		int count = 0;
		Console.WriteLine("Enter number \"n\" : ");
		byte n = byte.Parse(Console.ReadLine());
		do
		{
			Console.WriteLine("a({0}) = ",count);
			bool isValid = int.TryParse(Console.ReadLine(), out a);
			if (isValid)
			{
				sum += a;
				count++;
			}
		} while (count<n);
		Console.WriteLine("Sum of \"n\" is : " + sum);
	}
}