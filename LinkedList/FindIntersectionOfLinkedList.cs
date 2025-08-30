using static Algorithms.LinkedList.MergeSortedList;

namespace Algorithms.LinkedList;

// Question- https://takeuforward.org/data-structure/find-intersection-of-two-linked-lists/
public static class Intersection
{
    public static ListNode? Find(ListNode headA, ListNode headB)
    {
        if (headA == null || headB == null) return null;

        var dummy1 = headA;
        var dummy2 = headB;

        while (dummy1 != dummy2)
        {
            dummy1 = dummy1 == null ? headB : dummy1.next;
            dummy2 = dummy2 == null ? headA : dummy2.next;
        }

        return dummy1;
    }
}