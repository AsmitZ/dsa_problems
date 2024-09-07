using Xunit;

namespace Algorithms.Array_Hashset;

public class EncodingDecoding
{
    public string Encode(IList<string> strs) {
        var res = string.Empty;
        foreach(string str in strs){
            var strLen = str.Length;
            res = $"{res}{strLen}#{str}";
        }
        return res;
    }
    
    public List<string> Decode(string s)
    {
        var res = new List<string>();
        var i = 0;
        while (i < s.Length)
        {
            var j = i;
            while(s[j] != '#'){
                j++;
            }

            var strLen = int.Parse(s.Substring(i, j - i));
            res.Add(s.Substring(j + 1, strLen));
            i = j + 1 + strLen;
        }
        
        return res;
    }
}

public class EncodingDecodingTest
{
    [Fact]
    public void Test_Encode()
    {
        var strs = new List<string> { "abc1#", "def:", "ghi" };
        var encodingDecoding = new EncodingDecoding();
        var res = encodingDecoding.Encode(strs);
        Assert.Equal("5#abc1#4#def:3#ghi", res);
    }
    
    [Fact]
    public void Test_Decode()
    {
        var s = "5#abc1#4#def:3#ghi";
        var encodingDecoding = new EncodingDecoding();
        var res = encodingDecoding.Decode(s);
        Assert.Equal(3, res.Count);
        Assert.Equal("abc1#", res[0]);
        Assert.Equal("def:", res[1]);
        Assert.Equal("ghi", res[2]);
    }
}