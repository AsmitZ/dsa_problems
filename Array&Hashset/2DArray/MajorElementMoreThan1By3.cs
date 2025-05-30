namespace Algorithms.Array_Hashset;

public static class MajorElementMoreThan1By3
{
    public static List<int> Find(int[] nums)
    {
        int n = nums.Length;

        if (n == 0) return [];

        int e1 = int.MinValue;
        int e2 = int.MinValue;
        int c1 = 0;
        int c2 = 0;
        int i = 0;

        while (i < n)
        {
            int num = nums[i];
            if (c1 == 0 && num != e2)
            {
                e1 = num;
                c1 = 1;
            }
            else if (c2 == 0 && num != e1)
            {
                c2 = 1;
                e2 = num;
            }
            else if (e1 == num)
            {
                c1++;
            }
            else if (e2 == num)
            {
                c2++;
            }
            else
            {
                c1--;
                c2--;
            }

            i++;
        }

        int finalc1 = 0;
        int finalc2 = 0;
        for (int j = 0; j < n; j++)
        {
            if (nums[j] == e1) finalc1++;
            if (nums[j] == e2) finalc2++;
        }

        List<int> result = [];
        if (e1 > int.MinValue && finalc1 > n / 3)
        {
            result.Add(e1);
        }
        if (e2 > int.MinValue && finalc2 > n / 3)
        {
            result.Add(e2);
        }

        return result;
    }
}