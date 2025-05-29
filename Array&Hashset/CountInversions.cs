
namespace Algorithms.Array_Hashset;

public static class CountInversions
{
    public static int Count(int[] arr)
    {
        var result = MergeSort(arr, 0, arr.Length - 1);
        System.Console.WriteLine(result);
        return result;
    }

    private static int MergeSort(int[] arr, int low, int high)
    {
        int count = 0;
        if (low >= high) return count;
        int mid = (low + high) / 2;
        count += MergeSort(arr, low, mid);
        count += MergeSort(arr, mid + 1, high);
        count += Merge(arr, low, mid, high);

        return count;
    }

    private static int Merge(int[] arr, int low, int mid, int high)
    {
        int left = low;
        int right = mid + 1;
        var temp = new List<int>();

        int count = 0;

        while (left <= mid && right <= high)
        {
            if (arr[left] < arr[right])
            {
                temp.Add(arr[left]);
                left++;
            }
            else
            {
                temp.Add(arr[right]);
                count += mid - left + 1;
                right++;
            }
        }
        // if elements on the left half are still left //
        while (left <= mid)
        {
            temp.Add(arr[left]);
            left++;
        }

        //  if elements on the right half are still left //
        while (right <= high)
        {
            temp.Add(arr[right]);
            right++;
        }

        // transfering all elements from temporary to arr //
        for (int i = low; i <= high; i++)
        {
            arr[i] = temp[i - low];
        }

        return count;
    }
}