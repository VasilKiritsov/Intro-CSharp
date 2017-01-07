using System;

class thirdFigure

{
	static void Main()
	{
		Console.WriteLine("Please enter number 'a' :");
		int a = int.Parse(Console.ReadLine());
		double a1 = a/100;
		double a2 = a1%10;
		
		if (a2==7)
		{
		Console.WriteLine("The thrid figure of" + " " + a + " " + "is 7.");
		}
		else 
		{
		Console.WriteLine("The thrid figure of" + " " + a + " " + "isn`t 7.");
		}
	}
}