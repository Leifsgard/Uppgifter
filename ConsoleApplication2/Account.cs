using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Account
    {
        // A field - this variable is only accessed directly by the methods in this class
        private int balance = 0;
        private string TranscationLog = "";
        private string Name = "";

        public void SetAccountName(string NewName)
        {
            Name = NewName;
        }

        public void Withdraw(int amount)
        {
            // Decrease balance by amount
            balance -= amount;
        }

        public void Deposit(int amount)
        {
            // Increase balance by amount
            balance += amount;

            TranscationLog = TranscationLog +
                             DateTime.Now + " " + 
                             Name + " Deposit" + amount + 
                             " new balance=" + balance + "\r\n";
        }

        public int GetBalance()
        {
            // Return the private variable
            return balance;
        }

        public string GetAccountTransaction()
        {
            return TranscationLog;
        }
    }
}
