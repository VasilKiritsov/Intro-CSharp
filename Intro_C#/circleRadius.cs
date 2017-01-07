using System;

class circleRadius

{
	static void Main()
	{
		Console.WriteLine("Please enter radius \"r\" for circle \"K\" : ");
		int r = int.Parse(Console.ReadLine());
		double Pi = Math.PI;
		double P = Pi*r*r;
		double S = 2*Pi*r;
		Console.WriteLine("The circle \"K\" face is : " + S);
		Console.WriteLine("The circle \"K\" perimeter is : " + P);
	}
}