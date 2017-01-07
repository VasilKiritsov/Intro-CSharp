using System;

class trapezoidFace

{
	static void Main()
	{
	 Console.WriteLine("Please enter trapezoid side " + '"' + "a" + '"' + " " + ':');
	 int a = int.Parse(Console.ReadLine());
	 Console.WriteLine("Please enter trapezoid side " + '"' + "b" + '"' + " " + ':');
	 int b  = int.Parse(Console.ReadLine());
	 Console.WriteLine("Please enter trapezoid height " + '"' + "h" + '"' + " " + ':');
	 int h = int.Parse(Console.ReadLine());
	 int S = ((a+b)/2)*h;
	 Console.WriteLine("The trapezoid face is : " + S);
	}
}