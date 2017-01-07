using System;

class hexadecimal
{
	static void Main()
	{
		Console.WriteLine("Enter hexadecimal number \"a\" : ");
		byte a = byte.Parse(Console.ReadLine());
		string dec = Convert.ToString(a,16);
		Console.WriteLine("hexadecimal is {0}.",dec);
	}
}