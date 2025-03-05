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
    public static ListNode ReverseList(ListNode head)
    {
        ListNode previous = null;
        ListNode current = head;

        while (current != null)
        {
            ListNode nextNode = current.Next; // Store next node
            current.Next = previous; // Reverse the current node's pointer
            previous = current; // Move previous and current one step forward
            current = nextNode;
        }

        return previous; // New head of the reversed list
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
        // Creating Linked List: 1 → 2 → 3 → 4 → 5
        ListNode head = new ListNode(1, new ListNode(2, new ListNode(3,
                      new ListNode(4, new ListNode(5))))));

        Console.WriteLine("Original Linked List:");
        PrintList(head);

        // Reverse the linked list
        head = ReverseList(head);

        Console.WriteLine("Reversed Linked List:");
        PrintList(head);
    }
}
