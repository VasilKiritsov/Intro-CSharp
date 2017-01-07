using System;

class business
{
	static void Main()
	{
		Console.WriteLine("Enter employee first name :");
		string firstName = Console.ReadLine();
		Console.WriteLine("Enter employee family name :");
		string familyName = Console.ReadLine();
		Console.WriteLine("Enter employee age :");
		byte age = byte.Parse(Console.ReadLine());
		Console.WriteLine("Enter employee gender (f or m) :");
		string gender = Console.ReadLine();
		Console.WriteLine("Employee ID number :");
		long idNumber = long.Parse(Console.ReadLine());
		Console.WriteLine("Unique employee number(27560000 to 27569999)");
		int employeeUniqueNumber = int.Parse(Console.ReadLine());
		Console.WriteLine("full employee details :");
		Console.WriteLine("First Name : {0}", firstName);
		Console.WriteLine("Family Name : {0}", familyName);
		Console.WriteLine("Age : {0}", age);
		if (gender == "m")
		{
			Console.WriteLine("Gender : Male");
		}
		else if (gender == "f")
		{
			Console.WriteLine("Gender : Female");
		}
		else
		{
			Console.WriteLine("Wrong Symbol");
		}
		Console.WriteLine("ID number : {0}", idNumber);
		if (employeeUniqueNumber < 27560000)
		{
			Console.WriteLine("Invalid Number");
		}
		else if (employeeUniqueNumber > 27569999)
		{
			Console.WriteLine("Invalid number");
		}
		else
		{
			Console.WriteLine("Unique employee number is : {0}", employeeUniqueNumber);
		}
	}
}