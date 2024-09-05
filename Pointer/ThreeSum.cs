using Xunit;

namespace Algorithms.Pointor;

public class ThreeSum
{
    public IList<IList<int>> Compute(int[] nums)
    {
        Array.Sort(nums);

        var result = new List<IList<int>>();
        int i = 0;
        while (i < nums.Length - 2)
        {
            if (i > 0 && nums[i] == nums[i - 1])
            {
                i++;
                continue;
            }
            var firstValue = nums[i];
            var left = i + 1;
            var right = nums.Length - 1;
            
            while (left < right)
            {
                var sum = nums[left] + nums[right] + firstValue;
                if (sum == 0)
                {
                    result.Add(new List<int> { firstValue, nums[left], nums[right] });
                    
                    // Skip duplicates for the second and third elements
                    while (left < right && nums[left] == nums[left + 1]) left++;
                    while (left < right && nums[right] == nums[right - 1]) right--;
                    
                    left++;
                    right--;
                }
                else if (sum < 0)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            i++;
        }
        return result;
    }
    
    public IList<IList<int>> ComputeV2(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>();
        HashSet<string> foundTriplets = new HashSet<string>(); // To avoid duplicates
        for (int i = 0; i < nums.Length - 2; i++)
        {
            HashSet<int> seen = new HashSet<int>();
            for (int j = i + 1; j < nums.Length; j++)
            {
                int complement = -nums[i] - nums[j];
                if (seen.Contains(complement))
                {
                    int[] triplet = new int[] { nums[i], nums[j], complement };
                    Array.Sort(triplet); // Sort to avoid permutation duplicates
                    string tripletKey = string.Join(",", triplet); // Create a unique key for the triplet
                    if (!foundTriplets.Contains(tripletKey))
                    {
                        result.Add(new List<int>(triplet));
                        foundTriplets.Add(tripletKey);
                    }
                }
                seen.Add(nums[j]);
            }
        }
        return result;
    }
}

public class ThreeSumTest
{
    [Fact]
    public void Test_Compute()
    {
        var threeSum = new ThreeSum();
        var numbers = new[] {-1, 0, 1, 2, -1, -4};
        var result = threeSum.Compute(numbers);
        Assert.Equal(2, result.Count);
        Assert.Equivalent(new[] { new[] { -1, -1, 2 }, new[] { -1, 0, 1 } }, result);
    }
    
    [Fact]
    public void Test_ComputeV2()
    {
        var threeSum = new ThreeSum();
        var numbers = new[] {-1, 0, 1, 2, -1, -4};
        var result = threeSum.ComputeV2(numbers);
        Assert.Equal(2, result.Count);
        Assert.Equivalent(new[] { new[] { -1, -1, 2 }, new[] { -1, 0, 1 } }, result);
    }
}