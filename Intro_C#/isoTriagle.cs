using System;

class isoscelesTriangle
{
	static void Main()
	{
		int copyrightSymbol = 0x00A9;
		char c = (char)copyrightSymbol;
		Console.WriteLine("     {0}", c);
		Console.WriteLine("    {0}{0}{0}", c);
		Console.WriteLine("   {0}{0}{0}{0}{0}", c);
		Console.WriteLine("  {0}{0}{0}{0}{0}{0}{0}", c);
		Console.WriteLine(" {0}{0}{0}{0}{0}{0}{0}{0}{0}", c);
		Console.WriteLine("{0}{0}{0}{0}{0}{0}{0}{0}{0}{0}{0}", c);
	}
}