

using BankAPP;

var ba = new BankAccount();

ba.SetAccountNumber(1234);
ba.SetBalance(-2356.45);
ba.SetAccountType(BankAccountType.Savings);



Console.WriteLine(ba.ToString());