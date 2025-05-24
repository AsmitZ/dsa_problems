namespace Algorithms.Array_Hashset;

// Question - https://takeuforward.org/data-structure/stock-buy-and-sell/
public static class StockBuyAndSell
{
    public static int GetMaxProfit(int[] arr)
    {
        int maxProfit = 0;
        int start = 0;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] < arr[start])
            {
                start = i;
            }

            int profit = arr[i] - arr[start];

            if (profit > maxProfit)
            {
                maxProfit = profit;
            }
        }

        Console.WriteLine($"Max profit is {maxProfit}");

        return maxProfit;
    }
}