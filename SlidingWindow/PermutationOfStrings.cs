using Xunit;

namespace Algorithms.SlidingWindow;

public class PermutationOfStrings
{
    public bool CheckInclusion(string s1, string s2)
    {
        if (s1.Length > s2.Length)
        {
            return false;
        }
        
        var dict1 = new Dictionary<char, int>();
        var dict2 = new Dictionary<char, int>();
        
        int i = 0;
        while (i < 26)
        {
            dict1[(char)('a' + i)] = 0;
            dict2[(char)('a' + i)] = 0;
            i++;
        }
        
        for (int j = 0; j < s1.Length; j++)
        {
            dict1[s1[j]]++;
            dict2[s2[j]]++;
        }

        var matching = 0;
        // Count matching elements between dict1 and dict2
        for (int j = 0; j < dict1.Count; j++)
        {
            if (dict1[(char)('a' + j)] == dict2[(char)('a' + j)])
            {
                matching++;
            }
        }
        
        var start = 0;
        var end = s1.Length - 1;
        while (end < s2.Length)
        {
            if (matching == dict1.Count)
            {
                return true;
            }
            
            end++;
            if (end < s2.Length)
            {
                dict2[s2[end]]++;
                if (dict2[s2[end]] == dict1[s2[end]])
                {
                    matching++;
                }
                else if (dict2[s2[end]] == dict1[s2[end]] + 1)
                {
                    matching--;
                }
                
                dict2[s2[start]]--;
                if (dict2[s2[start]] == dict1[s2[start]] - 1)
                {
                    matching--;
                }
                else if (dict2[s2[start]] == dict1[s2[start]])
                {
                    matching++;
                }
                start++;
            }
        }
        
        return matching == dict1.Count;
    }
}

// test case
public class PermutationOfStringsTest
{
    [Fact]
    public void Test()
    {
        var s1 = "ab";
        var s2 = "eidboaoo";
        var po = new PermutationOfStrings();
        var result = po.CheckInclusion(s1, s2);
        Assert.False(result);
    }
    
    [Fact]
    public void Test2()
    {
        var s1 = "ab";
        var s2 = "eidbaooo";
        var po = new PermutationOfStrings();
        var result = po.CheckInclusion(s1, s2);
        Assert.True(result);
    }
}