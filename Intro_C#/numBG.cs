using System;

class numBG
{
	static void Main()
	{
		Console.WriteLine("Enter number between 0...999 : ");
		int num = int.Parse(Console.ReadLine());
		int hunderts = num/100;
		int tens = num/10%10;
		int ones = num%10;
		string s= "";
		if ((0<=num) && (num<1000))
		{
			switch(hunderts)
			{
				case 1 : s ="Сто"; break;
				case 2 : s ="Двеста"; break;
				case 3 : s ="Триста"; break;
				case 4 : s ="Четиристотин"; break;
				case 5 : s ="Петстотин"; break;
				case 6 : s ="Шестстотин"; break;
				case 7 : s ="Седемстотин"; break;
				case 8 : s ="Осемстотин"; break;
				case 9 : s ="Деветстотин"; break;
				default: break;
			}
		if ((hunderts>0) && (tens ==1 || tens >1 && ones ==0 || tens ==0 && ones >0))
		{
			s += " и ";
		}
		else if (tens >0 && tens + ones >0)
		{
			s += " ";
		}
		switch (tens)
		{
			case 1 :
				switch(ones)
				{
					case 0 : s +="Десет"; break;
					case 1 : s +="Единадесет"; break;
					case 2 : s +="Дванадесет"; break;
					case 3 : s +="Тринадесе"; break;
					case 4 : s +="Четиринадесет"; break;
					case 5 : s +="Петнадесет"; break;
					case 6 : s +="Шестнадесет"; break;
					case 7 : s +="Седемнадесет"; break;
					case 8 : s +="Осемнадесет"; break;
					case 9 : s +="Деветнадесет"; break;
					default : break;
				}
				break;
			case 2 : s +="Двадесет"; break;
			case 3 : s +="Тридесет"; break;
			case 4 : s +="Четиридесет"; break;
			case 5 : s +="Петдесет"; break;
			case 6 : s +="Шестдесет"; break;
			case 7 : s +="Седемдесет"; break;
			case 8 : s +="Осемдесет"; break;
			case 9 : s +="Деведесет"; break;
			default : break;
		}
		if (tens >1 && ones >0)
		{
			s += " и ";
		}
		if (tens !=1)
		{
			switch (ones)
			{
				case 0 : if (tens ==0 && ones ==0)
				{
					s += "Нула";
				}
				break;
				case 1 : s +="Едно"; break;
				case 2 : s +="Две"; break;
				case 3 : s +="Три"; break;
				case 4 : s +="Четири"; break;
				case 5 : s +="Пет"; break;
				case 6 : s +="Шест"; break;
				case 7 : s +="Седем"; break;
				case 8 : s +="Осем"; break;
				case 9 : s +="Девет"; break;
				default : Console.WriteLine("Invalid number"); break;
			}
		}
	
	}Console.WriteLine("Your number is : {0}",s);
	}
}
		
