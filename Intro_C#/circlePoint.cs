using System;

class circlePoint

{
	static void Main()
	{
		Console.WriteLine("The circle have coordinates K((0,0),5), center (0,0) and radius 5..");
		Console.WriteLine("Please enter coordinates for point O ... X and Y :");
		int x = int.Parse(Console.ReadLine());
		int y = int.Parse(Console.ReadLine());
		bool pitT = (x*x) + (y*y) ==25;
		if (pitT)
		{
			Console.WriteLine("The point O is in circle K" + '.');
		}
		else
		{
			Console.WriteLine("The point O isn`t in circle K" + '.');
		}
	}
}