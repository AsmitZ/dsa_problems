namespace Algorithms.Array_Hashset;

// Question - https://takeuforward.org/data-structure/remove-duplicates-in-place-from-sorted-array/
public static class RemoveDuplicateInPlaceSortedArray
{
    public static int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0) return 0;
        if (nums.Length == 1) return 1;

        int p1 = 0;
        int p2 = 1;
        while (p2 != nums.Length)
        {
            var left = nums[p1];
            var right = nums[p2];

            if (left == right)
            {
                p2++;
            }
            else
            {
                p1++;
                nums[p1] = nums[p2];
            }

        }
        return p1 + 1;
    }
}