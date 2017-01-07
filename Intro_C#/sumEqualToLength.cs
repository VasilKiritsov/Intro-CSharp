using System;

class sumEqualToLength
{
	static void Main()
	{
		int sum = 0;
		int start = 0;
		int end = 0;
		bool result = false;
		Console.WriteLine("Enter the length of array \"n\" : ");
		int n = int.Parse(Console.ReadLine());
		int[] arr = new int[n];
		for (int i = 0; i < n; i++)
		{
			Console.Write("element {0} : ",i);
			arr[i] = int.Parse(Console.ReadLine());
		}
		for (int i = 0; i < n-1; i++)
		{
			sum =arr[i];
			for (int j = i+1; j < n; j++)
			{
				sum += arr[j];
				if (sum == n)
				{
					start = i;
					end = j;
					result = true;
					break;
				}
			}
			if (result)
			{
				break;
			}
		}
		if (result)
		{
			for (int i = start; i <= end; i++)
			{
				Console.Write("{0},",arr[i]);
			}
		}
		else
		{
			Console.WriteLine("Sum not found!");
		}
	}
}