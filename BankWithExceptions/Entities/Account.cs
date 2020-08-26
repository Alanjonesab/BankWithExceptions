using System;
using System.Collections.Generic;
using System.Text;
using BankWithExceptions.Entities.Exceptions;

namespace BankWithExceptions.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new DomainException("Amount must be greater than zero");
            }

            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > Balance)
            {
                throw new DomainException("Not enough Balance");
            }
            else if (amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
        }
    }
}
