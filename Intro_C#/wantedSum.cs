using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class wantedSumInN
{
	static int wantedSum;
	static bool solution = false;
	
	static void GenerateSubset(int[] arr, int[]subset, int index, int current, int elementInSubset)
	{
		
		if(index == elementInSubset)
		{
			CheckSubset(subset,elementInSubset);
			return;
		}
		
		for (int i = current; i < arr.Length; i++)
		{
			subset[index]= arr[i];
			GenerateSubset(arr, subset, index + 1, i + 1,elementInSubset);
		}
	}
	
	static void CheckSubset(int[]subset,int elementInSubset)
	{
		int sum = 0;
		
		for(int i = 0; i < elementInSubset; i++)
		{
			sum += subset[i];
		}
		
		if (sum == wantedSum)
		{
			for(int i = 0; i < elementInSubset; i++)
			{
				Console.Write("{0} ",subset[i]);
			}
			Console.WriteLine();
			solution = true;
		}
	}
	
	static void Main()
	{
		Console.WriteLine("Enter array length \"n\" : ");
		int n = int.Parse(Console.ReadLine());
		
		int[] arr = new int[n];
		for(int i = 0; i < n; i++)
		{
			Console.Write("element {0} : ",i);
			arr[i] = int.Parse(Console.ReadLine());
		}
		
		Console.WriteLine("Enter wanted sum : ");
		wantedSum = int.Parse(Console.ReadLine());
		int[] subset = new int[n];
		
		for(int i = 0; i<= n; i++)
		{
			GenerateSubset(arr, subset, 0, 0,i);
		}
		if(!solution)
		{
			Console.WriteLine("No subset with sum {0} found!",wantedSum);
		}
	}
}