using Xunit;

namespace Problems.Stack;

public class GenerateParentheses
{
    public List<string> Generate(int n)
    {
        var queue = new Queue<char>();
        var result = new List<string>();

        void Backtrack(int openCount, int closeCount)
        {
            if (openCount == n && closeCount == n)
            {
                result.Add(string.Join("", queue));
                return;
            }
            
            if (openCount < n)
            {
                queue.Enqueue('(');
                Backtrack(openCount + 1, closeCount);
                queue.Dequeue();
            }

            if (closeCount < openCount)
            {
                queue.Enqueue(')');
                Backtrack(openCount, closeCount + 1);
                queue.Dequeue();
            }
        }
        
        Backtrack(0, 0);
        return result;
    }
}

public class GenerateParenthesesTests
{
    [Fact]
    public void GenerateValidParentheses()
    {
        var n = 3;
        var expected = new List<string> { "((()))", "(()())", "(())()", "()(())", "()()()" };
        var generator = new GenerateParentheses();
        var result = generator.Generate(n);
        Assert.Equal(expected, result);
    }
}