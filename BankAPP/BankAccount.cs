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
            _balance = balance;
        }

        public BankAccount(BankAccountType type)
        {
            SetAccountNumber();
            _accountType = type;
        }

        public BankAccount(double balance, BankAccountType type)
        {
            SetAccountNumber();
            _balance = balance;
            _accountType = type;
        }

        private static void SetAccountNumber()
        {
            _accountNumber++;
        }
        public int GetAccountNumber()
        {
            return _accountNumber;
        }
        public double GetBalance()
        {
            return this._balance;
        }

        public BankAccountType GetAccountType()
        {
            return _accountType;
        }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.Append($"Account Number: {this.GetAccountNumber()} ; ");
            sb.Append($"Balance: {this.GetBalance()} ; ");
            sb.Append($"Account Type: {this.GetAccountType()} ; ");

            return sb.ToString();
        }
    }
}
