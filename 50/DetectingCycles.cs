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

public class LinkedListCycle
{
    // Function to detect if a cycle exists in the linked list
    public static bool HasCycle(ListNode head)
    {
        if (head == null) return false;

        ListNode slow = head;
        ListNode fast = head;

        // Move slow by one and fast by two steps
        while (fast != null && fast.Next != null)
        {
            slow = slow.Next;
            fast = fast.Next.Next;

            if (slow == fast) // Cycle detected
            {
                return true;
            }
        }

        return false; // No cycle
    }

    // Function to find the starting node of the cycle
    public static ListNode FindCycleStart(ListNode head)
    {
        if (head == null) return null;

        ListNode slow = head;
        ListNode fast = head;

        // Detect cycle first
        while (fast != null && fast.Next != null)
        {
            slow = slow.Next;
            fast = fast.Next.Next;

            if (slow == fast) // Cycle detected
            {
                // Find the start of the cycle
                slow = head; // Move slow pointer back to head
                while (slow != fast)
                {
                    slow = slow.Next;
                    fast = fast.Next;
                }
                return slow; // The node where both pointers meet is the start of the cycle
            }
        }

        return null; // No cycle
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

        // Creating a cycle: 6 → 3 (cycle starts at node 3)
        head.Next.Next.Next.Next.Next.Next = head.Next.Next; // Node 3

        Console.WriteLine("Detecting Cycle:");
        Console.WriteLine(HasCycle(head) ? "Cycle detected!" : "No cycle.");

        // Finding the cycle start node
        ListNode cycleStart = FindCycleStart(head);
        if (cycleStart != null)
        {
            Console.WriteLine("Cycle starts at node with value: " + cycleStart.Val);
        }
        else
        {
            Console.WriteLine("No cycle.");
        }
    }
}
