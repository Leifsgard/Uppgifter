using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_exercises_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = -10;
            int y = -20;
            int z = -30;

            Matte M = new Matte();
            int MaxTal = M.GetMax(x, y, z);
            int MinTal = M.GetMin(x, y, z);

            Console.WriteLine("Max = "+ MaxTal);
            Console.WriteLine("Min = " + MinTal);

        }
    }
}
