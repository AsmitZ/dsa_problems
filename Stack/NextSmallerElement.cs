namespace Algorithms.Stack;

static class NextSmallerelement
{
    public static int[] Find(int[] arr)
    {
        int n = arr.Length;
        var result = new int[n];
        var stack = new Stack<int>();

        for (int i = n - 1; i >= 0; i--)
        {
            while (stack.Count > 0 && stack.Peek() >= arr[i])
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