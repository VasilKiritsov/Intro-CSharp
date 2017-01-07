using System;

class simpleNumber
{
	static void Main()
	{
		Console.WriteLine("Please enter number \"n\" : ");
		int n = int.Parse(Console.ReadLine());
		bool isPrime = true;
		if (n > 2)
        for (int i = 2; i <= Math.Ceiling(Math.Sqrt(n)); ++i)
        {
            if (n % i == 0) isPrime = false;
        }
		Console.WriteLine("{0} is prime?: {1}", n, isPrime);
	}
}