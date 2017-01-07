using System;

class partition7and5

{
	static void Main()
	{
		Console.WriteLine("Please enter number 'a' :");
		int a = int.Parse(Console.ReadLine());
		double b = a%5;
		double c = a%7;
		bool par = (b==0&&c==0);
		
		if (par=(b==0&&c==0))
		{
		Console.WriteLine("Number" + " " + a + " " + "is devided on 5 and 7.");
		}
		else
		{
		Console.WriteLine("Number" + " " + a + " " + "is incorrect!");
		}
	}
}
