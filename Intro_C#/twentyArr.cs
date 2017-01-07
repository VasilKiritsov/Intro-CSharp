using System;

class twentyArr
{
	static void Main()
	{
		int[] twenty = new int[20];
		Console.Write("The result for every number of array multiplied on 5 is : ");
		for (int index = 0;index < twenty.Length;index++)
		{
			twenty[index] = 5* index;
			Console.Write(twenty[index] + ", ");
		}
	}
}