using Xunit;

namespace Algorithms.Array_Hashset;

public class ValidSudoku
{
    public bool IsValidSudoku(char[][] board)
    {
        for (int i = 0; i < 9; i++)
        {
            var set1 = new char[9];
            for (int j = 0; j < 9; j++)
            {
                if (IsInvalid(set1, board[i][j], j))
                {
                    return false;
                }
            }

            var set2 = new char[9];
            for (int j = 0; j < 9; j++)
            {
                if (IsInvalid(set2, board[j][i], j))
                {
                    return false;
                }
            }
        }

        var set3 = new Dictionary<(int, int), List<char>>();
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                var c = board[i][j];
                if (c == '.') continue;
                int x = i / 3;
                int y = j / 3;
                if (set3.TryGetValue((x, y), out var list) && list.Contains(c)){
                    return false;
                }
                if (!set3.ContainsKey((x, y)))
                {
                    set3[(x, y)] = new List<char> { c };
                }
                else
                {
                    set3[(x, y)].Add(c);
                }
            }
        }

        return true;
    }

    private bool IsInvalid(char[] set, char c, int index)
    {
        if (c == '.') return false;
        if (set.Contains(c)) return true;
        set[index] = c;
        return false;
    }
}

public class ValidSudokuTest
{
    [Fact]
    public void MustBeAInValidSudoku()
    {
        var sudoku = new ValidSudoku();
        var board = new char[][]
        {
            ['5', '3', '.', '.', '7', '.', '.', '.', '.'],
            ['6', '8', '.', '1', '9', '5', '.', '.', '.'],
            ['.', '9', '8', '.', '.', '.', '.', '6', '.'], 
            ['8', '.', '.', '.', '6', '.', '.', '.', '3'],
            ['4', '.', '.', '8', '.', '3', '.', '.', '1'], 
            ['7', '.', '.', '.', '2', '.', '.', '.', '6'],
            ['.', '6', '.', '.', '.', '.', '2', '8', '.'], 
            ['.', '.', '.', '4', '1', '9', '.', '.', '5'],
            ['.', '.', '.', '.', '8', '.', '.', '7', '9']
        };
        var isValid = sudoku.IsValidSudoku(board);
        Assert.False(isValid);
    }
}