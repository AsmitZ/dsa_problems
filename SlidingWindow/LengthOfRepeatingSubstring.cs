using Xunit;

namespace Algorithms.SlidingWindow;

public class LengthOfRepeatingSubstring
{
    public int Compute(string s, int k)
    {
        var stringMap = new Dictionary<char, int>();
        var res = 0;
        var maxF = 0;
        var left = 0;

        for(int right = 0; right < s.Length; right++){
            if(stringMap.TryGetValue(s[right], out int count)){
                count++;
                stringMap[s[right]] = count;
            }
            else{
                stringMap[s[right]] = 1;
            }
            maxF = Math.Max(maxF, stringMap[s[right]]);

            while( (right - left + 1) - maxF > k)
            {
                stringMap[s[left]]--;
                left++;
            }
            
            res = Math.Max(res, right - left + 1);
        }
        return res;
    }
}

public class LengthOfRepeatingSubstringTest
{
    [Fact]
    public void MustComputeTheLengthOfRepeatingSubString()
    {
        var s = "AABABBA";
        var k = 1;
        var res = 4;
        var lengthOfRepeatingSubstring = new LengthOfRepeatingSubstring();
        Assert.Equal(res, lengthOfRepeatingSubstring.Compute(s, k));
    }
}