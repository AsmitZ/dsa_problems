using Xunit;

namespace Algorithms.Array_Hashset;

public class SetMatrixZero
{
    public int[][] SetZeroes(int[][] matrix)
    {
        var rows = matrix.Length;
        var cols = matrix[0].Length;
        var rowZero = false;
        var colZero = false;

        // Check if the first row and first column need to be zeroed
        for (var i = 0; i < rows; i++)
        {
            if (matrix[i][0] == 0)
            {
                colZero = true;
                break;
            }
        }

        for (var j = 0; j < cols; j++)
        {
            if (matrix[0][j] == 0)
            {
                rowZero = true;
                break;
            }
        }

        // Use the first row and first column to mark zeroes
        for (var i = 1; i < rows; i++)
        {
            for (var j = 1; j < cols; j++)
            {
                if (matrix[i][j] == 0)
                {
                    matrix[i][0] = 0;
                    matrix[0][j] = 0;
                }
            }
        }

        // Zero out cells based on marks in the first row and column
        for (var i = 1; i < rows; i++)
        {
            for (var j = 1; j < cols; j++)
            {
                if (matrix[i][0] == 0 || matrix[0][j] == 0)
                {
                    matrix[i][j] = 0;
                }
            }
        }

        // Zero out the first row if needed
        if (rowZero)
        {
            for (var j = 0; j < cols; j++)
            {
                matrix[0][j] = 0;
            }
        }

        // Zero out the first column if needed
        if (colZero)
        {
            for (var i = 0; i < rows; i++)
            {
                matrix[i][0] = 0;
            }
        }

        return matrix;
    }
}

public class SetMatrixZeroTests
{
    [Fact]
    public void TestSetZeroes()
    {
        var matrix = new[]
        {
            new[] { 1, 1, 1 },
            new[] { 1, 0, 1 },
            new[] { 1, 1, 1 }
        };

        var expected = new[]
        {
            new[] { 1, 0, 1 },
            new[] { 0, 0, 0 },
            new[] { 1, 0, 1 }
        };

        var smz = new SetMatrixZero();
        var result = smz.SetZeroes(matrix);

        Assert.Equal(expected, result);
    }
}