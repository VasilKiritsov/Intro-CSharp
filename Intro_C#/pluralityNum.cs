using System;

class pluralityNum
{
	static void Main()
	{
		Console.WriteLine("Enter parameter \"first\" : ");
		int first = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter parameter \"second\" : ");
		int second = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter parameter \"thrid\" : ");
		int thrid = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter parameter \"fourth\" : ");
		int fourth = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter parameter \"fifth\" : ");
		int fifth = int.Parse(Console.ReadLine());
			if (first + second ==0)
			{
				Console.WriteLine("Plurality have parameters with sum 0, {0}+{1}",first,second);
			}
			else if (first + thrid ==0)
			{
				Console.WriteLine("Plurality have parameters with sum 0, {0}+{1}",first,thrid);
			}
			else if (first + fourth ==0)
			{
				Console.WriteLine("Plurality have parameters with sum 0, {0}+{1}",first,fourth);
			}
			else if (first + fifth ==0)
			{
				Console.WriteLine("Plurality have parameters with sum 0, {0}+{1}",first,fifth);
			}
			else if (second + thrid ==0)
			{
				Console.WriteLine("Plurality have parameters with sum 0, {0}+{1}",second,thrid);
			}
			else if (second + fourth ==0)
			{
				Console.WriteLine("Plurality have parameters with sum 0, {0}+{1}",second,fourth);
			}
			else if (second + fifth ==0)
			{
				Console.WriteLine("Plurality have parameters with sum 0, {0}+{1}",second,fifth);
			}
			else if (thrid + fourth ==0)
			{
				Console.WriteLine("Plurality have parameters with sum 0, {0}+{1}",thrid,fourth);
			}
			else if (thrid + fifth ==0)
			{
				Console.WriteLine("Plurality have parameters with sum 0, {0}+{1}",thrid,fifth);
			}
			else if (fourth + fifth ==0)
			{
				Console.WriteLine("Plurality have parameters with sum 0, {0}+{1}",fourth,fifth);
			}
			else if (first + second + thrid ==0)
			{
				Console.WriteLine("Plurality have parameters with sum 0, {0}+{1}+{2}",first,second,thrid);
			}
			else if (first + second + fourth ==0)
			{
				Console.WriteLine("Plurality have parameters with sum 0, {0}+{1}+{2}",first,second,fourth);
			}
			else if (first + second + fifth==0)
			{
				Console.WriteLine("Plurality have parameters with sum 0, {0}+{1}+{2}",first,second,fifth);
			}
			else if (first + thrid + fourth==0)
			{
				Console.WriteLine("Plurality have parameters with sum 0, {0}+{1}+{2}",first,thrid,fourth);
			}
			else if (first + thrid + fifth==0)
			{
				Console.WriteLine("Plurality have parameters with sum 0, {0}+{1}+{2}",first,thrid,fifth);
			}
			else if (first + fourth + fifth==0)
			{
				Console.WriteLine("Plurality have parameters with sum 0, {0}+{1}+{2}",first,fourth,fifth);
			}
			else if (second + thrid + fourth==0)
			{
				Console.WriteLine("Plurality have parameters with sum 0, {0}+{1}+{2}",second,thrid,fourth);
			}
			else if (second + thrid + fifth==0)
			{
				Console.WriteLine("Plurality have parameters with sum 0, {0}+{1}+{2}",second,thrid,fifth);
			}
			else if (thrid + fourth + fifth==0)
			{
				Console.WriteLine("Plurality have parameters with sum 0, {0}+{1}+{2}",thrid,fourth,fifth);
			}
			else if (first + second + thrid + fourth ==0)
			{
				Console.WriteLine("Plurality have parameters with sum 0, {0}+{1}+{2}+{3}",first,second,thrid,fourth);
			}
			else if (second + thrid+fourth+fifth==0)
			{
				Console.WriteLine("Plurality have parameters with sum 0, {0}+{1}+{2}+{3}",second,thrid,fourth,fifth);
			}
			else if (first + second + thrid + fourth + fifth ==0)
			{
				Console.WriteLine("The plurality sum is 0");
			}
			else 
			{
				Console.WriteLine("The plurality don`t have parameters with sum 0");
			}
	}		
}
