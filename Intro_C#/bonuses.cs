using System;

class bonuses
{
	static void Main()
	{
		Console.WriteLine("How mutch point you got?" + " " + "Enter your points : ");
		int points = int.Parse(Console.ReadLine());
		switch (points)
		{
			case 1 : 
				int points1 = 1*10;
				Console.WriteLine("You got BONUS! Your points got x10 : {0}",points1); break;
			case 2 : 
				int points2 = 2*10;
				Console.WriteLine("You got BONUS! Your points got x10 : {0}",points2); break;
			case 3 : 
				int points3 = 3*10;
				Console.WriteLine("You got BONUS! Your points got x10 : {0}",points3); break;
			case 4 : 
				int points4 = 4*100;
				Console.WriteLine("You got BONUS! Your points got x100 : {0}",points4); break;
			case 5 : 
				int points5 = 5*100;
				Console.WriteLine("You got BONUS! Your points got x100 : {0}",points5); break;
			case 6 : 
				int points6 = 6*100;
				Console.WriteLine("You got BONUS! Your points got x100 : {0}",points6); break;
			case 7 : 
				int points7 = 7*1000;
				Console.WriteLine("You got BONUS! Your points got x1000 : {0}",points7); break;
			case 8 : 
				int points8 = 8*1000;
				Console.WriteLine("You got BONUS! Your points got x1000 : {0}",points8); break;
			case 9 : 
				int points9 = 9*1000;
				Console.WriteLine("You got BONUS! Your points got x1000 : {0}",points9); break;
			default :
				Console.WriteLine("Can`t have \"0\" or more then \"9\" points!!!");break;
		}
	}
}