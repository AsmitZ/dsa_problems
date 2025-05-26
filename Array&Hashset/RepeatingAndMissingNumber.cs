namespace Algorithms.Array_Hashset;

// Question - https://takeuforward.org/data-structure/find-the-repeating-and-missing-numbers/
public static class RepeatingAndMissingNumber
{
    public static (int, int) FindUsingMaths(int[] arr)
    {
        int n = arr.Length;
        int sn = (n * (n + 1)) / 2;
        int s = 0;
        foreach (int i in arr)
        {
            s += i;
        }

        // sn - s = x-y; 
        // x is missing (needs to be added) and y is repeating (it will be substracted twice)
        int xSubY = sn - s;

        long sn2 = (n * (n + 1) * ((2 * n) + 1)) / 6;
        long s2 = 0;
        foreach (int i in arr)
        {
            s2 += i * i;
        }

        // s2n - s2 = x2 - y2
        // (s2n - s2) / (x-y) = x + y;
        long xPlusY = (sn2 - s2) / xSubY;

        long x = (xSubY + xPlusY) / 2;
        long y = xPlusY - x;

        System.Console.WriteLine($"Repeating number is {x}");
        System.Console.WriteLine($"Missing number is {y}");
        return ((int)x, (int)y);
    }

    public static (int, int) FindUsingBitManipulation(int[] arr)
    {
        int n = arr.Length;
        int xor = 0;
        for (int i = 0; i < n; i++)
        {
            xor ^= arr[i];
            xor ^= i + 1;
        }

        // find first one bit index
        int oneBit = 0;
        while (true)
        {
            if ((xor & (1 << oneBit)) != 0)
            {
                break;
            }
            oneBit++;
        }

        int oneBitNumber = 1 << oneBit;
        int zero = 0;
        int one = 0;

        for (int i = 0; i < n; i++)
        {
            // for items in array
            if ((arr[i] & oneBitNumber) != 0)
            {
                one ^= arr[i];
            }
            else
            {
                zero ^= arr[i];
            }

            // for 1 to N number
            if (((i + 1) & oneBitNumber) != 0)
            {
                one ^= i + 1;
            }
            else
            {
                zero ^= i + 1;
            }
        }

        foreach (int i in arr)
        {
            if (i == one)
            {
                System.Console.WriteLine($"Repeating number is {one}");
                System.Console.WriteLine($"Missing number is {zero}");
                return (one, zero);
            }
        }

        System.Console.WriteLine($"Repeating number is {zero}");
        System.Console.WriteLine($"Missing number is {one}");

        return (zero, one);
    }
}