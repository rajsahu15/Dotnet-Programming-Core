using System;
class BankAccount { 
   private decimal accBalance;

   public decimal AccBalance
    {
        get { return accBalance; }
        set
        {
            if (value >=100)
            {
                accBalance = value;
            }
            else
            {
                Console.WriteLine("Amount is less than 100");
            }
        }
    }
}


public class Encapsulation {
    public static void Main(string[] args)
    {
        BankAccount accAccount = new BankAccount();
        accAccount.AccBalance = 100;
        Console.WriteLine("Balance =" + accAccount.AccBalance);
    }
}