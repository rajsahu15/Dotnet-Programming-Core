using System;

class BankAccount
	{
		public string AccountNumber { get; set; }
		public string AccountHolder { get; set; }
		private decimal balance; 
		
	public BankAccount(string accountNum, string holderName, decimal initialBalance)
		{
			AccountNumber = accountNum;
			AccountHolder = holderName;
			balance = initialBalance;
		}

		public void Deposit(decimal amount)
		{
			if (amount > 0)
			{
				balance += amount;
				Console.WriteLine("Successfully deposited: "+amount +" New balance: "+balance);
			}
			else
			{
				Console.WriteLine("Deposit amount must be positive.");
			}
		}

		public void Withdraw(decimal amount)
		{
			if (amount > balance)
			{
				Console.WriteLine("Insufficient Funds! Transaction cancelled.");
			}
			else if (amount <= 0)
			{
				Console.WriteLine("Please enter a valid withdrawal amount.");
			}
			else
			{
				balance -= amount;
				Console.WriteLine("Successfully withdrew: "+amount +" Remaining balance: "+balance);
			}
		}

		public void DisplayAccountDetails()
		{
		Console.WriteLine("\n--- Account Details ---");
		Console.WriteLine("Holder: " + AccountHolder);
		Console.WriteLine("Account #: " + AccountNumber);
		Console.WriteLine("Current Balance: $" + balance);
		Console.WriteLine("-----------------------\n");
	}
	}

	public class SimpleBank
	{
		static void Main(string[] args)
		{
			BankAccount myAccount = new BankAccount("10002932", "Sita Ram", 899.98m);

			myAccount.DisplayAccountDetails();

			myAccount.Deposit(300.02m);
			myAccount.Withdraw(100.00m);

			myAccount.DisplayAccountDetails();

		}
	}
