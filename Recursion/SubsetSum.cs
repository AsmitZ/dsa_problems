namespace Algorithms.Recursion;

// Question - https://takeuforward.org/data-structure/subset-sum-sum-of-all-subsets/
public static class SubsetSum
{
    public static int[] Find(int[] arr)
    {
        List<int> collection = [];
        Find(0, arr, 0, collection); // no take
        // Find(0, arr, sum + arr[0], collection); // take

        // sorting
        collection.Sort();

        return [.. collection];
    }

    private static void Find(int i, int[] arr, int sum, List<int> collection)
    {
        if (i == arr.Length)
        {
            collection.Add(sum);
            return;
        }

        Find(i + 1, arr, sum + arr[i], collection); // take
        Find(i + 1, arr, sum, collection); // no take
    }
}