using System;

class nAndK
{
	static void Main()
	{
		Console.WriteLine("Enter number \"n\" : ");
		int n = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter number \"k\" : ");
		int k = int.Parse(Console.ReadLine());
		for (int i=n-1;i>0;i--)
		{
			n *=i;
		}
		for (int j=k-1;j>0;j--)
		{
			k*=j;
		}
		int nMinusK = n-k;
		Console.WriteLine("The Result is : {0}.",n*k/nMinusK);
	}
}