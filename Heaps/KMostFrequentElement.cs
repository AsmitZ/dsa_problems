namespace Algorithms.Heaps;

static class KMostFrequestElement
{
    public static int[] FindByHeap(int[] arr, int k)
    {
        // create a freq map
        var freqMap = new Dictionary<int, int>();
        foreach (var num in arr)
        {
            freqMap[num] = freqMap.GetValueOrDefault(num, 0) + 1;
        }

        // use priority queue
        var pq = new PriorityQueue<int, int>();
        foreach (var kv in freqMap)
        {
            pq.Enqueue(kv.Key, kv.Value);

            if (pq.Count > k)
            {
                pq.Dequeue();
            }
        }

        var result = new List<int>();
        while(pq.Count > 0)
        {
            var element = pq.Dequeue();
            result.Add(element);
        }
        return [.. result];
    }

    public static int[] FindByBucketSort(int[] nums, int k)
    {
        var freqMap = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            freqMap[num] = freqMap.GetValueOrDefault(num, 0) + 1;
        }

        // bucket index = frequency
        List<int>[] bucket = new List<int>[nums.Length + 1];

        foreach (var kv in freqMap)
        {
            if (bucket[kv.Value] == null)
                bucket[kv.Value] = new List<int>();

            bucket[kv.Value].Add(kv.Key);
        }

        var result = new List<int>();

        for (int i = bucket.Length - 1; i >= 0 && result.Count < k; i--)
        {
            if (bucket[i] != null)
            {
                foreach (var num in bucket[i])
                {
                    result.Add(num);
                    if (result.Count == k)
                        break;
                }
            }
        }

        return [.. result];
    }
}
