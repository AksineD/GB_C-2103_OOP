using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAPP
{
    using System.Runtime.CompilerServices;

    using Newtonsoft.Json;

    enum BankAccountType
    {
        Current,
        Savings,
        Foreign

    }

    internal class BankAccount
    {
        private static int _accountNumber;

        private double _balance;

        private BankAccountType _accountType;

        public BankAccount()
        {
            SetAccountNumber();
        }
        public BankAccount(double balance) : this()
        {
            Balance = balance;
        }

        public BankAccount(BankAccountType type) : this(balance: 0)
        {
            AccountType = type;
        }

        public BankAccount(double balance, BankAccountType type) : this()
        {
            Balance = balance;
            AccountType = type;
        }

        public static int AccountNumber { get => _accountNumber; set => _accountNumber = value; }
        public double Balance { get => _balance; set => _balance = value; }
        internal BankAccountType AccountType { get => _accountType; set => _accountType = value; }

        private static void SetAccountNumber()
        {
            AccountNumber++;
        }


        public void Withdraw(double amount)
        {
            if (Balance - amount > 0)
            {
                Balance -= amount;
            }
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.Append($"Account Number: {AccountNumber} ; ");
            sb.Append($"Balance: {Balance:F2} ; ");
            sb.Append($"Account Type: {AccountType} ; ");

            return sb.ToString();
        }
    }
}
