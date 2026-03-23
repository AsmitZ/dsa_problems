namespace Algorithms.LinkedList;

using static Algorithms.LinkedList.MergeSortedList;

static class ReorderList
{
    public static ListNode Do(ListNode head)
    {
        // find mid of the list
        ListNode slow = head;
        ListNode fast = head;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        // split
        var secondHead = slow.next;
        slow.next = null;

        // reverse from second head
        secondHead = Reverse(secondHead);

        // Merge from each
        var first = head;
        while (secondHead != null)
        {
            var temp1 = first.next;
            var temp2 = secondHead.next;

            first.next = secondHead;
            secondHead.next = temp1;

            first = temp1;
            secondHead = temp2;
        }

        return head;
    }

    private static ListNode? Reverse(ListNode node)
    {
        if (node == null || node.next == null)
        {
            return node;
        }

        ListNode? prev = null;
        ListNode curr = node;
        while(curr != null)
        {
            var next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }

        return prev;
    }
}