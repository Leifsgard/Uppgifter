using System;

namespace Exercise12
{
    public class LogApplication
    {
        private readonly ILogger myLogger;

        public LogApplication(ILogger logger)
        {
            myLogger = logger;
        }

        public void Run()
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("1. Add message to log");
                Console.WriteLine("2. Print log");
                Console.WriteLine();
                Console.Write("Choice: ");

                var input = Console.ReadLine();

                MakeChoice(input);
            }
        }

        private void MakeChoice(string input)
        {
            switch (input)
            {
                case "1":
                    AddToLogDialog();
                    break;

                case "2":
                    PrintLogDialog();
                    break;
            }
        }

        private void PrintLogDialog()
        {
            Console.Clear();
            Console.WriteLine("LOG CONTENT:");
            Console.WriteLine("------------");

            foreach (var post in myLogger.LogPosts)
            {
                Console.WriteLine(post);
            }

            Console.ReadLine();
        }

        private void AddToLogDialog()
        {
            Console.Clear();
            Console.WriteLine("Add message:");
            myLogger.Log(Console.ReadLine());
        }
    }
}