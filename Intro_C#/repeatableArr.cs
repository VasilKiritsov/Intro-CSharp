using System;

class repeatableArr
{
	static void Main()
	{
		int count = 0;
		int tempCount = 1;
		int foundNum = 0;
		Console.WriteLine("Enter length of array \"n\" : ");
		int n = int.Parse(Console.ReadLine());
		int[] arr = new int[n];
		for (int i = 0; i < n; i++)
		{
			Console.Write("element {0} : ",i);
			arr[i] = int.Parse(Console.ReadLine());
		}
		Array.Sort(arr);
		for (int i=0; i < n-1; i++)
		{
			if(arr[i] == arr[i+1])
			{
				tempCount++;
			}
			else
			{
				tempCount = 1;
			}
			if(tempCount >count)
			{
				count = tempCount;
				foundNum = arr[i];
			}
		}
		Console.WriteLine("In array {0} has {1} times repeat.",foundNum,count);
	}
}