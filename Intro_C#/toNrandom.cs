using System;

class toNrandom
{
	static void Main(string[] args)
	{
		Random rnd = new Random();
		int temp;
		int rndNum;
		Console.WriteLine("Enter number \"n\" : ");
		int n = int.Parse(Console.ReadLine());
	 	int[] arr = new int[n];
		for (int i=0;i<arr.Length;i++)
		{
			arr[i]=i;
		}
		foreach (int i in arr)
		{
			rndNum = rnd.Next(0,n);
			temp = arr[i];
			arr[i] = arr[rndNum];
			arr[rndNum] = temp;
		}
		foreach (int i in arr)
		{
			Console.WriteLine(arr[i]);
		}
	}
}