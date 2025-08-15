namespace Algorithms.Array_Hashset;

// Question - https://takeuforward.org/data-structure/length-of-the-longest-subarray-with-zero-sum/
public class LongestSubArray
{
    public static int Length(int[] nums)
    {
        if (nums.Length == 0) return 0;
        int max = 0;
        Dictionary<int, int> existingSum = new Dictionary<int, int>();
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine($"current index is {i}");
            var value = nums[i];
            sum += value;
            if (sum == 0)
            {
                max = Math.Max(max, i + 1);
                System.Console.WriteLine($"current sum is zero setting max to {max}");
                continue;
            }

            if (existingSum.ContainsKey(sum))
            {
                int previousSumIndex = existingSum[sum];
                max = Math.Max(max, i - previousSumIndex);
                System.Console.WriteLine($"Sum present is map setting max to {max}");
            }
            else
            {
                existingSum.Add(sum, i);
            }
        }

        return max;
    }
}