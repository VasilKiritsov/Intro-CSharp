using System;

class cards
{
	static void Main()
	{
		Console.WriteLine("Deck of cards have 52 kards : ");
		for (int i=1;i<=4;i++)
		{
			string stri = Convert.ToString(i);
			switch (i)
			{
				case 1 : stri = "Club"; break;
				case 2 : stri = "Diamond"; break;
				case 3 : stri = "Heart"; break;
				case 4 : stri = "Spade"; break;
				default : break;
			}
			for (int j=2;j<=14;j++)
			{
				string strj = Convert.ToString(j);
				switch(j)
				{
					case 1 : strj = "One";break;
					case 2 : strj = "Two";break;
					case 3 : strj = "Three";break;
					case 4 : strj = "Four";break;
					case 5 : strj = "Five";break;
					case 6 : strj = "Six";break;
					case 7 : strj = "Seven";break;
					case 8 : strj = "Eight";break;
					case 9 : strj = "Nine";break;
					case 10 : strj = "Ten";break;
					case 11 : strj = "Jack";break;
					case 12 : strj = "Queen";break;
					case 13 : strj = "King";break;
					case 14 : strj = "Ace";break;
					default : break;
				}
				Console.WriteLine("{0} of {1}",strj,stri);
			}
		}
	}
}