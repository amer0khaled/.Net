using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec1
{
    internal class BankAccount
    {
        private readonly int accountNumber;
        private double _balance = 0.0;
        public BankAccount(int accountNumber, string accountName)
        {
            AccountNumber = accountNumber;
            AccountHoldName = accountName;

        }

        public int AccountNumber { get; private set; }
        public string AccountHoldName { get; private set; }
        public double Balance 
        { 
            get { return _balance; }
            private set { _balance = value; }
        }

        public void Deposite(double amount)
        {
            if (amount > 0)
                _balance += amount;
        }
        
        public void Withdraw(int accountNumber,double amount)
        {
            //if entered wrong acc no.
            if  (AccountNumber != accountNumber)
                Console.WriteLine("Wrong Account Number\n");
            else
            {
                if (amount < 0)
                    Console.WriteLine("Can not Withdraw Negative amount");
               
                //to avoid negative balance
                else if (Balance >= amount)
                {
                    Balance -= amount;
                }
                else
                    Console.WriteLine("Your Balance Not Enough\n");

            }

        }

    }
}
