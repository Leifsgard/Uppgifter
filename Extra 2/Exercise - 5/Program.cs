using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercise___5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[20, 20];

            int xx = 0;
            int yy = 0;

            if (xx > 0 && yy > 0 && arr[xx - 1, yy - 1] > 0) Console.WriteLine("Hej");




            arr[4, 4] = 1;
            arr[4, 3] = 1;
            arr[4, 2] = 1;

            Random Rnd = new Random();
            for (int i = 0; i < 50; i++)
            {
                int x = Rnd.Next(20);
                int y = Rnd.Next(20);
                arr[x, y] = 1;
            }

            Print(arr);

            int result = CountNeighbors(10, 10, arr);
            Console.WriteLine(result);


        }

        private static int CountNeighbors(int x, int y, int[,] arr)
        {
            int count = 0;

            if (x > 0 && y > 0 && x < 19 && y < 19 && arr[x - 1, y - 1] > 0) count++;
            if (x > 0 && y > 0 && x < 19 && y < 19 && arr[x, y - 1] > 0) count++;
            if (x > 0 && y > 0 && x < 19 && y < 19 && arr[x + 1, y - 1] > 0) count++;

            if (x > 0 && y > 0 && x < 19 && y < 19 && arr[x - 1, y] > 0) count++;
            if (x > 0 && y > 0 && x < 19 && y < 19 && arr[x + 1, y] > 0) count++;

            if (x > 0 && y > 0 && x < 19 && y < 19 && arr[x - 1, y + 1] > 0) count++;
            if (x > 0 && y > 0 && x < 19 && y < 19 && arr[x, y + 1] > 0) count++;
            if (x > 0 && y > 0 && x < 19 && y < 19 && arr[x + 1, y + 1] > 0) count++;

            return count;
        }

        private static void Print(int[,] arr)
        {

            for (int y = 19; y >= 0; y--)
            {
                Console.Write(y + " ");

                for (int x = 0; x < 20; x++)
                {
                    int num = arr[x, y];

                    if (num > 0)
                        Console.Write('*');
                    else
                        Console.Write(' ');
                }
                Console.WriteLine();
            }
        }
    }
}
