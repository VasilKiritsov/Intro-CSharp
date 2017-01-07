using System;

class par7and5
{
	static void Main()
	{
		Console.WriteLine("Please insert number \"n\" : ");
		int n = int.Parse(Console.ReadLine());
		if (n<35)
			{
				Console.WriteLine("Number doesn`t partition on 5 and 7");
			}
		for (int i=1;i<n;i++)
		{
			if (i%35==0)
			{
				Console.WriteLine("Number with partition on 7 and 5 are : {0}",i);
			}
		}
	}
}