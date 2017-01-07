using System;

class growSeriesArr
{
	static void Main()
	{
		int count = 1;
		int bestIndex;
		int bestCount;
		Console.WriteLine("Enter the array length \"n\" : ");
		int n = int.Parse(Console.ReadLine());
		int[] arr = new int[n];
		int[] result = new int[n];
		for (int i=0; i  < n; i++)
		{
			Console.Write("element {0} : ",i);
			arr[i] = int.Parse(Console.ReadLine());
		}
		for (int i=0 ; i < n; i++)
		{
			int[] bestResult = new int[n];
			bestIndex = bestCount = 1;
			bestResult[0] = arr[i];
			for (int j = i + 1; j < n; j++)
			{
				if (arr[j] > bestResult[bestIndex - 1])
				{
					bestResult[bestIndex] = arr[j];
					bestIndex++;
					bestCount++;
				}
				else if (bestIndex > 1 && arr[j] > bestResult[bestIndex - 2] && arr[j] < bestResult[bestIndex - 1])
				{
					bestResult[bestIndex - 1] = arr[j];
				}
			}
			if (count < bestCount)
			{
				count = bestCount;
				result = bestResult;
			}
		}
		Console.Write("Max growing number series is : ");
		for (int i = 0; i < count; i++)
		{
			Console.WriteLine("{0},",result[i]);
		}
	}
}
