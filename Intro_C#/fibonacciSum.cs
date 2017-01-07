using System;

class fibonacciSum
{
	static void Main()
	{
		Console.WriteLine("Enter \"n\" for Fibonacci numbers : ");
		int n = int.Parse(Console.ReadLine());
		int num1=0;
		int num2=1;
		int sum=0;
		int sum2=1;
		Console.WriteLine(num1);
		Console.WriteLine(num2);
		for (int i=0;i<n;i++)
		{
			sum = num1+num2;
			num1=num2;
			num2=sum;
			Console.WriteLine(num2);
			sum2 +=sum;
		}
		Console.WriteLine(sum2);
	}
}