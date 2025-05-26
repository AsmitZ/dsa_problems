namespace Algorithms.Array_Hashset;

// Question - https://takeuforward.org/data-structure/find-the-duplicate-in-an-array-of-n1-integers/
public static class DuplicateInArrayWithN_1Elements
{
    public static int FindDuplicate(int[] arr)
    {
        int slow = arr[0];
        int fast = arr[0];

        do
        {
            slow = arr[slow];
            fast = arr[arr[fast]];
        }
        while (slow != fast);

        fast = arr[0];
        while (fast != slow)
        {
            slow = arr[slow];
            fast = arr[fast];
        }

        System.Console.WriteLine("Duplicate element is: " + slow);
        return slow;
    }
}