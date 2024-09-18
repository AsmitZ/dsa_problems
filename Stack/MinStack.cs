using Xunit;

namespace Problems.Stack;

public class MinStack
{
    private const int Max = 10000;
    private int[] _stack;
    private int[] _minStack;
    private int _top;
    
    public MinStack()
    {
        _top = -1;
        _stack = new int[Max];
        _minStack = new int[Max];
    }
    
    public void Push(int val)
    {
        if (_top == Max - 1)
        {
            throw new StackOverflowException();
        }
        
        _stack[++_top] = val;
        if (_top == 0)
        {
            _minStack[_top] = val;
        }
        else
        {
            _minStack[_top] = Math.Min(_minStack[_top - 1], val);
        }
    }
    
    public void Pop()
    {
        if (_top == -1)
        {
            return;
        }
        _top--;
    }
    
    public int Top()
    {
        if (_top == -1)
        {
            return -1;
        }
        return _stack[_top];
    }
    
    public int GetMin()
    {
        if (_top == -1)
        {
            return -1;
        }
        return _minStack[_top];
    }
}

public class MinStackTest
{
    [Fact]
    public void Validate()
    {
        MinStack obj = new MinStack();
        obj.Push(5);
        obj.Pop();
        int param_3 = obj.Top();
        int param_4 = obj.GetMin();
        Assert.Equal(-1, param_3);
        Assert.Equal(-1, param_4);
    }
}