namespace Algorithms.GreedyAlgorithm;

public static class AssginCookiee
{
    public static int FindContentChildren(int[] g, int[] s)
    {
        if (s.Length == 0 || g.Length == 0) return 0;

        //sort
        Array.Sort(g);
        Array.Sort(s);

        int maxChilden = 0;
    
        int i = 0;
        int j = 0;

        while (i < g.Length && j < s.Length)
        {
            if (s[j] >= g[i])
            {
                maxChilden += 1;
                i++;
                j++;
            }
            else
            {
                j++;
            }
        }
        
        return maxChilden;
    }
}