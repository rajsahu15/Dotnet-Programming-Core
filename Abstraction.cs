using System;

abstract class BankAccount
{
    public string Owner;

    public abstract void Display();

    public void Welcome()
    {
        Console.WriteLine("Welcome to the Bank, " + Owner);
    }
}

class SavingsAccount : BankAccount
{
    public decimal balance = 35000m;

    public override void Display()
    {
        Console.WriteLine("This is a Savings Account with " + balance + "$ balance.");
    }
}
public class Abstraction {
    public static void Main(string[] args) {

        SavingsAccount mySavings = new SavingsAccount();
        mySavings.Owner = "Ram";
        mySavings.Welcome();     
        mySavings.Display();  
    }
}
