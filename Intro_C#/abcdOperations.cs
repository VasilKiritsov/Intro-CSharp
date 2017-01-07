using System;

class abcdOperations

{
	static void Main()
	{	
		Console.WriteLine("Please enter four numerical number : ");
		int abcd = int.Parse(Console.ReadLine());
		int a = abcd/1000;
		int b = (abcd/100)%10;
		int c = (abcd/10)%10;
		int d = abcd%10;
		int sum = a+b+c+d;
		int diff = a-b-c-d;
		int dcba = (d*1000) + (c*100) + (b*10) + a;
		int dabc = (d*1000) + (a*100) + (b*10) + c;
		int acbd = (a*1000) + (c*100) + (b*10) + d;
		Console.WriteLine("Sum a+b+c+d is : " + sum);
		Console.WriteLine("Difference a-b-c-d is : " + diff);
		Console.WriteLine("Reverse order of abcd is : " + dcba);
		Console.WriteLine("dabc is : " + dabc);
		Console.WriteLine("acbd is : " + acbd);
	}
}