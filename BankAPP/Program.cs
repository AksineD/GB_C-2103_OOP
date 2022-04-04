using BankAPP;

var ba = new BankAccount();
BankAccount.SetAccountNumber();
ba.SetBalance(-2356.45);
ba.SetAccountType(BankAccountType.Savings);
Console.WriteLine(ba.ToString());


var ba1 = new BankAccount();
BankAccount.SetAccountNumber();
ba1.SetBalance(123.45);
ba1.SetAccountType(BankAccountType.Foreign);
Console.WriteLine(ba1.ToString());