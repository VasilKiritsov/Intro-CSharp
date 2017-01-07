using System;

class kInNArr
{
	static void Main()
	{
		int sum = 0;
		Console.WriteLine("Enter end of array \"n\" : ");
		int n = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter elements \"k\" in array : ");
		int k = int.Parse(Console.ReadLine());
		int[] arr = new int[n];
		for(int i=0; i<n; i++)
		{
			Console.Write("Element {0} : ",i);
			arr[i] = int.Parse(Console.ReadLine());
		}
		Array.Sort(arr,(a,b) => b.CompareTo(a));
		for (int i = 0; i < k; i++)
		{
			sum += arr[i];
		}
		Console.WriteLine("The biggest sum of {1} elements is {0}.",sum,k);
	}
}