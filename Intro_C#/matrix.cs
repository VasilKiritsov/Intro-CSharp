using System;

class matrix
{
	static void Main()
	{
		Console.WriteLine("Enter number \"n\" : ");
		int n = int.Parse(Console.ReadLine());
		int row=1;
		int column=0;
		for (column = 0; column < n; column++)
		{
			for (row = 1+column; row <= n+column; row++)
			{
				if (row<10)
				{
					Console.Write(" ");
				}
				Console.Write(row+" ");
			}
			Console.WriteLine();
		}
	}
}