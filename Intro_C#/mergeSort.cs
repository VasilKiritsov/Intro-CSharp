using System;

class mergeSort
{
	public static void MergeSort(int[] input, int startIndex, int endIndex)
	{
		int mid;
		
		if(endIndex > startIndex)
		{
			mid = (endIndex + startIndex)/2;
			MergeSort(input, startIndex, mid);
			MergeSort(input, (mid + 1), endIndex);
			Merge(input, startIndex, (mid + 1), endIndex);
		}
	}
	public static void Merge(int[] input, int left, int mid, int right)
	{
		int[] temp = new int[input.Length];
		int leftEnd;
		int tempPos;
		int lengthInput;
		
		leftEnd = mid - 1;
		tempPos = left;
		lengthInput = right - left + 1;
		
		while((left <= leftEnd) && (mid <= right))
		{
			if(input[left] <= input[mid])
			{
				temp[tempPos++] = input[left++];
			}
			else
			{
				temp[tempPos++] = input[mid++];
			}
		}
		while(left <= leftEnd)
		{
			temp[tempPos++] = input[left++];
		}
		while(mid <= right)
		{
			temp[tempPos++] = input[mid++];
		}
		for(int i = 0; i < lengthInput; i++)
		{
			input[right] = temp[right];
			right--;
		}
	}
	static void Main()
	{
		Console.WriteLine("Please enter length of array : ");
		int input = int.Parse(Console.ReadLine());
		int[] arr = new int[input];
		for(int i = 0; i < input; i++)
		{
			Console.Write("element {0} : ",i);
			arr[i] = int.Parse(Console.ReadLine());
		}
		MergeSort(arr,0,arr.Length -1);
		for(int i = 0; i < arr.Length; i++)
		{
			Console.WriteLine(arr[i]);
		}
	}
}
		
			
		
		
				