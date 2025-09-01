namespace Algorithms.GreedyAlgorithm;

// Question- https://takeuforward.org/data-structure/fractional-knapsack-problem-greedy-approach/
public static class FractionalKnapsack
{
    public static double Max(int W, int[] value, int[] weight)
    {
        int n = value.Length;
        if (n == 0) return 0;

        List<Item> items = []; 
        for (int i = 0; i < n; i++)
        {
            items.Add(new Item(value[i], weight[i]));
        }

        // sort
        items.Sort((a, b) => a.UnitWeight.CompareTo(b.UnitWeight));

        double maxQuantity = 0;
        var totalWeight = 0;
        for (int i = 0; i < n; i++)
        {
            if (totalWeight == W)
            {
                break;
            }

            var currentItem = items[i];

            int remaining = W - totalWeight;
            if (remaining >= currentItem.Weight)
            {
                maxQuantity += currentItem.Quantity;
                totalWeight += currentItem.Weight;
            }
            else
            {
                var fractionQuantity = (double)remaining / currentItem.UnitWeight;
                maxQuantity += fractionQuantity;
                totalWeight += remaining;
            }
        }

        return maxQuantity;
    }

    public class Item
    {
        public double UnitWeight { get; }
        public int Quantity { get; }
        public int Weight { get; }

        public Item(int quantity, int weight)
        {
            Quantity = quantity;
            Weight = weight;
            UnitWeight = (double)weight / (double)quantity;
        }
    }
}