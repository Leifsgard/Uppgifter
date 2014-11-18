using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            NewEmailSender sender = new NewEmailSender();

            DoStuff stuff = new DoStuff();
            stuff.LoggStuffToEmailer(sender);
            stuff.SendEmail(sender);


            Matte m = new Matte();
           

        }
    }



}
