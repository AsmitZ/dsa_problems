namespace Algorithms.LinkedList;

// Question - https://takeuforward.org/data-structure/reverse-a-linked-list/
public class ReverseLinkedList
{
    public static void PrintLinkedList(Node head)
    {
        Node temp = head;
        while (temp != null)
        {
            System.Console.Write(temp.Data + " ");
            temp = temp.Next;
        }
        System.Console.WriteLine();
    }

    public static Node Reverse(Node head)
    {
        if (head == null || head.Next == null)
        {
            return head;
        }

        var newHead = Reverse(head.Next);

        Node front = head.Next;
        front.Next = head;
        head.Next = null;

        return newHead;
    }

    public static Node ReverseLoop(Node head)
    {
        Node? prev = null;
        Node curr = head;

        while (curr != null)
        {
            var nxt = curr.Next;
            curr.Next = prev;
            prev = curr;
            curr = nxt;
        }
        
        return prev;
    }
}

public class Node {
    public int Data { get; set; }
    public Node Next { get; set; }

    public Node(int data, Node node)
    {
        Data = data;
        Next = node;
    }

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}