using System;

namespace Start
{
    public class Calculator
    {
        public void Add(int x, int y)
        {
            Console.WriteLine("added " + x + ", " + y);
            Console.WriteLine("added {0}, {1}", x, y);

            Logger log = new Logger();
            log.AddToLog("Kalle adderade " + x + ", " + y);
        }
    }
}