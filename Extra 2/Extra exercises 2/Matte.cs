using System;

namespace Extra_exercises_2
{
    internal class Matte
    {
        public int GetMax(int x, int y, int z)
        {
            int[] arr = new int[3];
            arr[0] = x;
            arr[1] = y;
            arr[2] = z;

            int maxtal = arr[0];
            foreach (var num in arr)
            {
                if (num > maxtal)
                {
                    maxtal = num;
                }
            }

            return maxtal;

        }


        public int GetMax2(int x, int y, int z)
        {
            if (x > y && x > z)
                return x;
            if (y > x && y > z)
                return y;
            if (z > x && z > y)
                return z;

            return x;
        }

        public int GetMin(int x, int y, int z)
        {
            int[] arr = new int[3];
            arr[0] = x;
            arr[1] = y;
            arr[2] = z;

            int mintal = arr[0];
            foreach (var num in arr)
            {
                if (num < mintal)
                {
                    mintal = num;
                }
            }

            return mintal;
        }
    }
}