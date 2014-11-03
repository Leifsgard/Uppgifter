using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            var myLogger = new Logger();
            
            myLogger.Log("This is the first log");
            myLogger.Log("Second log message!");
            myLogger.Log("I'm adding a third message!");

            foreach (var post in myLogger.LogPosts)
            {
                Console.WriteLine("MESSAGE: " + post);
            }
        }
    }
}
