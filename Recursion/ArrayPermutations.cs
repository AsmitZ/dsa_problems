
namespace Algorithms.Recursion;

public static class ArrayPermutations
{
    // Approach 1 (more time complexity)
    public static IList<IList<int>> Permute_A1(int[] nums)
    {
        var result = new List<IList<int>>();
        Permute_A1([.. nums], [], result);
        return result;
    }

    public static void Permute_A1(List<int> nums, List<int> num, List<IList<int>> permutations)
    {
        if (nums.Count == 0)
        {
            permutations.Add([.. num]);
            return;
        }

        for (int i = 0; i < nums.Count; i++)
        {
            var n = nums[i];
            nums.RemoveAt(i);
            num.Add(n);
            Permute_A1(nums, num, permutations);
            num.RemoveAt(num.Count - 1);
            nums.Insert(i, n);
        }
    }

    public static IList<IList<int>> Permute_A2(int[] nums)
    {
        var result = new List<IList<int>>();
        var freq = new bool[nums.Length];
        Permute_A2(nums, [], freq, result);
        return result;
    }

    private static void Permute_A2(int[] nums, List<int> num, bool[] freq, List<IList<int>> result)
    {
        if (nums.Length == num.Count)
        {
            result.Add([.. num]);
            return;
        }

        for(int i=0; i<nums.Length; i++)
        {
            if (freq[i]) continue;
            freq[i] = true;
            num.Add(nums[i]);
            Permute_A2(nums, num, freq, result);
            num.RemoveAt(num.Count - 1);
            freq[i] = false;   
        }
    }
}