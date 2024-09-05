using Xunit;

namespace Algorithms.Array_Hashset;

public class TopKFrequentElement
{
    public int[] Compute(int[] nums, int k)
    {
        var map = new Dictionary<int, int>();

        foreach(int n in nums){
            if(!map.TryAdd(n, 1)){
                map[n]++;
            }
        }

        var countMap = new Dictionary<int, List<int>>();

        foreach(var (n, v) in map){
            if(!countMap.TryGetValue(v, out var arr)){
                countMap[v] = new List<int>() {n};
                continue;
            }
            arr.Add(n);
        }

        var res = new List<int>();
        for(int i = nums.Length; i > 0; i--){
            if(countMap.TryGetValue(i, out var elements)){
                res.AddRange(elements);
            }
            if (res.Count >= k){
                break;
            }
        }

        return res.ToArray();
    }
}

public class TopKFrequentElementTest
{
    [Fact]
    public void MustGetTop2FrequentElements()
    {
        var nums = new[] { 1, 1, 1, 2, 2, 3 };
        var k = 2;
        var topKFrequentElement = new TopKFrequentElement();
        var res = topKFrequentElement.Compute(nums, k);
        Assert.Equal(2, res.Length);
        Assert.Equivalent(new[] { 1, 2 }, res);
    }
}