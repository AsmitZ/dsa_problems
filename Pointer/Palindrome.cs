using Xunit;

namespace Algorithms.Pointor;

public class Palindrome
{
    public bool IsPalindrome(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            while (left < right && !IsAlphanumeric(s[left]))
            {
                left++;
            }

            while (right > left && !IsAlphanumeric(s[right]))
            {
                right--;
            }
            
            if (left > right) return false;
            
            if (char.ToLower(s[left]) != char.ToLower(s[right]))
            {
                return false;
            }
            
            left++;
            right--;
        }

        return true;
    }

    public bool IsAlphanumeric(char c) => c is >= 'a' and <= 'z' or >= 'A' and <= 'Z' or >= '0' and <= '9';
}

public class PalindromeTest
{
    [Fact]
    public void Test_IsPalindrome()
    {
        var str = "Was it a car or a cat I saw?";
        var palindrome = new Palindrome();
        Assert.True(palindrome.IsPalindrome(str));
    }
}