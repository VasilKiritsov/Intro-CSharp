using System;

class quadMatrix
{
	static void Main()
	{
		Console.WriteLine("Enter size \"n\" : ");
		int n = int.Parse(Console.ReadLine());
		int[,] arr = new int[n,n];
		arr[n-1,0] = 1;
		int count = 1;
		for (int row = n - 2; row >= 0; row--)
		{
			arr[row,0] = arr[row+1,0] + count;
			int newRow = row;
			for (int diagonal = 1; diagonal <= count; diagonal++)
			{
				arr[newRow+1,diagonal] = arr[newRow,diagonal-1] + 1;
				newRow++;
			}
			count++;
		}
		arr[0,n-1] = n*n;
		int diagonalLength = 2;
		int posX = 1;
		int posY = n-1;
		int prevX = 0;
		int prevY = n-1;
		for (int i = 1; i < count - 1; i++)
		{
			for (int j = 1; j <= diagonalLength; j++)
			{
				arr[posX,posY] = arr[prevX,prevY] - 1;
				prevX = posX;
				prevY = posY;
				posX--;
				posY--;
			}
			diagonalLength++;
			posX = i + 1;
			posY = n - 1;
		}
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
				Console.Write("{0,4}",arr[i,j]);
				}
				Console.WriteLine();
			}
	}
}