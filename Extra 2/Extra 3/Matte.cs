namespace Extra_3
{
    internal class Matte
    {
        public int GetMaxValueFromArary(int[] nums)
        {
            int maxval = int.MinValue;
            foreach (var num in nums)
            {
                if (maxval > num)
                    maxval = num;
            }
            return maxval;
        }

        public int GetMinValueFromArary(int[] nums)
        {
            return 0;
        }

        public int GetAverageValueFromArary(int[] nums)
        {
            if (nums.Length == 0)
                return 0;

            int sum = 0;
            foreach (var num in nums)
            {
                sum = sum + num;
            }

            return sum/nums.Length;
        }
    }
}