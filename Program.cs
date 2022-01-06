using System;

namespace TestCode1
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int i = 1; i < 10; i++)
			{
				for (int j = 0; j < i; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
		}
	}
}