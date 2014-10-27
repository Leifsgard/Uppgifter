using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Logger
    {
        public void AddToLog(string message)
        {
            Console.WriteLine("Log: " + DateTime.Now + "" + message);
        }
    }
}
