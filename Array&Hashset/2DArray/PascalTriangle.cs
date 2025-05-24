using Xunit;

namespace Algorithms.Array_Hashset;

// Question - https://takeuforward.org/data-structure/program-to-generate-pascals-triangle/
public static class PascalTriangle
{
    public static int nCr(int n, int r)
    {
        int result = 1;
        for (int i = 0; i < r; i++)
        {
            result *= n - i;
            result /= i + 1;
        }

        return result;
    }

    public static int GetElement(int row, int col)
    {
        int result = nCr(row - 1, col - 1);
        Console.WriteLine($"Element at row, col ({row},{col}) is {result}");
        return result;
    }

    public static void PrintNthRow(int n)
    {
        int num = 1;
        Console.Write($"{num} ");
        for (int i = 1; i < n; i++)
        {
            num = num * (n - i) / i;
            Console.Write($"{num} ");
        }
    }

    public static int[][] GetPascalTriangle(int n)
    {
        if (n <= 0)
        {
            return [];
        }

        int[][] triangle = new int[n][];

        for (int i = 1; i <= n; i++)
        {
            triangle[i - 1] = GetNthRow(i);
            Console.WriteLine(string.Join(" ", triangle[i - 1]));
        }

        return triangle;
    }

    private static int[] GetNthRow(int n)
    {
        int[] row = new int[n];
        row[0] = 1;
        for (int i = 1; i < n; i++)
        {
            row[i] = row[i - 1] * (n - i) / i;
        }

        return row;
    }
}

public class PascalTriangleTest
{
    [Fact]
    public void TestGetElement()
    {
        Assert.Equal(1, PascalTriangle.GetElement(1, 1));
        Assert.Equal(1, PascalTriangle.GetElement(2, 1));
        Assert.Equal(1, PascalTriangle.GetElement(2, 2));
        Assert.Equal(1, PascalTriangle.GetElement(3, 1));
        Assert.Equal(2, PascalTriangle.GetElement(3, 2));
        Assert.Equal(1, PascalTriangle.GetElement(3, 3));
    }

}