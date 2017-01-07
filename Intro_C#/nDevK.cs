using System;

class nDevK
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
		decimal dev = n/k;
		Console.WriteLine("The result for n!={0}, and k!={1} is : {2}.",n,k,dev);
	}
}
	