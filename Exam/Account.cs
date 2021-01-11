using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public abstract class Account
    {
        // Constructor - Account Number
        public int AccountNumber { get; set; }

        // Constructor - First Name
        public string FirstName { get; set; }

        // Constructor - Last Name
        public string LastName { get; set; }

        // Constructor - Account Type
        public string Type { get; set; }

        // Constructor - Balance
        public decimal Balance { get; set; }

        // Constructor - Balance
        public decimal Interest { get; set; }

        // Account object
        public Account(string FirstName, string LastName, int AccountNumber, decimal Balance, string Type)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.AccountNumber = AccountNumber;
            this.Balance = Balance;
            this.Type = Type;
        }

        // Abstract method to calculate interest
        public abstract decimal CalculateInterest();

        // ToString method to properly format accounts
        public override string ToString()
        {
            return string.Format($"{AccountNumber} - {LastName}, {FirstName}");
        }
    }

    // Current Account class - Inherited Account class
    public class CurrentAccount : Account
    {
        public CurrentAccount(string FirstName, string LastName, int AccountNumber, decimal Balance, string Type) : base(FirstName, LastName, AccountNumber, Balance, Type)
        {
        }

        // Method to interest of Current Accounts (Balance divided by 3%)
        public override decimal CalculateInterest()
        {
            return Balance * (decimal)0.03;
        }
    }

    // Savings Account class - Inherited Account class
    public class SavingsAccount : Account
    {
        public SavingsAccount(string FirstName, string LastName, int AccountNumber, decimal Balance, string Type) : base(FirstName, LastName, AccountNumber, Balance, Type)
        {
        }

        // Method to interest of Savings Accounts (Balance divided by 6%)
        public override decimal CalculateInterest()
        {
            return Balance * (decimal)0.06;
        }
    }
}
