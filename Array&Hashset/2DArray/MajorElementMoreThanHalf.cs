namespace Algorithms.Array_Hashset;

public static class MajorElementMoreThanHalf
{
    public static int Find(int[] arr)
    {
        int n = arr.Length;
        int element = -1;

        if (n == 0) return element;

        int ctr = 0;
        int i = 0;
        while (i < n)
        {
            if (ctr == 0)
            {
                ctr = 1;
                element = arr[i];
            }
            else if (element == arr[i])
            {
                ctr++;
            }
            else
            {
                ctr--;
            }
            i++;
        }

        int majorCtr = 0;
        for (int j = 0; j < n; j++)
        {
            if (arr[j] == element)
            {
                majorCtr++;
            }
        }

        if (majorCtr <= n / 2)
        {
            return -1;
        }
        return element;
    }
}