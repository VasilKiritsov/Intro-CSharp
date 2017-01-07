using System;

class quadratMatrix
{
	static void Main()
	{
		Console.WriteLine("Enter height : ");
		int x = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter width : ");
		int y = int.Parse(Console.ReadLine());
		int a = 0;
		for (int i = 1; i <= x; i++)
		{
			Console.Write("{0} ",i);
			a += i;
			for (int j = 1; j < y; j++)
			{
				a += x;
				Console.Write("{0} ",a);
			}
			a = 0;
			Console.WriteLine();
		}
	}
}