using System;
using System.Collections.Generic;

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
    public static void RemoveDuplicates(ListNode head)
    {
        if (head == null) return;

        HashSet<int> seen = new HashSet<int>();
        ListNode current = head;
        ListNode previous = null;

        while (current != null)
        {
            // If the value is already in the set, remove the current node
            if (seen.Contains(current.Val))
            {
                previous.Next = current.Next; // Skip the current node
            }
            else
            {
                // If the value is not in the set, add it to the set
                seen.Add(current.Val);
                previous = current; // Move the previous pointer
            }

            current = current.Next; // Move to the next node
        }
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
        // Creating Linked List: 1 → 2 → 3 → 2 → 4 → 5 → 3
        ListNode head = new ListNode(1, new ListNode(2, new ListNode(3,
                      new ListNode(2, new ListNode(4, new ListNode(5,
                      new ListNode(3))))))));

        Console.WriteLine("Original Linked List:");
        PrintList(head);

        // Remove duplicates
        RemoveDuplicates(head);

        Console.WriteLine("Linked List after removing duplicates:");
        PrintList(head);
    }
}
