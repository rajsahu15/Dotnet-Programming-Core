using System;

public class SimpleCalculator
{
	public static void Main(string[] args)
	{
		bool flag = true;
		while (flag)
		{
			Console.WriteLine("Please Choose the Operation :");
			Console.WriteLine("1. Addition \t\t 2.Subtraction \n3. Multiplication \t 4.Division\n5. EXIT");
			int input =int.Parse(Console.ReadLine());
			if (input < 1 || input > 5) {
				Console.WriteLine("Invaid Input Please Run Again");
				break;
			}
			if (input == 5) {
				Console.WriteLine("CalculatorProgram Is Exitted Successfully");
				break;
			}
			Console.WriteLine("Please Enter Two Numbers:\n");	
			int number1=int.Parse(Console.ReadLine());
			int number2=int.Parse(Console.ReadLine());
			switch (input) { 
				case 1: Console.WriteLine("\nOutput :" +(number2 + number1)+"\n"); break;
				case 2: Console.WriteLine("\nOutput :" + (number2 - number1) + "\n"); break;
				case 3: Console.WriteLine("\nOutput :" + (number2 * number1) + "\n"); break;
				case 4: Console.WriteLine("\nOutput :" + (number2 / number1) + "\n"); break;
			
			}

		}
		
	}

}