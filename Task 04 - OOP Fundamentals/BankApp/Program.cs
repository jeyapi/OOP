using BankApp.Classes;

var account = new BankAccount("My Account", 300);
//var account = new BankAccount();

try
{
    account.Deposit(600);
    account.Withdraw(-200);
    account.Withdraw(100);

    //account.FullName="My Account"; //set
    //account.Balance = 100;
    //account.AccountNumber = "1234";
    // account.HasPositiveBalance = true; // impossible car c'est une propriété en lecture seule (read-only property)
}
catch(ArgumentException a)
{
    Console.WriteLine($"Validation error: {a.Message}");
}

Console.WriteLine(account.FullName); // get
Console.WriteLine(account.Balance);
Console.WriteLine(account.AccountNumber);
Console.WriteLine(account.HasPositiveBalance);

account.FullName = account.FullName + " 123"; // first we read, then we assign 
Console.WriteLine(account.FullName); // get