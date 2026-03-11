using System;
public class Factorial
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Any Number :- \n");
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine("Factorial Of " + input + " is :-" + fact(input));
    }

    static int fact(int input,int prod=1)
    {
        if (input == 0)
        {
            return 0;
        }
        if (input == 1)
        {
            return prod;
        }
        prod = prod * input;
        input = input - 1;
        return fact(input,prod);

    }

}