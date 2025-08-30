using static Algorithms.LinkedList.MergeSortedList;

namespace Algorithms.LinkedList;

// Question - https://takeuforward.org/data-structure/starting-point-of-loop-in-a-linked-list/
public static class CyclePoint
{
    public static ListNode? Find(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return null;
        }
        var slow = head;
        var fast = head;
        bool hasCycle = false;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;

            if (slow == fast)
            {
                hasCycle = true;
                slow = head;
                break;
            }
        }

        if (hasCycle)
        {
            while (slow != fast)
            {
                slow = slow.next;
                fast = fast.next;
            }

            return slow;
        }

        return null;
    }
}