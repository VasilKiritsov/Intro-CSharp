using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class quickSort
{
	public static void  QuickSort(int[] numbers, int left, int right)
	{
		int i = left;
		int j = right;
		int pivot = numbers[(left + right)/2];
		
		while(i <= j)
		{
			while(numbers[i].CompareTo(pivot) < 0)
			{
				j++;
			}
			while(numbers[j].CompareTo(pivot) > 0)
			{
				j--;
			}
			while( i <= j)
			{
				int temp = numbers[i];
				numbers[i] = numbers[j];
				numbers[j] = temp;
				
				i++;
				j--;
			}
			
		}
		if(left < j)
		{
			QuickSort(numbers, left,j);
		}
		if(i < right)
		{
			QuickSort(numbers, i, right);
		}
	}
	public static void Main()
	{
		Console.WriteLine("Please enter length of array \"n\" : ");
		int n = int.Parse(Console.ReadLine());
		int[] arr = new int[n];
		
		for(int i = 0; i < n; i++)
		{
			Console.Write("Element {0} : ",i);
			arr[i] = int.Parse(Console.ReadLine());
		}
		
		QuickSort(arr,0,n - 1);
		
		for (int i = 0; i < arr.Length; i++)
		{
			Console.WriteLine(arr[i]);
		}
	}
}