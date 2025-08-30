namespace Algorithms.LinkedList;

// Question - https://takeuforward.org/data-structure/find-middle-element-in-a-linked-list/
public class MiddleElement
{
    public static Node Find(Node head)
    {
        if (head == null || head.Next == null)
        {
            return head;
        }

        Node p1 = head;
        Node p2 = head;

        while (p2 != null && p2.Next != null)
        {
            p1 = p1.Next;
            p2 = p2.Next.Next;
        }

        return p1;
    }
}