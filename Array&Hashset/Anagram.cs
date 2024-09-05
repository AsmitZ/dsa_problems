using Xunit;

namespace Algorithms.Array_Hashset;

public class Anagram
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;

        var hash1 = new Dictionary<char, int>();
        foreach (var i in s)
        {
            if (!hash1.TryAdd(i, 1))
            {
                hash1[i]++;
            }
        }
    
        var hash2 = new Dictionary<char, int>();
        foreach (var i in t)
        {
            if (!hash2.TryAdd(i, 1))
            {
                hash2[i]++;
            }
        }
    
        const bool isAnagram = true;
        foreach (var i in hash1)
        {
            if (!hash2.TryGetValue(i.Key, out var value) || value != i.Value)
            {
                return false;
            }
        }

        return isAnagram;
    }
}

public class AnagramTest
{
    [Fact]
    public void MustVerifyIsAnagram()
    {
        var a = "tat";
        var b = "att";
        var anagram = new Anagram();
        Assert.True(anagram.IsAnagram(a, b));
    }

    [Fact]
    public void MustVerifyIsNotAnagram()
    {
        var a = "teacher";
        var b = "student";
        var anagram = new Anagram();
        Assert.False(anagram.IsAnagram(a, b));
    }
}