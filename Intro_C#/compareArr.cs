using System;

class compareArr
{
	static void Main()
	{
		Console.WriteLine("Enter length for first array \"n\" : ");
		int n = int.Parse(Console.ReadLine());
		int[] nArr = new int[n];
		for (int nIndex = 0;nIndex < n;nIndex++)
		{
			Console.Write("Enter element {0} ",nIndex);
			nArr[nIndex] = int.Parse(Console.ReadLine());
		}
		Console.WriteLine("Enter length for seccond array \"m\" : ");
		int m = int.Parse(Console.ReadLine());
		int[] mArr = new int[m];
		for (int mIndex = 0;mIndex < m; mIndex++)
		{
			Console.Write("Enter element {0} ",mIndex);
			mArr[mIndex] = int.Parse(Console.ReadLine());
		}
		if (n != m)
		{
			Console.WriteLine("The arrays are different!");
		}
		else
		{
			for (int i= 0,j=0;i < nArr.Length;i++,j++)
			{
				if (i!=j)
				{
					Console.WriteLine("The arrays are different!");
					break;
				}
			}
				Console.WriteLine("The arrays are equal!");
		}
	}
}