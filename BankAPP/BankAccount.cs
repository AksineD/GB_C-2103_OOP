// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BankAccount.cs" company="">
//   
// </copyright>
// <summary>
//   The bank account type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BankAPP
{
    #region

    using System.Text;

    #endregion

    /// <summary>
    /// The bank account type.
    /// </summary>
    internal enum BankAccountType
    {
        /// <summary>
        /// The current.
        /// </summary>
        Current,

        /// <summary>
        /// The savings.
        /// </summary>
        Savings,

        /// <summary>
        /// The foreign.
        /// </summary>
        Foreign
    }

    /// <summary>
    /// The bank account.
    /// </summary>
    internal class BankAccount
    {
        /// <summary>
        /// The _id.
        /// </summary>
        private static int _id;

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccount"/> class.
        /// </summary>
        public BankAccount()
        {
            this.AccountNumber = GetNextAccountId();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccount"/> class.
        /// </summary>
        /// <param name="balance">
        /// The balance.
        /// </param>
        public BankAccount(double balance)
            : this()
        {
            this.Balance = balance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccount"/> class.
        /// </summary>
        /// <param name="type">
        /// The type.
        /// </param>
        public BankAccount(BankAccountType type)
            : this(balance: 0)
        {
            this.AccountType = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccount"/> class.
        /// </summary>
        /// <param name="balance">
        /// The balance.
        /// </param>
        /// <param name="type">
        /// The type.
        /// </param>
        public BankAccount(double balance, BankAccountType type)
            : this()
        {
            this.Balance = balance;
            this.AccountType = type;
        }

        /// <summary>
        /// Gets the account number.
        /// </summary>
        public int AccountNumber { get; private set; }

        /// <summary>
        /// Gets or sets the balance.
        /// </summary>
        public double Balance { get; set; }

        /// <summary>
        /// Gets or sets the account type.
        /// </summary>
        internal BankAccountType AccountType { get; set; }

        /// <summary>
        /// The deposit.
        /// </summary>
        /// <param name="amount">
        /// The amount.
        /// </param>
        public void Deposit(double amount)
        {
            this.Balance += amount;
        }

        /// <summary>
        /// The to string.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"Account Number: {this.AccountNumber} ; ");
            sb.Append($"Balance: {this.Balance:F2} ; ");
            sb.Append($"Account Type: {this.AccountType} ; ");

            return sb.ToString();
        }

        /// <summary>
        /// The withdraw.
        /// </summary>
        /// <param name="amount">
        /// The amount.
        /// </param>
        public void Withdraw(double amount)
        {
            if (this.Balance - amount >= 0) this.Balance -= amount;
        }

        /// <summary>
        /// The get next account id.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        private static int GetNextAccountId()
        {
            return _id++;
        }
    }
}