using Classes;

var account = new BankAccount("Muhammad Saefudin", 14000000000);
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

var account2 = new BankAccount("Apud", 16500000000);
Console.WriteLine($"Account2 {account2.Number} was created for {account2.Owner} with {account2.Balance} initial balance.");
