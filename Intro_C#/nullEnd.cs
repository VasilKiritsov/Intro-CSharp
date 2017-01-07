using System;

class nullEnd
{
	static void Main()
	{
		Console.WriteLine("Enter number \"n\" : ");
		int n = int.Parse(Console.ReadLine());
		int zeroes = 0;
		for (int i= (int)(n-1);i > 0;i--)
		{
			n *= i;
			while (n % 10 == 0)
			{
				n = n/10;
				zeroes++;
			}
		}
		Console.WriteLine("N! = {0} endes with {1} nulls.",n,zeroes);
	}
}