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

            string[] input = new string[] {"Hello", "Hej", "Hello", "Hejdå!"};
            int result = CountHello(input);
            Console.WriteLine(result);

            Database db = new Database();
            bool dbresult = db.SaveResult(result, "Måndag");
        }

        public static int CountHello(string[] input)
        {
            int count = 0;

            foreach (string str in input)
            {
                if (str == "Hello")
                {
                    count = count + 1;
                }
            }

            return count;
        }
    }

    internal class Database
    {
        public bool SaveResult(int result, string måndag)
        {
            return false;
            //TODO Implement database access code
        }
    }
}
