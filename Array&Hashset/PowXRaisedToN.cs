using System.Runtime.InteropServices.Marshalling;

namespace Algorithms.Array_Hashset;

public static class PowXRaisedToN
{
    public static double Pow(double x, int n)
    {
        if (x == 0) return 0;

        int nn = n;
        double ans = 1;

        if (n < 0)
        {
            nn = -1 * nn;
        }

        while (nn > 0)
        {
            if (nn % 2 == 1)
            {
                ans = ans * x;
                nn = nn - 1;
            }
            else
            {
                x = x * x;
                nn = nn / 2;
            }
        }

        if (n < 0)
        {
            ans = 1 / ans;    
        }

        System.Console.WriteLine(ans);
        return ans;
    }
}