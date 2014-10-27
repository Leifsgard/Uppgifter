using System;

namespace MyAtm
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            int balance = 100;

            while (run)
            {
                // Print main menu
                Console.Clear();
                Console.WriteLine("Select an option");
                Console.WriteLine("----------------");
                Console.WriteLine();
                Console.WriteLine("a) Withdraw from account");
                Console.WriteLine("b) Deposit to account");
                Console.WriteLine("c) Check balance");
                Console.WriteLine("d) Exit");
                Console.WriteLine();

                // Collect user input
                Console.Write("> ");
                var input = Console.ReadLine();

                switch (input)
                {
                    case "a": // The user selected "Withdraw from account"
                        Console.WriteLine("Enter amount: ");
                        var amount = int.Parse(Console.ReadLine());

                        if (balance >= amount)
                        {
                            Console.WriteLine("Withdrawing {0} SEK from account", amount);
                            balance -= amount;
                        }
                        else
                        {
                            Console.WriteLine("You don't have {0} SEK to withdraw", amount);
                        }

                        break;

                    case "b":
                        Console.WriteLine("Enter amount: ");
                        amount = int.Parse(Console.ReadLine());

                        balance += amount;
                        Console.WriteLine("Depositing {0} SEK to account", amount);
                        break;

                    case "c":
                        Console.WriteLine("You have {0} SEK on your account", balance);
                        break;

                    case "d":
                        run = false;
                        Console.WriteLine("Bye!");
                        break;
                }

                Console.ReadKey();
            }
        }
    }
}
