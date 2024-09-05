using Xunit;

namespace Algorithms.Array_Hashset;

public class GroupAnagram
{
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
        var anagrams = new Dictionary<string, List<string>>();
        
        foreach (var str in strs)
        {
            var charCount = new int[26];
            
            foreach (var c in str)
            {
                charCount[c - 'a']++;
            }
            
            var key = string.Join(',', charCount);

            if (anagrams.TryGetValue(key, out var list))
            {
                list.Add(str);
            }
            else
            {
                anagrams[key] = new List<string> { str };
            }
        }

        return anagrams.Values.ToList();
    }
}

public class GroupAnagramTest
{
    [Fact]
    public void MustVerifyExactAnagramCount()
    {
        var anagrams = new []{"act", "tac", "cat", "god", "dog"};
        var grouper = new GroupAnagram();
        Assert.Equal(2, grouper.GroupAnagrams(anagrams).Count);
    }

    [Fact]
    public void MustVerifyInValidAnagramCount()
    {
        var anagrams = new []{"act", "tac", "cat", "god", "dog"};
        var grouper = new GroupAnagram();
        Assert.NotEqual(3, grouper.GroupAnagrams(anagrams).Count);
    }
}
