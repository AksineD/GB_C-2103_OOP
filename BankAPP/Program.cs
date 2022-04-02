#region

using BankAPP;

#endregion

var ba = new BankAccount(123.45);
Console.WriteLine(ba.ToString());

var ba1 = new BankAccount(BankAccountType.Foreign);
Console.WriteLine(ba1.ToString());

var ba2 = new BankAccount(1234.56, BankAccountType.Current);
Console.WriteLine(string.Empty.PadRight(50, '='));
Console.WriteLine(ba2.ToString());
Console.WriteLine("Withdraw 1000");
ba2.Withdraw(1000);
Console.WriteLine($"new balance: {ba2.Balance}");
Console.WriteLine(string.Empty.PadRight(50, '='));
Console.WriteLine("Deposit 765.44");
ba2.Deposit(765.44);
Console.WriteLine($"new balance: {ba2.Balance}");
Console.WriteLine(string.Empty.PadRight(50, '='));
Console.WriteLine("Withdraw 2000");
ba2.Withdraw(2000);
Console.WriteLine($"new balance: {ba2.Balance}");

Console.WriteLine(string.Empty.PadRight(50, '='));
Console.WriteLine("set 600 for balance ba1");
ba1.Balance = 600;
Console.WriteLine(ba1.ToString());
Console.WriteLine(ba2.ToString());
Console.WriteLine("transfer 500 from ba1 to ba2");
ba2.TransferMoney(ref ba1, 500);
Console.WriteLine(ba1.ToString());
Console.WriteLine(ba2.ToString());

Console.WriteLine("transfer 500 from ba1 to ba2");
ba2.TransferMoney(ref ba1, 500);
Console.WriteLine(ba1.ToString());
Console.WriteLine(ba2.ToString());


//Console.WriteLine($"new balance ba2: {ba2.Balance}");
//Console.WriteLine($"new balance ba1: {ba1.Balance}");