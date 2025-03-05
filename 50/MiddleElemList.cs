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

public class LinkedListMiddle
{
    // Function to find the middle element of the linked list
    public static ListNode FindMiddle(ListNode head)
    {
        if (head == null)
        {
            return null;
        }

        ListNode slow = head;
        ListNode fast = head;

        // Move fast by two steps and slow by one step
        while (fast != null && fast.Next != null)
        {
            slow = slow.Next;
            fast = fast.Next.Next;
        }

        return slow; // Slow is now at the middle node
    }

    // Helper function to print the linked list (for debugging)
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
        ListNode head = new ListNode(1);
        head.Next = new ListNode(2);
        head.Next.Next = new ListNode(3);
        head.Next.Next.Next = new ListNode(4);
        head.Next.Next.Next.Next = new ListNode(5);
        head.Next.Next.Next.Next.Next = new ListNode(6);

        // Finding the middle element
        ListNode middle = FindMiddle(head);
        if (middle != null)
        {
            Console.WriteLine("Middle element is: " + middle.Val);
        }
        else
        {
            Console.WriteLine("List is empty.");
        }
    }
}
