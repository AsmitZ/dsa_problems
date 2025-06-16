namespace Algorithms.Array_Hashset;

public class ReversePairs
{
    public int Find(int[] nums)
    {
        int n = nums.Length - 1;
        int result = MergeSort(nums, 0, n);
        return result;
    }

    private int MergeSort(int[] nums, int low, int high)
    {

        if (low >= high) return 0;

        int mid = (low + high) / 2;
        int c = 0;

        c += MergeSort(nums, low, mid);
        c += MergeSort(nums, mid + 1, high);

        c += CountPairs(nums, low, mid, high);
        Merge(nums, low, mid, high);

        return c;
    }

    private int CountPairs(int[] nums, int low, int mid, int high)
    {
        Console.WriteLine($"Low {low}, mid {mid} high {high}");
        int right = mid + 1;
        int c = 0;

        for (int i = low; i <= mid; i++)
        {
            while (right <= high && nums[i] > 2L * nums[right])
            {
                right++;
            }
            c += right - (mid + 1);
        }

        return c;
    }

    private void Merge(int[] arr, int low, int mid, int high)
    {
        int left = low;
        int right = mid + 1;
        var temp = new List<int>();

        while (left <= mid && right <= high)
        {
            if (arr[left] <= arr[right])
            {
                temp.Add(arr[right]);
                right++;
            }
            else
            {
                temp.Add(arr[left]);
                left++;
            }
        }

        while (left <= mid)
        {
            temp.Add(arr[left]);
            left++;
        }

        while (right <= high)
        {
            temp.Add(arr[right]);
            right++;
        }

        for (int i = low; i <= high; i++)
        {
            arr[i] = temp[i - low];
        }
    }
}