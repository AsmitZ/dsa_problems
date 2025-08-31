namespace Algorithms.GreedyAlgorithm;

// Question - https://takeuforward.org/data-structure/minimum-number-of-platforms-required-for-a-railway/
public static class MaxPlatformNeeded
{
    public static int Find(int[] arr, int[] dep)
    {
        Array.Sort(arr);
        Array.Sort(dep);

        int platform_needed = 1;
        int max_platform = 1;

        int i = 1;
        int j = 0;
        var n = arr.Length;

        while (i < n && j < n)
        {
            if (arr[i] <= dep[j])
            {
                platform_needed++;
                i++;
            }
            else if (arr[i] > dep[j])
            {
                platform_needed--;
                j++;
            }

            if (max_platform < platform_needed)
            {
                max_platform = platform_needed;
            }
        }

        return max_platform;
    }
}