using System;

class rectanglePandS

{
	static void Main()
	{
	 Console.WriteLine("Please enter rectangle side " + '"' + "a" + '"' + " " + ':');
	 int a = int.Parse(Console.ReadLine());
	 Console.WriteLine("Please enter trapezoid side " + '"' + "h" + '"' + " " + ':');
	 int h  = int.Parse(Console.ReadLine());
	 int S = a*h;
	 int P = (a*a)+(h*h);
	 Console.WriteLine("The rectanle face is : " + S);
	 Console.WriteLine("The rectangle perimeter is : " + P);
	}
}