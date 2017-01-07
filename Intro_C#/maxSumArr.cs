using System;

class maxSumArr
{
	static void Main()
	{
		int sum = 1;
		int tempSum;
		Console.WriteLine("Enter length of array \"n\" : ");
		int n = int.Parse(Console.ReadLine());
		int[] arr = new int[n];
		for (int i = 0; i < n; i++)
		{
			Console.Write("element {0} : ",i);
			arr[i] = int.Parse(Console.ReadLine());
		}
		for (int i = 0; i < n - 1; i++)
		{
			tempSum = arr[i];
			for (int j = i+1; i < n; i++)
			{
				tempSum = arr[j];
				if(tempSum > sum)
				{
					sum = tempSum;
				}
			}
		}
		Console.WriteLine("The greatest sum in array is : {0}.",sum);
	}
}