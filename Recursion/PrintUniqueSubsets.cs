
namespace Algorithms.Recursion;

// Question - https://takeuforward.org/data-structure/subset-ii-print-all-the-unique-subsets/
public static class UniqueSubsets
{
    // Brute force
    public static void Print(int[] arr)
    {
        var collection = new HashSet<int[]>(new IntArrayComparer());
        FindSubset(0, arr, [], collection);

        foreach (var set in collection)
        {
            System.Console.Write("[");
            System.Console.Write(string.Join(",", set));
            System.Console.Write("] ");
        }
    }

    // Optimized approach
    public static void PrintOptimized(int[] arr)
    {
        var collection = new List<List<int>>();

        Array.Sort(arr);

        FindSubset(0, arr, [], collection);

        foreach (var item in collection)
        {
            System.Console.Write("[");
            System.Console.Write(string.Join(",", item));
            System.Console.Write("] ");
        }
    }

    private static void FindSubset(int v, int[] arr, List<int> ds, List<List<int>> collection)
    {
        collection.Add([.. ds]);

        for(int i=v; i<arr.Length; i++)
        {
            if (i != v && arr[i] == arr[i - 1]) continue;
            ds.Add(arr[i]);
            FindSubset(i + 1, arr, ds, collection);
            ds.Remove(arr[i]);
        }
    }

    private class IntArrayComparer : IEqualityComparer<int[]>
    {
        public bool Equals(int[]? x, int[]? y)
        {
            if (x == null || y == null)
                return x == y;
            return x.SequenceEqual(y);
        }

        public int GetHashCode(int[] obj)
        {
            if (obj == null)
                return 0;

            unchecked
            {
                int hash = 17;
                foreach (int val in obj)
                    hash = hash * 23 + val.GetHashCode();
                return hash;
            }
        }
    }
    private static void FindSubset(int i, int[] arr, int[] subset, HashSet<int[]> collection)
    {
        if (i == arr.Length)
        {
            collection.Add(subset);
            return;
        }
        var newSubset = subset.Append(arr[i]).ToArray();

        FindSubset(i + 1, arr, newSubset, collection); //take
        FindSubset(i + 1, arr, subset, collection); // no take
    }
}