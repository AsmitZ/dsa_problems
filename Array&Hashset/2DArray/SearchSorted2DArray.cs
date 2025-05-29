namespace Algorithms.Array_Hashset;

public static class SearchSorted2DArray
{
    public static bool Find(int[][] arr, int N, int M, int target)
    {
        int max = (N * M) - 1;
        return Search(arr, M, target, 0, max);
    }

    public static bool Search(int[][] arr, int M, int target, int low, int high)
    {
        int mid = (low + high) / 2;

        if (mid == low || mid == high)
        {
            return false;
        }

        int row = mid / M;
        int col = mid % M;

        int current = arr[row][col];
        if (current == target)
        {
            return true;
        }

        if (current > target) {
            return Search(arr, M, target, low, mid);
        }
        return Search(arr, M, target, mid + 1, high);
    }
}