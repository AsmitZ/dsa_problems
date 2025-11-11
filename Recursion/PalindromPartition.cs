namespace Algorithms.Recursion;

public static class PalindromPartition
{
    public static IList<IList<string>> Find(string s)
    {
        var result = new List<IList<string>>();
        CheckPartition(s, 0, [], result);
        return result;
    }

    private static void CheckPartition(string s, int index, List<string> substring,
        List<IList<string>> palindroms)
    {
        if (index == s.Length)
        {
            palindroms.Add([.. substring]);
            return;
        }

        for (int i=index+1; i <= s.Length; i++)
        {
            var str = s[index..i];
            if (!IsPalindrome(str))
                continue;

            substring.Add(str);
            CheckPartition(s, i, substring, palindroms);
            substring.RemoveAt(substring.Count - 1);
        }
    }

    private static bool IsPalindrome(string input)
    {
        if (string.IsNullOrEmpty(input))
            return false;

        int left = 0;
        int right = input.Length - 1;

        while (left < right)
        {
            while (left < right && !char.IsLetterOrDigit(input[left]))
                left++;
            while (left < right && !char.IsLetterOrDigit(input[right]))
                right--;

            // Compare ignoring case
            if (char.ToLowerInvariant(input[left]) != char.ToLowerInvariant(input[right]))
                return false;

            left++;
            right--;
        }

        return true;
    }
}