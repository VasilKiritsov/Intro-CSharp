using System;

class nDevX
{
	static void Main()
	{
		Console.WriteLine("Enter number \"n\" : ");
		int n = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter number \"x\" : ");
		int x = int.Parse(Console.ReadLine());
		int sum =1;
		int power=1;
		for (int i=1;i<=n;i++)
		{
			power *= n/x;
			sum += power;
		}
		Console.WriteLine("The result is : {0} .",sum);
	}
}
