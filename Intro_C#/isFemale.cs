using System;

class isFemale
{
    static void Main()
    {
        bool isFamele;
        Console.WriteLine("What is your name (type \"Vasil\" or \"Gabriela\"): ");
        string myName = Console.ReadLine();
 
        if (myName == "Gabriela")
        {
            isFamele = true ;
			Console.WriteLine("Yes, she is beautiful girl");
        }
        else
        {
            isFamele = false;			
			Console.WriteLine("No, he is her lover");
        }
		Console.WriteLine("Are you female: " + isFamele);
    }
}