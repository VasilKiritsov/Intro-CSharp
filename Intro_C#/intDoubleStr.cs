using System;

class intDoubleStr
{
	static void Main()
	{
		Console.WriteLine("Make your choice : type1 = integer, type2 = double, type3 = string.");
		Console.WriteLine("For type1, insert \"1\", for type2, insert \"2\" and for type3 \"3\" : ");
		int type = int.Parse(Console.ReadLine());
		switch (type)
		{
			case 1: 
				Console.WriteLine("Enter real number \"a\" : ");
				int a = int.Parse(Console.ReadLine());
				int result1 = a+1;
				Console.WriteLine("a={0}, and a+1={1}",a,result1); break;
			case 2:
				Console.WriteLine("Enter fractional number \"b\" : ");
				double b = double.Parse(Console.ReadLine());
				double result2 = b+1;
				Console.WriteLine("b={0}, and b+1={1}",b,result2); break;
			case 3:
				Console.WriteLine("Enter some \"text\" : ");
				string text = Console.ReadLine();
				string result3 = text + '*';
				Console.WriteLine("Your string is : {0}, and pointed is : {1}",text,result3); break;
			default: 
				Console.WriteLine("Invalid format"); break;
		}
	}
}