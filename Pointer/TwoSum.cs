using Xunit;

namespace Algorithms.Pointor;

public class TwoSum
{
    public int[] GetV2(int[] numbers, int target)
    {
        var left = 0;
        var right = numbers.Length - 1;
        while (left < right)
        {
            int sum = numbers[left] + numbers[right];
            if (sum == target)
            {
                return new[] { left + 1, right + 1 };
            }
            if (sum < target)
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        return new int[2];
    }
    
    public int[] Get(int[] numbers, int target)
    {
        int i = 0;
        while (i < numbers.Length)
        {
            int j = i + 1;
            while (j < numbers.Length)
            {
                var sum = numbers[i] + numbers[j];
                if (sum == target)
                {
                    return new[] { i + 1, j + 1 };
                }
                if (sum > target)
                {
                    break;
                }
                j++;
            }
            i++;
        }
        return new int[2];
    }
}

public class TwoSumTest
{
    [Fact]
    public void Test_Get()
    {
        var twoSum = new TwoSum();
        var numbers = new[] {2, 7, 11, 15};
        var target = 9;
        var result = twoSum.Get(numbers, target);
        Assert.Equal(new[] {1, 2}, result);
    }
    
    [Fact]
    public void Test_GetV2()
    {
        var twoSum = new TwoSum();
        var numbers = new[] {2, 7, 11, 15};
        var target = 9;
        var result = twoSum.GetV2(numbers, target);
        Assert.Equal(new[] {1, 2}, result);
    }
}