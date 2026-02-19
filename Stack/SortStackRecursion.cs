namespace Algorithms.Stack;

public static class SortStack
{
    public static void Sort(Stack<int> stack)
    {
        if (stack.Count == 0) return;
        var temp = stack.Pop();
        Sort(stack);
        Insert(stack, temp);
    }

    private static void Insert(Stack<int> stack, int temp)
    {
        if (stack.Count == 0 || stack.Peek() <= temp)
        {
            stack.Push(temp);
            return;
        }

        var temp2 = stack.Pop();
        Insert(stack, temp);
        stack.Push(temp2);
    }
}