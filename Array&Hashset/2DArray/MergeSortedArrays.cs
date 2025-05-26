namespace Algorithms.Array_Hashset;

// Question - https://takeuforward.org/data-structure/merge-two-sorted-arrays-without-extra-space/
public static class MergeSortedArrays
{
    public static void Merge(int[] arr1, int[] arr2, int n, int m)
    {
        int len = n + m;
        int gap = len / 2 + len % 2;

        while (gap > 0)
        {
            int left = 0;
            int right = left + gap;
            while (right < len)
            {
                if (left < n && right >= n)
                {
                    SwapIfGreater(arr1, arr2, left, right - n);
                }
                else if (left >= n)
                {
                    SwapIfGreater(arr2, arr2, left - n, right - n);
                }
                else
                {
                    SwapIfGreater(arr1, arr1, left, right);
                }

                left++; right++;
            }

            if (gap == 1) break;
            gap = (gap / 2) + (gap % 2);
        }
        Print(arr1, arr2);
    }

    private static void SwapIfGreater(int[] arr1, int[] arr2, int i, int j)
    {
        if (arr1[i] > arr2[j])
        {
            int temp = arr1[i];
            arr1[i] = arr2[j];
            arr2[j] = temp;
        }
    }

    private static void Print(int[] arr1, int[] arr2)
    {
        for (int i = 0; i < arr1.Length; i++)
        {
            Console.Write(arr1[i] + " ");
        }
        System.Console.WriteLine();

        for (int i = 0; i < arr2.Length; i++)
        {
            Console.Write(arr2[i] + " ");
        }
    }
}