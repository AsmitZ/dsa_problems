namespace Algorithms.Array_Hashset;

// Question - https://takeuforward.org/data-structure/longest-consecutive-sequence-in-an-array/
public class LongestConsecutiveSequence
{
    public static int Length(int[] nums)
    {
        if (nums.Length == 0) return 0;

        int maxLength = 0;
        var hashSet = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            hashSet[nums[i]] = i;
        }

        int k = 0;
        while (k < nums.Length - 1)
        {
            int length = 1;
            int current = nums[k];
            while (true)
            {
                if (hashSet.ContainsKey(current + 1))
                {
                    current++;
                    length++;
                }
                else
                {
                    break;
                }
            }

            if (length > maxLength) maxLength = length;

            k++;
        }

        return maxLength;
    }

}