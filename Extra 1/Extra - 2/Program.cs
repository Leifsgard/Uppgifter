using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra___2
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = " He l s i ng b o rg    !";

            Filter filter = new Filter();
            string result = filter.RemoveSpaces(input);
            Console.WriteLine(result);
            Console.WriteLine(filter.RemoveSpaces(" h e    l   l o!!!!"));
            Console.WriteLine(filter.RemoveSpaces(" hl   l o!!!!"));
            Console.WriteLine(filter.RemoveSpaces(" !!!!"));
            Console.WriteLine(filter.RemoveSpaces(" !!!!"));

        }
    }

    internal class Filter
    {
        public string RemoveSpaces(string indata)
        {
            string result = "";

            foreach (char c in indata)
            {
                if (c != ' ')
                {
                    result = result + c;
                }
            }
            return result;
        }
    }
}
