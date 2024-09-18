using Xunit;

namespace Problems.Stack;

public class EvaluateRPN
{
    public int EvalRPN(string[] tokens)
    {
        var stack = new Stack<int>();
        foreach (var token in tokens)
        {
            if (token == "+")
            {
                stack.Push(stack.Pop() + stack.Pop());
            }
            else if (token == "-")
            {
                var second = stack.Pop();
                var first = stack.Pop();
                stack.Push(first - second);
            }
            else if (token == "*")
            {
                stack.Push(stack.Pop() * stack.Pop());
            }
            else if (token == "/")
            {
                var second = stack.Pop();
                var first = stack.Pop();
                stack.Push(first / second);
            }
            else
            {
                stack.Push(int.Parse(token));
            }
        }

        return stack.Pop();
    }
}

public class EvaluateRPNTest
{
    [Fact]
    public void Test_EvalRPN()
    {
        var obj = new EvaluateRPN();
        var tokens = new string[] { "2", "1", "+", "3", "*", "4", "/" };
        Assert.Equal(2, obj.EvalRPN(tokens));
    }
}