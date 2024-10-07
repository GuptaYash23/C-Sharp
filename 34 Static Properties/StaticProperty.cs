using System;

public class BankAccount
{
    // Static property shared by all BankAccount instances
    public static double InterestRate { get; set; } = 0.05;

    // Instance property
    public string AccountHolder { get; set; }
    public double Balance { get; set; }

    public BankAccount(string accountHolder, double initialBalance)
    {
        AccountHolder = accountHolder;
        Balance = initialBalance;
    }

    public void ApplyInterest()
    {
        Balance += Balance * InterestRate;
    }

    public void DisplayAccountInfo()
    {
        Console.WriteLine($"Account Holder: {AccountHolder}, Balance: {Balance:C}, Interest Rate: {InterestRate:P}");
    }
}

class Program
{
    static void Main()
    {
        // Set the static InterestRate
        BankAccount.InterestRate = 0.06;

        // Create two instances of BankAccount
        BankAccount account1 = new BankAccount("Alice", 1000);
        BankAccount account2 = new BankAccount("Bob", 2000);

        // Apply interest and display account info
        account1.ApplyInterest();
        account2.ApplyInterest();

        account1.DisplayAccountInfo();  // Output will show the interest rate as 6%
        account2.DisplayAccountInfo();  // Output will show the interest rate as 6%

        // Modify the static InterestRate
        BankAccount.InterestRate = 0.07;

        // Apply interest again with the new rate
        account1.ApplyInterest();
        account2.ApplyInterest();

        account1.DisplayAccountInfo();  // Output will show the updated interest rate and new balance
        account2.DisplayAccountInfo();  // Same here
    }
}
