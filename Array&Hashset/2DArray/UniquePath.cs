namespace Algorithms.Array_Hashset;

public static class UniquePath
{
    public static int FindByCombination(int m, int n)
    {
        int N = m + n - 2;
        int r = m - 1;
        if (n < m) r = n - 1;

        int res = 1;
        for (int i = 1; i <= r; i++)
        {
            res = res * (N - r + i) / i;
        }

        System.Console.WriteLine($"Total paths are {res}");

        return res;
    }

    public static int FindByRescursion(int m, int n)
    {
        int res = CountPath(m, n, 0, 0);

        System.Console.WriteLine($"Total paths are {res}");

        return res;
    }

    public static int FindByDPRecursion(int m, int n)
    {
        int[][] dp = new int[m][];

        for (int i = 0; i < m; i++)
        {
            dp[i] = new int[n];
            for (int j = 0; j < n; j++)
            {
                dp[i][j] = -1;
            }
        }

        int res = CountPathWithDP(m, n, 0, 0, dp);

        System.Console.WriteLine($"Total paths are {res}");

        return res;
    }

    private static int CountPath(int m, int n, int i, int j)
    {
        if (i >= m || j >= n) return 0;
        if (i == m - 1 && j == n - 1) return 1;

        return CountPath(m, n, i + 1, j) + CountPath(m, n, i, j + 1);
    }
    private static int CountPathWithDP(int m, int n, int i, int j, int[][] dp)
    {
        if (i >= m || j >= n) return 0;
        if (i == m - 1 && j == n - 1) return 1;

        int down = 0;
        if (i + 1 < m)
        {
            down = dp[i + 1][j];
            if (down == -1)
            {
                down = CountPathWithDP(m, n, i + 1, j, dp);
                dp[i + 1][j] = down;
            }
        }

        int right = 0;
        if (j + 1 < n)
        {
            right = dp[i][j + 1];
            if (right == -1)
            {
                right = CountPathWithDP(m, n, i, j + 1, dp);
                dp[i][j + 1] = right;
            }
        }

        return down + right;
    }
}