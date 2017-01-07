using System;

class latinAlphabet
{
	static void Main()
	{
		char[] alphabet = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
		Console.WriteLine("Enter a word : ");
		char[] words = (Console.ReadLine()).ToCharArray();
		for (int i = 0; i < words.Length; i++)
		{
			for (int j = 0; j < alphabet.Length; j++)
			{
				if (words[i] == alphabet[j])
				{
					Console.Write("{0} ",j);
				}
			}
		}
	}
}
