using System;

class catalanNum
{
	static void Main()
	{
		Console.WriteLine("Enter number \"n\" : ");
		int n = int.Parse(Console.ReadLine());
		int numerator = 2*n;
		int denumerator = n+1;
		for (int i=2*n;i>0;i--)
		{
			numerator *=i;
		}
		for (int i=n+1;i>0;i--)
		{
			denumerator *=i;
		}
		for (int i=n;i>0;i--)
		{
			n*=i;
		}
		Console.WriteLine("The result is : {0}.",numerator/(denumerator*n));
	}
}