using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAPP
{
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
        public BankAccount(double balance)
        {
            SetAccountNumber();
            Balance = balance;
        }

        public BankAccount(BankAccountType type)
        {
            SetAccountNumber();
            AccountType = type;
        }

        public BankAccount(double balance, BankAccountType type)
        {
            SetAccountNumber();
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


        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.Append($"Account Number: {AccountNumber} ; ");
            sb.Append($"Balance: {Balance} ; ");
            sb.Append($"Account Type: {AccountType} ; ");

            return sb.ToString();
        }
    }
}
