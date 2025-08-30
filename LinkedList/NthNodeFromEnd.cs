using static Algorithms.LinkedList.MergeSortedList;

namespace Algorithms.LinkedList;

// Question - https://takeuforward.org/data-structure/remove-n-th-node-from-the-end-of-a-linked-list/
public partial class LinkedList
{
    public static ListNode FindNthNodeFromEnd(ListNode list, int n)
    {
        ListNode fast = list;
        ListNode slow = list;

        for (int i = 0; i < n; i++)
        {
            fast = fast.next;
        }

        while (fast.next != null)
        {
            slow = slow.next;
            fast = fast.next;
        }

        if (fast == null)
        {
            return list;
        }

        return slow.next;
    }

    public static ListNode RemomveNthNodeFromEnd(ListNode head, int n)
    {
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        ListNode fast = dummy;
        ListNode slow = dummy;

        for (int i = 0; i < n; i++)
        {
            fast = fast.next;
        }

        while (fast.next != null)
        {
            slow = slow.next;
            fast = fast.next;
        }

        ListNode nodeToDelete = slow.next;
        slow.next = nodeToDelete.next;
        nodeToDelete.next = null;

        return dummy.next;
    }
}