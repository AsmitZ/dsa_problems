namespace Algorithms.Array_Hashset;

// Question - https://takeuforward.org/data-structure/merge-overlapping-sub-intervals/
public static class MergeOverlappingSubInterval
{
    public static void Merge(int[][] input)
    {
        Print(input);

        Array.Sort(input, Comparer<int[]>.Create((a, b) => a[0].CompareTo(b[0])));

        var result = new List<int[]>
        {
            input[0]
        };

        int lastIndex = 0;

        for (int i = 1; i < input.Length; i++)
        {
            int previousEnd = result[lastIndex][1];
            int currentStart = input[i][0];

            if (currentStart <= previousEnd)
            {
                result[lastIndex] = [result[lastIndex][0], input[i][1]];
            }
            else
            {
                lastIndex++;
                result.Add(input[i]);
            }
        }

        Print([.. result]);
    }

    private static void Print(int[][] input)
    {
        for (int r = 0; r < input.Length; r++)
        {
            for (int c = 0; c < input[0].Length; c++)
            {
                Console.Write(input[r][c] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}