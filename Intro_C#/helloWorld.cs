using System;

class helloWorld
{
	static void Main()
	{
		string word1 = "Hello";
		string word2 = "World";
		object expression1 = (word1 + " " + word2);
		object expression2 = (word1 + word2);
		Console.WriteLine(expression1);
		Console.WriteLine(expression2);
	}
}