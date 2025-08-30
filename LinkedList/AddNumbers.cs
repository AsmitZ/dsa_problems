namespace Algorithms.LinkedList;

// Definition for singly-linked list.
public class NListNode
{
    public int val;
    public NListNode next;
    public NListNode(int val = 0, NListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

// Question - https://takeuforward.org/data-structure/add-two-numbers-represented-as-linked-lists/
public static class AddNumbers
{
    public static NListNode AddTwoNumbers(NListNode l1, NListNode l2)
    {
        int tenthDigit = 0;
        NListNode p1 = l1;
        NListNode p2 = l2;
        NListNode newHead = new();
        NListNode head = newHead;

        while (p1 != null && p2 != null)
        {
            var d1 = p1?.val ?? 0;
            var d2 = p2?.val ?? 0;
            var r = d1 + d2 + tenthDigit;
            tenthDigit = r / 10;
            int onceDigit = r % 10;
            var newNode = new NListNode(onceDigit);
            head.next = newNode;
            head = newNode;

            if (p1 != null) p1 = p1.next;
            if (p2 != null) p2 = p2.next;
        }

        return newHead.next;
    }

    public static void PrintLinkedList(NListNode head)
    {
        NListNode temp = head;
        while (temp != null)
        {
            System.Console.Write(temp.val + " ");
            temp = temp.next;
        }
        System.Console.WriteLine();
    }
}