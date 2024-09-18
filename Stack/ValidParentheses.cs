using Xunit;

namespace Problems.Stack;

public class ValidParentheses
{
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();

        var map = new Dictionary<char, char>
        {
            { '}', '{' }, {')', '('}, {']', '['}
        };
        
        foreach (var c in s)
        {
            if (stack.Count > 0 && map.Keys.Contains(c))
            {
                if (map[c] == stack.First())
                {
                    stack.Pop();
                }
                else
                    return false;
            }
            else
            {
                stack.Push(c);
            }
        }

        return stack.Count == 0;
    }
}

public class ValidParenthesesTest
{
    [Theory]
    [InlineData("[[]](){}")]
    [InlineData("([])")]
    public void IsValid(string s)
    {
        var validParentheses = new ValidParentheses();
        var result = validParentheses.IsValid(s);
        
        Assert.True(result);
    }

    [Theory]
    [InlineData("(((({}[)]}))))")]
    public void IsInValid(string s)
    {
        var validParentheses = new ValidParentheses();
        var result = validParentheses.IsValid(s);
        
        Assert.False(result);
    }
}