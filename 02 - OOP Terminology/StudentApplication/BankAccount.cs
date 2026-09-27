class BankAccount
{
    public string Owner;
    public double Balance;

    public BankAccount(string owner, double balance)
    {
        Owner = owner;
        Balance = balance;
    }
    public void Deposit(double amount)
    {
        Balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
        }
    }

    public double ShowBalance()
    {
        return Balance;
    }

}