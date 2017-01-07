using System;

class rootsOfQE
{
	static void Main()
	{
		Console.WriteLine("Enter parameter \"a\" : ");
		double a = double.Parse(Console.ReadLine());
		Console.WriteLine("Enter parameter \"b\" : ");
		double b = double.Parse(Console.ReadLine());
		Console.WriteLine("Enter parameter \"c\" : ");
		double c = double.Parse(Console.ReadLine());
		double D = (b*b) - (4*a*c);
		if (D==0)
		{
			double x1 = (-(b))/(2*a);
			Console.WriteLine("D={0}=0, the quadratic equation have roots : X1=X2={1}",D,x1);
		}
		else if (D>0)
		{
			double x2 = (-(b) + (Math.Sqrt(D)))/(2*a);
			double x3 = (-(b) - (Math.Sqrt(D)))/(2*a);
			Console.WriteLine("D={0}>0, the quadratic equation have roots : X1={1} and X2={2} .",D,x2,x3);
		}
		else 
		{
			Console.WriteLine("The quadratic equation have no real roots.");
		}
	}
}