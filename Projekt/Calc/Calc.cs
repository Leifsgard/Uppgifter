using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            Console.WriteLine("added " + x + "," + y);
            

            Logger log = new Logger();

            log.AddToLog("Kalle adderade " + x + " " + y);

            int Result = x + y;
            return Result;
        }
    }
}
