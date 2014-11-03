using System;

namespace Start
{
    public class Logger
    {
        public void AddToLog(string message)
        {
            Console.WriteLine("Log: " + DateTime.Now + " " + message);
        }
    }
}