namespace Algorithms.Array_Hashset;

public static class CountMaxConsecutiveOnes
{
    public static int Count(int[] nums)
    {
        if (nums.Length == 0) return 0;
        if (nums.Length == 1)
        {
            if (nums[0] == 1) return 1;
            else return 0;
        }

        int maxCount = 0;

        int p1 = 0;
        int p2 = p1;

        while (p2 != nums.Length)
        {
            if (nums[p1] != 1)
            {
                while (p1 < nums.Length && nums[p1] != 1)
                {
                    p1++;
                }

                p2 = p1;

                if (p1 >= nums.Length) return maxCount;
            }

            if (nums[p2] == 1)
            {
                p2++;
            }
            else
            {
                p2++;
                p1 = p2;
            }

            if (p2 - p1 > maxCount)
            {
                maxCount = p2 - p1;
            }
        }

        return maxCount;
    }
}