using BankAPP;

var ba = new BankAccount(123.45);
Console.WriteLine(ba.ToString());


var ba1 = new BankAccount(BankAccountType.Foreign);
Console.WriteLine(ba1.ToString());

var ba2 = new BankAccount(-123.45, BankAccountType.Current);
Console.WriteLine(ba2.ToString());