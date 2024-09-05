using Xunit;

namespace Algorithms.Pointor;

public class MaxProfit
{
    public int Compute(int[] prices)
    {
        int left = 0;
        int right = 1;
        int maxProfit = 0;
        for(int i = 0; i < prices.Length -1; i++){
            if (prices[left] > prices[right]){
                left = right;
                right++;
                continue;   
            }

            int profit = prices[right] - prices[left];
            if (profit > maxProfit){
                maxProfit = profit;
            }

            right++;
        }
        return maxProfit;
    }
}

public class MaxProfitTest
{
    [Fact]
    public void Test_Compute()
    {
        var maxProfit = new MaxProfit();
        Assert.Equal(5, maxProfit.Compute(new int[]{7,1,5,3,6,4}));
        Assert.Equal(0, maxProfit.Compute(new int[]{7,6,4,3,1}));
    }
}