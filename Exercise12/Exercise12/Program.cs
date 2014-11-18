using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            //var logger = new Logger();
            var logger = new DateTimeLogger();

            var application = new LogApplication(logger);
            application.Run();
        }
    }
}
