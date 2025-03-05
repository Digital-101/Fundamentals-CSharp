using System;

public class ListNode
{
    public int Val;
    public ListNode Next;

    public ListNode(int val = 0, ListNode next = null)
    {
        Val = val;
        Next = next;
    }
}

public class LinkedListOperations
{
    public static int FindLength(ListNode head)
    {
        int length = 0;
        ListNode current = head;

        // Traverse the list and count the nodes
        while (current != null)
        {
            length++;
            current = current.Next;
        }

        return length;
    }

    // Helper function to print linked list
    public static void PrintList(ListNode node)
    {
        while (node != null)
        {
            Console.Write(node.Val + " → ");
            node = node.Next;
        }
        Console.WriteLine("NULL");
    }

    public static void Main()
    {
        // Creating Linked List: 1 → 2 → 3 → 4 → 5 → 6
        ListNode head = new ListNode(1, new ListNode(2, new ListNode(3,
                      new ListNode(4, new ListNode(5, new ListNode(6)))))));

        Console.WriteLine("Linked List:");
        PrintList(head);

        int length = FindLength(head);
        Console.WriteLine($"Length of the list is: {length}");
    }
}
