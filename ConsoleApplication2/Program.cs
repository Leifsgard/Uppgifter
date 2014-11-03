using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var bank = new Bank();
            bank.CreateAccount("Nils");
            bank.DepositMoney(10);
            bank.DepositMoney(20);
            bank.DepositMoney(30);
            bank.DepositMoney(40);

            Console.WriteLine(bank.GetAllTransactions());
         }
    }
    public class Bank
    {
        private Account account;

        public void CreateAccount(string AccountName)
        {
            account = new Account();
            account.SetAccountName(AccountName);
        }

        public void DepositMoney(int Amount)
        {
            account.Deposit(Amount);
            Console.WriteLine("you deposited " + Amount + " Sek");
        }

        //Return all bank transactions on this account
        public string GetAllTransactions()
        {
            string str = account.GetAccountTransaction();
            Console.WriteLine(str);
            return str;
        }
    }
}
