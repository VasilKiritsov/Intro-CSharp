using System;

class multiplicationABC
{
	static void Main()
	{
		int a,b,c;
		Console.WriteLine("Enter number \"a\" : ");
		bool resulta = int.TryParse(Console.ReadLine(), out a);
		Console.WriteLine("Enter number \"b\" : ");
		bool  resultb = int.TryParse(Console.ReadLine(), out b);
		Console.WriteLine("Enter number \"c\" : ");
		bool resultc = int.TryParse(Console.ReadLine(), out c);
		if (a>0 && b>0 && c>0)
		{
			Console.WriteLine("The product of a,b and c is : +");
		}
		else if ((a>0) && (b<0&&c<0))
		{
			Console.WriteLine("The product of a,b and c is : +");
		}
		else if ((b>0) && (a<0&&c<0))
		{
			Console.WriteLine("The product of a,b and c is : +");
		}
		else if ((c>0) && (a<0&&b<0))
		{
			Console.WriteLine("The product of a,b and c is : +");
		}
		else if (a<0 && b<0 && c<0)
		{
			Console.WriteLine("The product of a,b and c is : -");
		}
		else if ((a<0) && (b>0&&c>0))
		{
			Console.WriteLine("The product of a,b and c is : -");
		}
		else if ((b<0) && (a>0&&c>0))
		{
			Console.WriteLine("The product of a,b and c is : -");
		}
		else if ((c<0) && (a>0&&b>0))
		{
			Console.WriteLine("The product of a,b and c is : -");
		}
		else
		{
			Console.WriteLine("The product of a,b and c is : \"0\"");
		}
	}
}