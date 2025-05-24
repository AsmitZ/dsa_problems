namespace Algorithms.Array_Hashset;

// Question - https://takeuforward.org/data-structure/sort-an-array-of-0s-1s-and-2s/
public static class InPaceSort0s1s2s
{
    public static int[] Sort(int[] arr)
    {
        int onePointer = 0;
        int twoPointer = 0;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == 0)
            {
                Console.WriteLine("current elemnt is 0");
                if (i >= onePointer)
                {
                    Console.WriteLine($"Swapping index {i} and {onePointer}");
                    Swap(arr, i, onePointer);
                    onePointer++;

                    if (twoPointer <= onePointer)
                    {
                        twoPointer = onePointer;
                    }
                }
            }

            if (arr[i] == 1)
            {
                Console.WriteLine("current elemnt is 1");
                if (i >= twoPointer)
                {
                    Console.WriteLine($"Swapping index {i} and {twoPointer}");
                    Swap(arr, i, twoPointer);
                    twoPointer++;
                }
            }
        }

        Print(arr);
        return arr;
    }

    public static void Print(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }

    public static void Swap(int[] arr, int i, int j)
    {
        if (i == j)
        {
            return;
        }

        arr[i] = arr[i] + arr[j];
        arr[j] = arr[i] - arr[j];
        arr[i] = arr[i] - arr[j];
    }
}