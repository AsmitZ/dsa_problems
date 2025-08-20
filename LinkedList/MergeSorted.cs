namespace Algorithms.LinkedList;

public class MergeSortedList
{
    public class ListNode
    {
        public int val { get; set; }
        public ListNode next { get; set; }

        public ListNode(int val)
        {
            this.val = val;
            this.next = null;
        }
    }

    public static void PrintLinkedList(ListNode head)
    {
        ListNode temp = head;
        while (temp != null)
        {
            System.Console.Write(temp.val + " ");
            temp = temp.next;
        }
        System.Console.WriteLine();
    }

    public static ListNode Merge(ListNode list1, ListNode list2)
    {
        ListNode newHead = null;
        ListNode pointer = null;

        while (list1 != null && list2 != null)
        {
            ListNode newNode;
            if (list1.val < list2.val)
            {
                newNode = new ListNode(list1.val);
                list1 = list1.next;
            }
            else
            {
                newNode = new ListNode(list2.val);
                list2 = list2.next;
            }

            if (newHead == null)
            {
                newHead = newNode;
                pointer = newNode;
            }
            pointer.next = newNode;
            pointer = pointer.next;
        }

        if (list1 != null)
            pointer.next = list1;

        if (list2 != null)
            pointer.next = list2;

        return newHead;
    }
}