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
    public static ListNode FindThirdFromEnd(ListNode head)
    {
        if (head == null || head.Next == null || head.Next.Next == null)
        {
            Console.WriteLine("List has fewer than 3 nodes.");
            return null;
        }

        ListNode fast = head;
        ListNode slow = head;

        // Move fast pointer 3 steps ahead
        for (int i = 0; i < 3; i++)
        {
            if (fast != null)
                fast = fast.Next;
        }

        // Move both pointers until fast reaches the end
        while (fast != null)
        {
            slow = slow.Next;
            fast = fast.Next;
        }

        return slow; // slow is now the third node from the end
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
                      new ListNode(4, new ListNode(5, new ListNode(6))))));

        Console.WriteLine("Linked List:");
        PrintList(head);

        ListNode result = FindThirdFromEnd(head);
        if (result != null)
        {
            Console.WriteLine($"Third node from the end is: {result.Val}");
        }
    }
}
