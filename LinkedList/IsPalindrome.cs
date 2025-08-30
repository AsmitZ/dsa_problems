using static Algorithms.LinkedList.MergeSortedList;

namespace Algorithms.LinkedList;

// Question - https://takeuforward.org/data-structure/check-if-given-linked-list-is-plaindrome/
public static class Palindrome
{
    public static bool IsPalindrome(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return true;
        }

        var middle = FindMiddle(head);
        var reversedHead = ReverseList(middle);

        while (head != null && reversedHead != null)
        {
            if (head.val != reversedHead.val)
            {
                return false;
            }

            head = head.next;
            reversedHead = reversedHead.next;
        }


        return true;
    }

    public static ListNode FindMiddle(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return head;
        }

        ListNode p1 = head;
        ListNode p2 = head;

        while (p2 != null && p2.next != null)
        {
            p1 = p1.next;
            p2 = p2.next.next;
        }

        return p1;
    }

    private static ListNode ReverseList(ListNode head)
    {
        var curr = head;
        ListNode prev = null;
        while (curr != null)
        {
            var nextTemp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = nextTemp;
        }
        return prev;
    }
}