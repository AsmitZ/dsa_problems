
public class Solution {
    public int NumIslands(char[][] grid) {

        if (grid == null || grid.Length == 0)
            return 0;

        int rows = grid.Length;
        int cols = grid[0].Length;
        int islandCount = 0;

        for (int r = 0; r < rows; r++)
        {
            for(int c = 0; c < cols; c++)
            {
                if (grid[r][c] == '1')
                {
                    islandCount++;
                    Bfc(r, c, grid);
                }
            }
        }
        return islandCount;
    }

    private void Bfc(int r, int c, char[][] grid)
    {
        int rows = grid.Length;
        int cols = grid[0].Length;

        Queue<(int r, int c)> queue = new();
        queue.Enqueue((r, c));
        grid[r][c] = '0';

        int[] dr = [1, 0, -1, 0];
        int[] dc = [0, 1, 0, -1];

        while (queue.Count > 0)
        {
            var (nr, nc) = queue.Dequeue();

            for (int i = 0; i < 4; i++)
            {
                var cr = nr + dr[i];
                var cc = nc + dc[i];

                if (cr >= 0 && cc >= 0 &&
                    cr < rows && cc < cols &&
                    grid[cr][cc] == '1')
                {
                    queue.Enqueue((cr, cc));
                    grid[cr][cc] = '0';
                }
            }

        }
    }

    private void Dfs(char[][] grid, int r, int c)
    {
        int rows = grid.Length;
        int cols = grid[0].Length;

        // boundary and water check
        if (r < 0 || c < 0 || r >= rows || c >= cols || grid[r][c] == '0')
            return;

        // mark as visited
        grid[r][c] = '0';

        // explore all 4 directions
        Dfs(grid, r + 1, c);
        Dfs(grid, r - 1, c);
        Dfs(grid, r, c + 1);
        Dfs(grid, r, c - 1);
    }
}