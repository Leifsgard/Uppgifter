using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = new[] {10, 50, 60, 70, 20, 10, 30, 40, 53, 12};
            int[] nums = new int[0];

            Matte M = new Matte();

            var max = M.GetMaxValueFromArary(nums);
            var min = M.GetMinValueFromArary(nums);
            var avg = M.GetAverageValueFromArary(nums);

            Console.WriteLine("Max=" + max);
            Console.WriteLine("Min=" + min);
            Console.WriteLine("Avg=" + avg);
        }
    }
}
