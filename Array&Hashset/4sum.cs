namespace Algorithms.Array_Hashset;

public class FourSum
{
    public static IList<IList<int>> Find(int[] nums, int target)
    {
        if (nums.Length < 4) return [];

        Array.Sort(nums);

        var result = new List<List<int>>();

        int i = 0;
        while (i < nums.Length - 3)
        {
            var firstValue = nums[i];

            if (i > 0 && firstValue == nums[i - 1])
            {
                i++;
                continue;
            }

            int j = i + 1;

            while (j < nums.Length - 2)
            {
                var secondValue = nums[j];

                if (j > i + 1 && secondValue == nums[j - 1])
                {
                    j++;
                    continue;
                }

                var left = j + 1;
                var right = nums.Length - 1;

                while (left < right)
                {
                    var sum = (long)firstValue + (long)secondValue + (long)nums[left] + (long)nums[right];

                    if (sum == target)
                    {
                        result.Add([firstValue, secondValue, nums[left], nums[right]]);

                        while (left < right && nums[left] == nums[left + 1]) left++;
                        while (left < right && nums[right] == nums[right - 1]) right--;

                        left++;
                        right--;
                    }
                    else if (sum < target)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
                j++;
            }
            i++;
        }

        return [.. result];
    }
}