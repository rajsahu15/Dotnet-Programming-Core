using System;

public class Exercise2
{
	static void Main(string[] ar)
	{

		// --- 1. Variables and Datatypes ---

		sbyte age2 = 10;
		byte age3 = 20;
		short age4 = 30;
		int age5 = 10;
		int age = 25;
		long muskAccountbal = 800000000000L;

		

		float temperature = 10.6f;
		double pi = 3.14213;
		decimal bankBalance = 1500.50m;

		char grade = 'A';
		bool isTrue = true;

		// --- 2. Reference Types ---
		string message = "Datatypes Program";
		int[] arr = { 10, 2, 0, 30 }; 

		// --- 3. Operators ---

		int sum = age + 5;
		double division = pi / 2;
		int remainder = 10 % 3;

		bool canVote = age >= 18;
		bool isPass = (grade == 'A');

		bool canWork = canVote && isPass;
		bool canNotDrive = (age <= 18) || (age >= 80);

		//--4. Assignment Operator --
		age += age5;

		// --- 4. Printing All using the + Sign ---

		Console.WriteLine("===== " + message + " =====");

		Console.WriteLine("Integer types: " + age2 + ", " + age3 + ", " + age4 + ", " + age + ", " + muskAccountbal);

		Console.WriteLine("Temperature: " + temperature + "f");
		Console.WriteLine("Pi Value: " + pi);
		Console.WriteLine("Bank Balance: " + bankBalance);

		Console.WriteLine("Grade: " + grade);
		Console.WriteLine("Boolean Value: " + isTrue);

		// Printing Array elements manually
		Console.WriteLine("Array elements: " + arr[0] + ", " + arr[1] + ", " + arr[2] + ", " + arr[3]);

		Console.WriteLine("Arithmetic Sum: " + sum);
		Console.WriteLine("Division Result: " + division);
		Console.WriteLine("Remainder (Modulus): " + remainder);

		Console.WriteLine("Can Vote: " + canVote);
		Console.WriteLine("Is a Passing Grade: " + isPass);
		Console.WriteLine("Logical AND (Can Work): " + canWork);
		Console.WriteLine("Logical OR (Cannot Drive): " + canNotDrive);
		
	}
}