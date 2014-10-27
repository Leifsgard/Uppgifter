using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise___4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 3;
            int z = 199;
            bool flag = false;

            bool result = CheckCondition(x, y, z, flag);

            Console.WriteLine(result);
        }

        private static bool CheckCondition(int x, int y, int z, bool flag)
        {
            if(z >10 && z<20 && flag==true)
            return true;

            if (y > 10 && y < 20 && z == 0 && flag == true)
                return true;

            if (x == 5 && y == 3 && z >= 99 && flag == false)
                return true;

            return false;
        } 
    }
}
