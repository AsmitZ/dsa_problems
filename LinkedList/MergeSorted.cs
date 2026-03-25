namespace Algorithms.LinkedList;

// Question- https://takeuforward.org/data-structure/merge-two-sorted-linked-lists/
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

    public static ListNode Merge(ListNode? list1, ListNode? list2)
    {
        ListNode newHead = new(0);
        ListNode pointer = newHead;

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

            pointer.next = newNode;
            pointer = pointer.next;
        }

        if (list1 != null)
            pointer.next = list1;

        if (list2 != null)
            pointer.next = list2;

        return newHead.next;
    }

    public static ListNode? MergeKLists(ListNode[] lists)
    {
        if (lists.Length == 0) return null;
        if (lists.Length == 1) return lists[0];

        while(lists.Length > 1)
        {
            List<ListNode> mergedList = [];

            for (int i = 0; i < lists.Length; i += 2)
            {
                var list1 = lists[i];
                var list2 = i + 1 == lists.Length ? null : lists[i + 1];
                var mergedNode = Merge(list1, list2);
                mergedList.Add(mergedNode);
            }

            lists = [.. mergedList];
        }

        return lists[0];
    }
}