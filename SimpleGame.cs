using System;
public class SimpleGame
{
	static void Main(string[] args)
	{
		Console.WriteLine("Game to find Square or a Rectangle");
		Console.WriteLine("Plese Enter Length and Width\n");
		double length = double.Parse(Console.ReadLine());
		double width = double.Parse(Console.ReadLine());

		if (length == width)
		{
			Console.WriteLine("This is a Square!");
		}
		else
		{
			Console.WriteLine("This is a Rectangle.");
		}

	}
}