using System;

class charArr
{
	static void Main()
	{
		Console.WriteLine("Enter length for first array \"n\" : ");
		int n = int.Parse(Console.ReadLine());
		char[] nArr = new char[n];
		for (int nIndex = 0;nIndex < n;nIndex++)
		{
			Console.Write("Enter element {0} ",nIndex);
			nArr[nIndex] = char.Parse(Console.ReadLine());
		}
		Console.WriteLine("Enter length for seccond array \"m\" : ");
		int m = int.Parse(Console.ReadLine());
		char[] mArr = new char[m];
		for (int mIndex = 0;mIndex < m; mIndex++)
		{
			Console.Write("Enter element {0} ",mIndex);
			mArr[mIndex] = char.Parse(Console.ReadLine());
		}
		if (nArr.Length < mArr.Length)
		{
			Console.WriteLine("The first array is first in lexicographical system");
		}
		else if (nArr.Length > mArr.Length)
		{
			Console.WriteLine("The seccond array is first in lexicographical system");
		}
		else
		{
			for (int i= 0;i < Math.Min(nArr.Length,mArr.Length);i++)
			{
				if (nArr[i] < mArr[i])
				{
					Console.WriteLine("The first array is first in lexicographical system");
					break;
				}
				else if (nArr[i] > mArr[i])
				{
					Console.WriteLine("The seccond array is first in lexicographical system");
					break;
				}
				else if (nArr[i] == mArr[i])
				{
					Console.WriteLine("The arrays are equal in lexicographical system!");
					break;
				}			
			}
		}
	}
}