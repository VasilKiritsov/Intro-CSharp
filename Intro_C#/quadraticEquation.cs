using System;

class quadraticEquation
{
	static void Main()
	{
		
		Console.WriteLine("Please parameter number \"a\" : ");
		int a = int.Parse(Console.ReadLine());
		Console.WriteLine("Please parameter number \"b\" : ");
		int  b = int.Parse(Console.ReadLine());
		Console.WriteLine("Please enter parameter \"c\" : ");
		int c = int.Parse(Console.ReadLine());
		Console.WriteLine("{0}x*x+{1}x+{2}=0",a,b,c);
		double D = b*b - 4*a*c;
		if (D<0)
		{
		Console.WriteLine("D={0}, the QuadraticEquation have no real roots.",D);
		}
		else if (D==0)
		{
			double x1=(-b/(2*a));
		Console.WriteLine("D={0}, X1=X2 = {1}",D,x1);
		}
		else
		{
			double x1 = (-b + Math.Sqrt(D))/(2*a);
			double x2 = (-b + Math.Sqrt(D))/(2*a);
			Console.WriteLine("D={0},X1={1},X2={2}",D,x1,x2);
		}
	}
}