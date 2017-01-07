using System;

class seriesArr
{
	static void Main()
	{
		Console.WriteLine("Enter length for first array \"n\" : ");
		int n = int.Parse(Console.ReadLine());
		int[] arr = new int[n];
		for (int i = 0;i < n;i++)
		{
			Console.Write("Enter element {0} ",i);
			arr[i] = int.Parse(Console.ReadLine());
		}
		int start = 0;
		int count = 1;
		int maxStart = 0;
		int maxCount = 1;
		for (int i = 1; i < n; i++)
		{
			if (arr[i] == arr[i-1])
			{
				count++;
				if (count > maxCount)
				{
					maxCount = count;
					maxStart = start;
				}
			}
			else
			{
				count = 1;
				start = i;
			}
		}
		Console.Write("The larger line in array is : ");
		for (int i = maxStart ; i < maxStart + maxCount; i++)
		{
			Console.Write("{0} ",arr[i]);
		}
	}
}