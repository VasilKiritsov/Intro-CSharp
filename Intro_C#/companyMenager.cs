using System;

class companyMenager

{
	static void Main()
	{
		Console.WriteLine("Please enter Company name : ");
		string comName = Console.ReadLine();
		Console.WriteLine("Please enter Company adress : ");
		string comAdress = Console.ReadLine();
		Console.WriteLine("Please enter Company phone : ");
		string comPhone = Console.ReadLine();
		Console.WriteLine("Please enter Company fax : ");
		string comFax = Console.ReadLine();
		Console.WriteLine("Please enter Company e-mail : ");
		string comMail = Console.ReadLine();
		Console.WriteLine("Please enter Menager name : ");
		string mName = Console.ReadLine();
		Console.WriteLine("Please enter Menager surname : ");
		string mSurname = Console.ReadLine();
		Console.WriteLine("Please enter Menager phone : ");
		string mPhone = Console.ReadLine();
		Console.WriteLine("Dear user,");
		Console.Write("This Company : {0}," + 
				"adress : {1}, phone : {2}, fax : {3}, e-mail : {4}," +
				"have a Menager : {5} {6} and phone : {7}", comName,comAdress,comPhone,comFax,comMail,mName,mSurname,mPhone,Environment.NewLine);
		Console.WriteLine("Have a nice day!");
		Console.WriteLine("{0} , team and" + " " + "{1} {2}",comName,mName,mSurname);
	}
}