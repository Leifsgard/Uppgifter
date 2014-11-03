using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyAtm
{
    class Account
    {
        // A field - this variable is only accessed directly by the methods in this class
        private int balance = 0;

        public void Withdraw(int amount)
        {
            // Decrease balance by amount
            balance -= amount;
        }

        public void Deposit(int amount)
        {
            // Increase balance by amount
            balance += amount;
        }

        public int GetBalance()
        {
            // Return the private variable
            return balance;
        }
    }
}
