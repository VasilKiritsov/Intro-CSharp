using System;

class lowHight
{
	static void Main()
	{
		Console.WriteLine("Please insert lenght : ");
		int lenght = int.Parse(Console.ReadLine());
		int lowest =0;
		int highest=0;
		for (int i=0;i<lenght;i++)
		{
			
			Console.WriteLine("Enter number : ");
			int input = int.Parse(Console.ReadLine());
			if (i==0)
			{
				lowest=highest=input;
			}		
			else
			{
				if(lowest>input)
				{
					lowest=input;
				}
				if(highest<input)
				{
					highest=input;
				}
			}
			Console.WriteLine("Lowest number is {0} highest is : {1}",lowest,highest);
		}
	}
}