namespace Algorithms.BinarySearch;

static class KthElementOfTwoSortedArray
{
    public static int Find(int[] a, int[] b, int k)
    {
        // Take a as the smallest array
        if (a.Length > b.Length)
        {
            return Find(b, a, k);
        }

        int n = a.Length;
        int m = b.Length;

        // take low as 0 or min no to be taken considering all array 2 element
        int low = Math.Max(0, k - m);
        // take high as k element or length of array 1
        int high = Math.Min(k, n);
        // left is the first element of array 2
        int left = k;

        while (low <= high)
        {
            int mid1 = (low + high) / 2;
            int mid2 = left - mid1;

            int l1 = mid1 > 0 ? a[mid1 - 1] : int.MinValue;
            int l2 = mid2 > 0 ? b[mid2 - 1] : int.MinValue;
            int r1 = mid1 < n ? a[mid1] : int.MaxValue;
            int r2 = mid2 < m ? b[mid2] : int.MaxValue;

            if (l1 <= r2 && l2 <= r1)
            {
                return Math.Max(l1, l2);
            }

            if (l1 > r2)
            {
                high = mid1 - 1;
            }
            else
            {
                low = mid1 + 1;
            }
        }
        return -1;
    }
}