﻿using System;
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

        // Constructor - Balance
        public decimal Balance { get; set; }

        // Constructor - Balance
        public decimal Interest { get; set; }

        // Account object
        public Account(string FirstName, string LastName, int AccountNumber, decimal Balance)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.AccountNumber = AccountNumber;
            this.Balance = Balance;
        }

        public abstract decimal CalculateInterest();

        public override string ToString()
        {
            return string.Format($"{AccountNumber} - {LastName}, {FirstName}");
        }
    }

    public class CurrentAccount : Account
    {
        public CurrentAccount(string FirstName, string LastName, int AccountNumber, decimal Balance) : base(FirstName, LastName, AccountNumber, Balance)
        {
        }

        public override decimal CalculateInterest()
        {
            return Balance * (decimal)0.03;
        }
    }

    public class SavingsAccount : Account
    {
        public SavingsAccount(string FirstName, string LastName, int AccountNumber, decimal Balance) : base(FirstName, LastName, AccountNumber, Balance)
        {
        }

        public override decimal CalculateInterest()
        {
            return Balance * (decimal)0.06;
        }
    }
}
