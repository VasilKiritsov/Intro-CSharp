using System;

class growingArr
{
	static void Main()
	{
		int minNum = 0;
		int temp = 1;
		Console.WriteLine("Enter the length of array \"n\" : ");
		int n = int.Parse(Console.ReadLine());
		int[] arr = new int [n];
		for (int i = 0; i < n; i++)
		{
			Console.Write("Element {0} : ",i);
			arr[i] = int.Parse(Console.ReadLine());
		}
		for(int j = 0; j < n - 1; j++)
		{
			minNum = j;
			for (int i = j+1; i < n; i++)
			{
				if (arr[i] < arr[minNum])
				{
					minNum = i;
				}
				if (minNum != j)
				{
					temp = arr[j];
					arr[j] = arr[minNum];
					arr[minNum] = temp;
				}
			}
			for (int i = 0; i < n; i++)
			{
				Console.Write("{0} ",arr[i]);
			}
		}
	}
}