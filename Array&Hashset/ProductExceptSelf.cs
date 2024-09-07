using Xunit;

namespace Algorithms.Array_Hashset;

public class ProductExceptSelf
{
    public int[] GetProductExceptSelf(int[] nums)
    {
        var dict1 = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var prevProduct = 1;
            if (i > 0)
            {
                prevProduct = dict1[i - 1];
            }

            dict1[i] = prevProduct * nums[i];
        }

        var dict2 = new Dictionary<int, int>();
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            var prevProduct = 1;
            if (i < nums.Length - 1)
            {
                prevProduct = dict2[i + 1];
            }

            dict2[i] = prevProduct * nums[i];
        }

        var res = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (i == 0 && nums.Length > 0)
            {
                res.Add(dict2[i + 1]);
                continue;
            }

            if (i == nums.Length - 1 && nums.Length > 0)
            {
                res.Add(dict1[i - 1]);
                continue;
            }

            res.Add(dict1[i - 1] * dict2[i + 1]);
        }

        return res.ToArray();
    }

    public int[] GetProductExceptSelfV2(int[] nums)
    {
        int[] rst1 = new int[nums.Length];
        int[] rst2 = new int[nums.Length];
        rst1[0] = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            rst1[i] = rst1[i - 1] * nums[i - 1];
        }

        rst2[nums.Length - 1] = 1;
        for (int i = nums.Length - 2; i >= 0; i--)
        {
            rst2[i] = rst2[i + 1] * nums[i + 1];
        }

        for (int i = 0; i < nums.Length; i++)
        {
            rst1[i] *= rst2[i];
        }

        return rst1;
    }
}

public class ProductExceptSelfTest
{
    [Fact]
    public void Test_ProductExceptSelf()
    {
        //Given
        var productExceptSelf = new ProductExceptSelf();
        var nums = new int[] { 1, 2, 3, 4 };
        //When
        var res = productExceptSelf.GetProductExceptSelf(nums);
        //Then
        Assert.Equal(new int[] { 24, 12, 8, 6 }, res);
    }
    
    [Fact]
    public void Test_ProductExceptSelfV2()
    {
        //Given
        var productExceptSelf = new ProductExceptSelf();
        var nums = new int[] { 1, 2, 3, 4 };
        //When
        var res = productExceptSelf.GetProductExceptSelfV2(nums);
        //Then
        Assert.Equal(new int[] { 24, 12, 8, 6 }, res);
    }
}