using System;

class weightOnTheMoon

{
	static void Main()
	{
		Console.WriteLine("Your wieght on the Moon is 17% from your weight on the Earth...");
		Console.WriteLine("Tell me your weith please :");
		int kg = Convert.ToInt32(Console.ReadLine());
		double moonKg = ((double)kg * 0.17);
		Console.WriteLine("Yuor Moon weight is : " + moonKg + '.');
	}
}
