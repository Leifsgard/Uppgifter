using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Extra___3
{
    class Program
    {
        static void Main(string[] args)
        {

            Person P = new Person();
            P.SetFirstName("Kalle");
            P.SetLastName("Svensson");

            string fullname = P.GetFullName();
            Console.WriteLine(fullname);

            Person P2 = new Person();
            P2.SetFirstName("Nils");
            P2.SetLastName("Andersson");

            string fullname2 = P2.GetFullName();
            Console.WriteLine(fullname2);
        }
    }
}
