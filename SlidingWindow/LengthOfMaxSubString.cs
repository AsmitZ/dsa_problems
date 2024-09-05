using Xunit;

namespace Algorithms.SlidingWindow;

public class LengthOfMaxSubString
{
    public int Compute(string s)
    {
        var charSet = new HashSet<char>();
        int left = 0;
        int maxLength = 0;
        
        for (int right = 0; right < s.Length; right++)
        {
            while (charSet.Contains(s[right]))
            {
                charSet.Remove(s[left]);
                left++;
            }
            charSet.Add(s[right]);
            
            maxLength = Math.Max(maxLength, right - left + 1);
        }
        
        return maxLength;
    }
}

public class LengthOfMaxSubStringTest
{
    [Fact]
    public void MustComputeLengthOfMaxSubString()
    {
        var s = "abcabcde";
        var res = 5;
        var lengthOfMaxSubString = new LengthOfMaxSubString();
        Assert.Equal(res, lengthOfMaxSubString.Compute(s));
    }
}