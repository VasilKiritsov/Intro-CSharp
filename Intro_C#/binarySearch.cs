using System;

class binarySearch
{
	static void Main()
	{
		Console.WriteLine("Enter length of the array \"n\" : ");
		int n = int.Parse(Console.ReadLine());
		int[] arr = new int[n];
		for (int i = 0; i < n; i++)
		{
			Console.Write("element {0} : ",i);
			arr[i] = int.Parse(Console.ReadLine());
		}
		Console.WriteLine("Enter number, you search : ");
		int num = int.Parse(Console.ReadLine());
		int index = Array.BinarySearch(arr,num);
		if(index > 0)
		{
			Console.WriteLine("your number is in array : {0} index.",index);
		}
		else
		{
			Console.WriteLine("your number was not found!");
		}
	}
}