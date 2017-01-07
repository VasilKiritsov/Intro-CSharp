using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class wantedSort
{
	static void Main()
	{
		int subset = 0;
		int longestLength = 0;
		
		Console.WriteLine("Please enter length of array \"n\" : ");
		int n = int.Parse(Console.ReadLine());
		int[] arr = new int[n];
		
		for(int i = 0; i < n; i++)
		{
			Console.Write("element {0} : ",i);
			arr[i] = int.Parse(Console.ReadLine());
		}
		int m = (1 << n);
		int[,] subsets = new int[m,n];
		
		for(int i = 0; i < m; i++)
		{
			for(int j = 0; j < n; j++)
			{
				subsets[i,j] = i / (m / 2 /(1 << j))%2;
			}
		}
		
		for(int i = 0; i < m; i++)
		{
			int max = -1000;
			int count = 0;
			
			for(int j = 0; j < n; j++)
			{
				if(subsets[i,j] > 0)
				{
					if(arr[j] >= max)
					{
						count++;
						max = arr[j];
					}
					else
					{
						count = 0;
						break;
					}
				}
			}
			
			if(longestLength < count)
			{
				longestLength = count;
				subset = i;
			}
		}
		Console.Write("Result is : ");
		for(int i = 0; i < n; i++)
		{
			if(subsets[subset, i] > 0)
			{
				Console.Write(arr[i] + " ");
			}
		}
	}
}