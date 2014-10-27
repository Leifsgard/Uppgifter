using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise___2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 7;
            char cd = (char) x;
            Console.WriteLine(cd);



            for (int i = 0; i < 127; i++)
            {
                char c = (char) i;

                if(i==9 || i==10 || i== 13)
                    Console.Write("{0} = {1}   ", i, ' ');
                else
                    Console.Write("{0} = {1}   ", i, c);

                if(i % 7 == 0)
                    Console.WriteLine("");
            }

        }
    }
}
