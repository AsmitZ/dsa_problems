using Xunit;

namespace Algorithms.Array_Hashset;

// Question - https://takeuforward.org/data-structure/next_permutation-find-next-lexicographically-greater-permutation/
public static class NextPermutation
{
    public static int[] GetNextPermutation(int[] nums)
    {
        // Algorithm - 
        // 1. Find the first decreasing element from the end
        // 2. If no such element is found, reverse the entire array and return
        // 3. Find the first element larger than the found element
        // 4. Swap the two elements
        // 5. Reverse the elements after the first decreasing element
        // 6. Return the modified array

        int index = -1;
        for (int i = nums.Length - 1; i > 0; i--)
        {
            if (nums[i] > nums[i - 1])
            {
                index = i - 1;
                break;
            }
        }

        // impt
        if (index == -1)
        {
            Reverse(nums, index);
            return nums;
        }

        Console.WriteLine($"Index: {index}");

        for (int i = nums.Length - 1; i > index; i--)
        {
            if (nums[i] > nums[index])
            {
                Console.WriteLine($"Swapping {nums[index]} and {nums[i]}");
                Swap(nums, index, i);
                break;
            }
        }

        Reverse(nums, index);

        return nums;
    }

    private static void Reverse(int[] nums, int index)
    {
        for (int i = index + 1, j = nums.Length - 1; i < j; i++, j--)
        {
            Console.WriteLine($"Reversing {nums[i]} and {nums[j]}");
            Swap(nums, i, j);
        }
    }

    private static void Swap(int[] nums, int i, int j)
    {
        nums[i] = nums[i] + nums[j];
        nums[j] = nums[i] - nums[j];
        nums[i] = nums[i] - nums[j];
    }
}

public class NextPermutationTests
{
    [Fact]
    public void TestGetNextPermutation()
    {
        
        int[] nums = { 1, 2, 3 };
        int[] expected = { 1, 3, 2 };
        Assert.Equal(expected, NextPermutation.GetNextPermutation(nums));

        nums = new[] { 3, 2, 1 };
        expected = new[] { 1, 2, 3 };
        Assert.Equal(expected, NextPermutation.GetNextPermutation(nums));

        nums = new[] { 1, 1, 5 };
        expected = new[] { 1, 5, 1 };
        Assert.Equal(expected, NextPermutation.GetNextPermutation(nums));
    }
}