using System;

class arrPermutations
{
	public static int n;
	static void Main()
	{
		Console.WriteLine("Please enter length of array \"k\" : ");
		int k = int.Parse(Console.ReadLine());
		int[] arr = new int[k];
		
		Console.WriteLine("Please enter number \"n\" : ");
		n = int.Parse(Console.ReadLine());
		recSolution(arr,0);
	}
	
	static void recSolution(int[]array, int index)
	{
		if (index != array.Length)
		{
			for(int i = 0; i <= n; i++)
			{
				array[index] = i;
				recSolution(array, index + 1);
			}
		}
		else
		{
			for(int i = 0; i < array.Length; i++)
			{
				Console.Write(array[i] + " ");
			}
			Console.WriteLine();
		}
	}
}