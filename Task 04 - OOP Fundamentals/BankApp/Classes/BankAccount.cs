namespace BankApp.Classes;

public class BankAccount
{
    private string fullName;

    public string FullName
    {
        get { return fullName;}
        
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Full name cannot be empty", nameof(value));
            }

            fullName = value;
        }
    }

    private decimal balance;
    
    public decimal Balance
    {
        get => balance; // get { return balance; } c'est la même chose  

        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "Balance cannot be negative");
            }
            balance = value;
        }
    }

    public string AccountNumber { get; set;} // auto property 

    public bool HasPositiveBalance => balance > 0; // read-only property (aka calculated property) , il a qu'un seul get (pas de set)

    public BankAccount(string fn, decimal b)
    {
        FullName = fn;
        Balance = b ;

    }

    // constructor overloading (plusieurs constructeurs qui ont le même nom) + constructor chaining  
    public BankAccount() : this("Unknown", 0) // meme chose que FullName = "Unknown"; Balance = 0;
    {
        AccountNumber = "0000";
    }

    public void Deposit(decimal amount)
    {   
        if (amount >= 0)
        {
            balance += amount; // balance = balance + amount;
        }
        else
        {
            throw new ArgumentOutOfRangeException("Amount should be positive value", nameof(amount));
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount >= 0)
        {
            if (amount <= balance)
            {
                balance -= amount; 
            }
            else
            {
                throw new ArgumentOutOfRangeException("Amount should be less than the current balance", nameof(amount));

            }
        }
        else
        {
            throw new ArgumentOutOfRangeException("Amount should be positive value", nameof(amount));
        }
    }

}