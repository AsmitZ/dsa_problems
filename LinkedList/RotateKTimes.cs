using static Algorithms.LinkedList.MergeSortedList;

namespace Algorithms.LinkedList;

// Question - https://takeuforward.org/data-structure/rotate-a-linked-list/
public static class RotateListKTimes
{
    public static ListNode Rotate(ListNode head, int k)
    {
        if (head == null || head.next == null || k == 0)
        {
            return head;
        }

        //Find length
        var tail = head;
        int length = 1;
        while (tail.next != null)
        {
            length += 1;
            tail = tail.next;
        }

        if (k == length) return head;

        //Find n
        k = k % length;

        // connect
        tail.next = head;

        // find movements
        k = length - k;

        // move and break
        while (k > 0)
        {
            tail = tail.next;
            k--;
        }

        var newHead = tail.next;
        tail.next = null;
        return newHead;
    }
}