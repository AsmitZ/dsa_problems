namespace Algorithms.BinarySearch;

static class SmallestElement
{
    public static int Search(int[] nums)
    {
        int res = BinarySearch(nums, 0, nums.Length - 1);
        return res;
    }

    // [3,4,5,6,1,2]
    private static int BinarySearch(int[] nums, int l, int r)
    {
        if (nums.Length == 0) return -1;

        if (l == r) return nums[l];

        var m = (l + r) / 2;

        if (nums[m] > nums[r])
        {
            return BinarySearch(nums, m + 1, r);
        }
        else
        {
            return BinarySearch(nums, l, m);
        }
    }
}