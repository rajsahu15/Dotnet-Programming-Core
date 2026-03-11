using System;

public class ExceptionHandling {
    static void Main(string[] args) {
		try
		{
			Console.WriteLine("Enter your age: ");
			int age = int.Parse(Console.ReadLine());

			if (age < 0)
			{
				
				throw new Exception("Age cannot be negative!");
			}

			Console.WriteLine("Your age is: " + age);
		}
		catch (SystemException)
		{
			
			Console.WriteLine("Error: Please enter a valid number, not text.");
		}
		catch (Exception e)
		{
			
			Console.WriteLine("Error: " + e.Message);
		}
		finally
		{
			Console.WriteLine("Thank you for using our system.");
		}

		Console.WriteLine("Program continues running...");
	}
}
