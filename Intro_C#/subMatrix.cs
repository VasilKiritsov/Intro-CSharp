using System;

class subMatrix
{
	static void Main()
	{
		int sum = -1000;
		int row = 0;
		int col = 0;
		Console.WriteLine("Enter size \"n\" : ");
		int n = Int32.Parse(Console.ReadLine());
		Console.WriteLine("Enter width \"m\" : ");
		int m = Int32.Parse(Console.ReadLine());
		int[,] arr = new int[n, m];
        for(int i = 0; i < n; i++)
		{
                for (int j = 0; j < m; j++)
                {
                    Console.Write("Arr [{0}][{1}] = ", i, j);
                    arr[i, j] = Int32.Parse(Console.ReadLine());
                }            
		}
            for (int tempRow = 0; tempRow < arr.Length - 2; tempRow++)
			{
                for (int tempCol = 0; tempCol < arr.GetLength(0) - 2; tempCol++)
                {
                    int tempSum = arr[row, col] + arr[row, col + 1] + arr[row, col + 2] +
                        arr[row + 1, col] + arr[row + 1, col + 1] + arr[row + 1, col + 2] +
                        arr[row + 2, col] + arr[row + 2, col + 1] + arr[row + 2, col + 2];

                    if (tempSum > sum)
                    {
                        row = tempRow;
                        col = tempCol;
                        sum = tempSum;
                    }
                }
			}
            Console.WriteLine("Result");
            Console.WriteLine("{0} {1} {2}", arr[row, col], arr[row, col + 1], arr[row, col + 2]);
            Console.WriteLine("{0} {1} {2}", arr[row + 1, col], arr[row + 1, col + 1], arr[row + 1, col + 2]);
            Console.WriteLine("{0} {1} {2}", arr[row + 2, col], arr[row + 2, col + 2], arr[row + 2, col + 2]);
            Console.WriteLine("The maximum sum is {0}.", sum);
	}
}