using System;

public class Rectangle
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Please Enter The Length and Width\n");
		double length = double.Parse(Console.ReadLine());
		double width = double.Parse(Console.ReadLine());
		double area = length * width;
		double perimeter = 2 * (length + width);

		Console.WriteLine("\nArea of Rectangle:-  " + area + "\nPerimeter of Rectangle:-  " + perimeter);

	}
}