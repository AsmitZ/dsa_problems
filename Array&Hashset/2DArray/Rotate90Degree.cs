namespace Algorithms.Array_Hashset;

// Question - https://takeuforward.org/data-structure/rotate-image-by-90-degree/
public static class Rotate90Degree
{
    public static void Rotate(int[][] matrix)
    {
        Print(matrix);

        // 1. Transpose the matrix
        for (int r = 0; r < matrix.Length - 1; r++)
        {
            for (int c = r; c < matrix[0].Length; c++)
            {
                int temp = 0;
                temp = matrix[r][c];
                matrix[r][c] = matrix[c][r];
                matrix[c][r] = temp;
            }
        }

        // 2. Reverse the rows 
        for (int r = 0; r < matrix.Length; r++)
        {
            for (int c = 0; c < matrix[0].Length / 2; c++)
            {
                int temp = 0;
                int last = matrix.Length - 1 - c;
                temp = matrix[r][c];
                matrix[r][c] = matrix[r][last];
                matrix[r][last] = temp;
            }
        }

        Print(matrix);
    }

    private static void Print(int[][] matrix)
    {
        for (int r = 0; r < matrix.Length; r++)
        {
            for (int c = 0; c < matrix[0].Length; c++)
            {
                Console.Write(matrix[r][c] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}