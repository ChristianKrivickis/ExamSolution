using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public abstract class Account
    {
        // Constructor - First Name
        public string FirstName { get; set; }

        // Constructor - Last Name
        public string LastName { get; set; }

        // Constructor - Balance
        public decimal Balance { get; set; }

        // Constructor - Balance
        public decimal Interest { get; set; }

        // Account object
        public Account(string FirstName, string LastName, decimal Balance, decimal Interest)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Balance = Balance;
            this.Interest = Interest;
        }

        public abstract decimal CalculateInterest();
    }

    public class CurrentAccount : Account
    {
        public CurrentAccount(string FirstName, string LastName, decimal Balance, decimal Interest) : base(FirstName, LastName, Balance, Interest)
        {
        }

        public override decimal CalculateInterest()
        {
            return Balance * (decimal)0.03;
        }
    }

    public class SavingsAccount : Account
    {
        public SavingsAccount(string FirstName, string LastName, decimal Balance, decimal Interest) : base(FirstName, LastName, Balance, Interest)
        {
        }

        public override decimal CalculateInterest()
        {
            return Balance * (decimal)0.06;
        }
    }
}
