using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Extra___4
{
    class Program
    {
        static void Main(string[] args)
        {
            Car C = new Car();

            C.MoveGear(1);
            C.MoveGear(2);
            C.MoveGear(4);
        }
    }
}
