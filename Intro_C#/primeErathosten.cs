using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class primeErathosten
{
	static void Main()
	{
		Console.WriteLine("Enter length of array \"n\" : ");
		int n = int.Parse(Console.ReadLine());
		int [] arr = new int[n];
		bool[] prime = new bool[n +1];
		
		for (int i = 2; i <= n; i++)
		{
			prime[i] = true;
		}
		
		for(int i = 2; i< n; i++)
		{
			if(prime[i])
			{
				for(int j = i + i; j <= prime.Length; j += i)
				{
					prime[j] = false;
				}
			}
		}
		for(int i = 0; i < prime.Length; i++)
		{
			if(prime[i])
			{
				Console.WriteLine(i);
			}
		}
	}
}