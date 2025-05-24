namespace Algorithms.Array_Hashset;

// Question - https://takeuforward.org/data-structure/kadanes-algorithm-maximum-subarray-sum-in-an-array/
public static class KadanesAlgorithm
{
    // This might not be the correct solution.
    public static int GetContinousLargestSubArraySum(int[] arr)
    {
        if (arr.Length == 1)
        {
            return arr[0];
        }

        int currentSum = 0;
        int start = 0;

        int maxStartIndex = -1;
        int maxEndIndex = -1;
        int maxSum = currentSum;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (currentSum == 0)
            {
                start = i;
            }

            currentSum += arr[i];

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                maxStartIndex = start;
                maxEndIndex = i;
            }

            if (currentSum < 0)
            {
                currentSum = 0;
            }
        }

        if (maxStartIndex > 0 && maxEndIndex > 0)
        {
            for (int i = maxStartIndex; i <= maxEndIndex; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        Console.WriteLine($"Max Sum is {maxSum}");
        return maxSum;
    }
}