namespace Algorithms.BinarySearch;

public static class ElementInSortedRotatedArray
{
    public static int Find(int[] nums, int target)
    {
        int low = 0;
        int high = nums.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            // if target is the mid
            if (nums[mid] == target)
            {
                return mid;
            }

            // if left part is sorted
            if (nums[low] <= nums[mid])
            {
                // if target is in range of low and mid
                if (nums[low] <= target && nums[mid] > target)
                {
                    // must be before mid
                    high = mid - 1;
                }
                else
                {
                    // must be after mid
                    low = mid + 1;
                }
            }
            // otherwise right part is sorted
            else
            {
                // if target lies in range of mid high
                if (nums[mid] < target && nums[high] >= target)
                {
                    // must be after of mid
                    low = mid + 1;
                }
                else
                {
                    // must be before mid
                    high = mid - 1;
                }
            }
        }

        // target not found
        return -1;
    }
}