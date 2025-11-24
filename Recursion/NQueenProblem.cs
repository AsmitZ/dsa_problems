
namespace Algorithms.Recursion;

public static class NQueenProblem
{
    public static IList<IList<string>> Solve(int N)
    {
        var result = new List<IList<string>>();
        var board = Enumerable.Range(0, N)
                      .Select(_ => Enumerable.Repeat('.', N).ToArray())
                      .ToArray();
        // for row check
        var leftRow = Enumerable.Repeat(0, N).ToArray();
        var lowerDiagonal = Enumerable.Repeat(0, 2 * N -1).ToArray();
        var upperDiagonal = Enumerable.Repeat(0, 2 * N - 1).ToArray();

        Solve(0, N, result, board, leftRow, lowerDiagonal, upperDiagonal);
        return result;
    }

    private static void Solve(int col, int N, List<IList<string>> result, char[][] board,
        int[] leftRow, int[] lowerDiagonal, int[] upperDiagonal)
    {
        if (col == N)
        {
            var temp = new List<string>();
            for (int i = 0; i < N; i++)
            {
                temp.Add(new string(board[i]));
            }
            result.Add(temp);
            return;
        }

        for (int row = 0; row < N; row++)
        {
            if (leftRow[row] == 0 && lowerDiagonal[col + row] == 0 && upperDiagonal[N - 1 + col - row] == 0)
            {
                leftRow[row] = 1;
                lowerDiagonal[col + row] = 1;
                upperDiagonal[N - 1 + col - row] = 1;
                board[row][col] = 'Q';

                Solve(col + 1, N, result, board, leftRow, lowerDiagonal, upperDiagonal);

                leftRow[row] = 0;
                lowerDiagonal[col + row] = 0;
                upperDiagonal[N - 1 + col - row] = 0;
                board[row][col] = '.';
            }
        }
    }
}