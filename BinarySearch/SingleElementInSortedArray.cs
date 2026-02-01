namespace Algorithms.BinarySearch;

public static class SingleElementInSortedArray
{
    public static int Find(int[] nums)
    {
        int length = nums.Length;
        if (length == 1) return nums[0];
        if (nums[0] != nums[1]) return nums[0];
        if (nums[length - 1] != nums[length - 2]) return nums[length - 1];

        int low = 1; int high = length - 2;

        while (low <= high)
        {
            var mid = (low + high) / 2;
            if (nums[mid] != nums[mid + 1] && nums[mid] != nums[mid - 1])
            {
                return nums[mid];
            }

            if (mid % 2 == 0 && nums[mid] == nums[mid + 1] ||
                mid % 2 == 1 && nums[mid] == nums[mid -1])
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }
        return -1;
    }
}