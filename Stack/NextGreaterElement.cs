namespace Algorithms.Stack;

public static class NextGreaterElement
{
    public static int[] Find_v1(int[] arr)
    {
        var n = arr.Length;
        var stack = new Stack<int>();
        var result = new int[n];

        for (int i = 2*n-1; i >= 0; i--)
        {
            while (stack.Count > 0 && stack.Peek() <= arr[i % n])
            {
                stack.Pop();
            }

            if (i < n)
            {
                if (stack.Count == 0)
                {
                    result[i] = -1;
                }
                else
                {
                    result[i] = stack.Peek();
                }
            }

            stack.Push(arr[i % n]);
        }

        return result;
    }
    public static int[] Find(int[] arr)
    {
        var n = arr.Length;
        var stack = new Stack<int>();
        var result = new int[n];

        for (int i = n-1; i >= 0; i--)
        {
            while (stack.Count > 0 && stack.Peek() <= arr[i])
            {
                stack.Pop();
            }

            if (stack.Count == 0)
            {
                result[i] = -1;
            }
            else
            {
                result[i] = stack.Peek();
            }

            stack.Push(arr[i]);
        }

        return result;
    }
}